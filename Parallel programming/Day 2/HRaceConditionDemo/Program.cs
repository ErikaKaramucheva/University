namespace HRaceConditionDemo
{
    internal class Program
    {
        static int Data;
        static object lockObj = new object();

        static void Worker(object tag)
        {
            string name = tag.ToString();
            //Monitor.Enter(lockObj); //Locking too much!
            for (int i = 0; i < 10; i ++)
            {
                int localData;
                Monitor.Enter(lockObj);
                Data = Data + 1;
                Thread.Sleep(3);
                Data = Data - 1;
                localData = Data;
                Monitor.Exit(lockObj);
                Console.WriteLine($"{tag}: {localData}");
            }
            //Monitor.Exit(lockObj);
        }

        static void Main(string[] args)
        {
            Data = 100;
            Thread t1 = new Thread(Worker);
            t1.Start("A");
            Thread t2 = new Thread(Worker);
            t2.Start("B");

            t1.Join(); t2.Join();

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
