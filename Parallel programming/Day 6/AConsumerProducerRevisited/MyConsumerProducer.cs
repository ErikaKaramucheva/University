namespace AConsumerProducerRevisited
{
    class MyConsumerProducer<T>
    {
        Queue<T> dataBuffer = new();
        Action<T> consumerAction { get; set; }

        //Called by the tasks / processed / threads of the producers
        public void ProduceData(T dataItem)
        {
            if (!workSignal.WaitOne(0)) throw new OperationCanceledException();
            lock (dataBuffer)
            {
                dataBuffer.Enqueue (dataItem);
                dataAvailableSignal.Set ();
                dataAvailableSemaphore.Release(); //We let a consumer work!
            }
        }

        public MyConsumerProducer(Action<T> consumerAction)
        {
            this.consumerAction = consumerAction;
        }

        private ManualResetEvent workSignal = new ManualResetEvent(true);
        private ManualResetEvent cancelSignal = new ManualResetEvent(false);
        private ManualResetEvent dataAvailableSignal = new ManualResetEvent(false);
        private SemaphoreSlim dataAvailableSemaphore = new SemaphoreSlim(0);

        private void ConsumerWorker()
        {
            //while (workSignal.WaitOne(0))
            //{
            //    //Option 1: wait forever, and STOP must set this signal to let us acknowlege the cancel signal.
            //    //dataAvailableSignal.WaitOne();

            //    //Option 2: wait for 100ms, and if there is no data, just check the cancel signal. 
            //    //if (!dataAvailableSignal.WaitOne(100)) continue;

            //    //Option 3: use a semaphore to avoid the stampede effect of all consumers waking up
            //    dataAvailableSemaphore.Wait();

            //    bool hasData = false;
            //    T dataItem;
            //    lock (dataBuffer)
            //    {
            //        hasData = dataBuffer.TryDequeue(out dataItem);
            //    }
            //    if (hasData) consumerAction(dataItem);
            //}

            //Option 4: wait for EITHER cancelation OR work available.
            while (true)
            {
                int signalIndex = WaitHandle.WaitAny(
                [
                    cancelSignal,
                    dataAvailableSemaphore.AvailableWaitHandle
                ]);
                if (signalIndex == 0) break; //cancelSignal is  set.
                else
                {
                    bool hasData = false;
                    T dataItem;
                    lock (dataBuffer)
                    {
                        hasData = dataBuffer.TryDequeue(out dataItem);
                    }
                    if (hasData) consumerAction(dataItem);
                    //Lock the queue, get an element, release the lock, call the delegate, see above.
                }
            }
        }

        List<Thread> consumerThreads = new List<Thread>();

        public void Run(int consumerCount = 5)
        {
            for (int i = 0; i < consumerCount; i++)
            {
                var t = new Thread(ConsumerWorker);
                t.Start();
                consumerThreads.Add(t);
            }
        }

        public void Stop()
        {
            workSignal.Reset();
            dataAvailableSignal.Set();
            cancelSignal.Set();
            foreach (var t in consumerThreads) t.Join();
        }
    }
}
