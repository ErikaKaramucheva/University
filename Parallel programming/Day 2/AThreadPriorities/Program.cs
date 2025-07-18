namespace AThreadPriorities
{
    internal class Program
    {
        static bool KeepRunning;
        
        static void IdleWorker()
        {
            while (KeepRunning) ;
        }

        static void Main(string[] args)
        {
            KeepRunning = true;

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                Thread t = new Thread(IdleWorker);
                t.Priority = ThreadPriority.Lowest;
                t.Start();
            }
            Console.WriteLine("All threads are running.  Press ENTER to stop.");
            Console.ReadLine();
            KeepRunning = false;

        }
    }
}
