namespace ESignals
{
    internal class Program
    {
        static ManualResetEvent signalCancel;

        static void Worker()
        {
            DateTime start = DateTime.Now;
            while (DateTime.Now - start < TimeSpan.FromSeconds(5))
            {
                if (signalCancel.WaitOne(0))
                {
                    //Cancellation requested.  Clean up and leave.
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            signalCancel = new ManualResetEvent(false);

            Console.WriteLine("Firing up a thread.  Press c to cancel it.");
            Thread t = new Thread(Worker);
            t.Start();

            while (!t.Join(200))
            {
                if (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey();
                    if (Char.ToUpper(cki.KeyChar) == 'C') signalCancel.Set();
                }
            }
            Console.WriteLine("Thread finished.");

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();

        }
    }
}
