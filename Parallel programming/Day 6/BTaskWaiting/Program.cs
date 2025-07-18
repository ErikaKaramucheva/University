
using System.Net;
using static System.Net.WebRequestMethods;

namespace BTaskWaiting
{
    internal class Program
    {
        const string quoteUrl = "https://nvp-functions.azurewebsites.net/api/qotd?slow=true";
        static void Main(string[] args)
        {
            //1. Creating a task
            Task t1 =
                Task.Run(() => { Console.WriteLine("Hello from my task!"); });

            //2. Waiting for a task to complete.  Blocks the calling thread.
            t1.Wait();

            //3. Fan-out:
            Console.WriteLine("Creating some tasks to download some data:");
            List<Task> tasks = Enumerable.Range(0, 5)
                .Select(i => Task.Run(() =>
                        {
                            WebClient client = new();
                            string s = client.DownloadString(quoteUrl);
                            Console.WriteLine(s);
                        })).ToList();

            //4. Fan-in
            Task finalTask = Task.WhenAll (tasks);
            //Same as:
            //var finalTask = Task.Run (
            //   () => { foreach (var t in tasks) t.Wait(); } );
            Console.WriteLine("Waiting for all tasks to complete...");
            finalTask.Wait();
        }

    }
}
