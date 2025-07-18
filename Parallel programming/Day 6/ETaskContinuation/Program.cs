using System.Net;

namespace ETaskContinuation
{
    internal class Program
    {
        const string quoteUrl = "https://nvp-functions.azurewebsites.net/api/qotd?slow=true";
        
        static string DownloadQuote(string url)
        {
            WebClient client = new();
            return client.DownloadString(quoteUrl);
        }

        static void Main(string[] args)
        {
            //1. Linear workflow.
            Task.Run(() => 42)
                .ContinueWith(preceding => preceding.Result.ToString())
                .ContinueWith(preceding => Console.WriteLine(preceding.Result));


            //2. Fan Out.
            var firstTask = Task.Run(() => quoteUrl);
            Task<string>[] tasks =                
                [
                    firstTask.ContinueWith(p => DownloadQuote(p.Result)),
                    firstTask.ContinueWith(p => DownloadQuote(p.Result)),
                    firstTask.ContinueWith(p => DownloadQuote(p.Result)),
                    firstTask.ContinueWith(p => DownloadQuote(p.Result)),
                    firstTask.ContinueWith(p => DownloadQuote(p.Result)),
                ];
            var fanInTask = Task.WhenAll (tasks);
            fanInTask.ContinueWith(p =>
            {
                var quotes = p.Result.OrderBy(s => s[0]);
                foreach (var quote in quotes)
                {
                    Console.WriteLine(quote);
                }
            });

            Console.ReadLine();
        }
    }
}
