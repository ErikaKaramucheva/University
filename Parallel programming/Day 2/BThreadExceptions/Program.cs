namespace BThreadExceptions
{
    internal class Program
    {
        static Exception WorkerException;
        static void FaultyWorker()
        {
            Console.WriteLine("Thread worker started.");
            try
            {
                Thread.Sleep(2000);
                int a = 0;
                int b = 10 / a;
            }
            catch (Exception ex)
            {
                WorkerException = ex;
            }
            Console.WriteLine("Thread worker ended.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting a thread.");
            Thread t = new Thread(FaultyWorker);
            try
            {
                t.Start();
                Console.WriteLine("Waiting for the thread to complete...");
                t.Join();
                if (WorkerException is null)
                {
                    Console.WriteLine("Thread finished working.");
                }
                else
                {
                    Console.WriteLine("Thread faulted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred.");
            }
            Console.ReadLine();
        }
    }
}
