using System.Net;

namespace url_parser
{
    internal class Program
    {
        static Semaphore scraper = new Semaphore(2, 2);
        static Dictionary<string, decimal> prices = new();
        static object lockObject = new object();

        static List<string> ReadUrls(string fileName)
        {
            return File.ReadLines(fileName).ToList();
        }

        static decimal ParsePriceFromUrlEmag(string url)
        {
            string siteData;
            using (WebClient client = new WebClient())
            {
                siteData = client.DownloadString(url);
            }
            int priceStart = siteData.IndexOf("productFullPrice = ") + 19;
            int priceEnd = siteData.IndexOf(";", priceStart);
            decimal price = decimal.Parse(siteData.Substring(priceStart, priceEnd - priceStart));
            return price;
        }

        static decimal ParsePriceFromUrlBestBestPc(string url)
        {
            string siteData;
            using (WebClient client = new WebClient())
            {
                siteData = client.DownloadString(url);
            }
            int priceStart = siteData.IndexOf("<meta itemprop=\"price\" content=\"") + 32;
            int priceEnd = siteData.IndexOf("\">", priceStart);
            decimal price = decimal.Parse(siteData.Substring(priceStart, priceEnd - priceStart));
            return price;
        }

        static void Scrape(object data)
        {
            string url = (string)data;
            scraper.WaitOne();
            try
            {
                decimal price = ParsePriceFromUrlEmag(url);
                lock (lockObject)
                {
                    prices[url] = price;
                }
            } finally
            {
                scraper.Release();
            }
        }

        static void Main(string[] args)
        {
            List<string> urls = ReadUrls("..\\..\\..\\urls_emag.txt");
            List<Thread> threads = new();

            foreach (string url in urls)
            {
                Thread newThread = new Thread(Scrape!);
                newThread.Start(url);
                threads.Add(newThread);
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
            decimal cheapest = decimal.MaxValue;
            string cheapestUrl = "";
            foreach (var price in prices)
            {
                Console.WriteLine($"{price.Key} - {price.Value}");
                if (price.Value < cheapest)
                {
                    cheapest = price.Value;
                    cheapestUrl = price.Key;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Cheapest url is {cheapestUrl} and the price is {cheapest}");
        }
    }
}