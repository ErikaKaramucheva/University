namespace GMoreSignals
{
    internal class Program
    {
        static int Data;

        static ManualResetEvent signalOne, signalTwo;

        static void WorkerOne()
        {
            Console.WriteLine("One starts.");
            Console.WriteLine("One is doing something...");
            Thread.Sleep(2000);
            Data = 42;
            Console.WriteLine("One signals Two to start.");
            signalTwo.Set();
            Console.WriteLine("One is working a bit more");
            Thread.Sleep(1000);
            Console.WriteLine("One waits for Two.");
            signalOne.WaitOne();
            Console.WriteLine("Data: " + Data.ToString());
            Console.WriteLine("One finishes.");
        }

        static void WorkerTwo()
        {
            Console.WriteLine("Two starts.");
            Console.WriteLine("Two is doing something.");
            Thread.Sleep(1000);
            Console.WriteLine("Two is waiting for One.");
            signalTwo.WaitOne();
            Console.WriteLine("Two is working again.");
            Data = Data * 2;
            Thread.Sleep(1000);
            Console.WriteLine("Two is signaling One.");
            signalOne.Set();
            Console.WriteLine("Two finishes.");
        }

        static void Main(string[] args)
        {
            signalOne = new ManualResetEvent(false);
            signalTwo = new ManualResetEvent(false);
            Thread t1 = new Thread(WorkerOne);
            Thread t2 = new Thread(WorkerTwo);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
