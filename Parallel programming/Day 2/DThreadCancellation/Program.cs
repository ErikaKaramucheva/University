namespace DThreadCancellation
{
    internal class Program
    {
        static bool ShouldStop;
        static bool WorkCompleted;

        static void Worker()
        {
            WorkCompleted = false;
            DateTime start = DateTime.Now;
            while (DateTime.Now - start < TimeSpan.FromSeconds(5))
            {
                if (ShouldStop)
                {
                    //Clean up what you do...
                    return;
                }
            }
            WorkCompleted = true;
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(Worker);
            t.Start();
            Console.WriteLine("Thread started.  Press C to cancel it.");
            while (!t.Join(200))
            {
                if (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey();
                    if (Char.ToUpper(cki.KeyChar) == 'C') ShouldStop = true;
                }
            }
            Console.WriteLine("Thread complted.");

        }
    }
}
