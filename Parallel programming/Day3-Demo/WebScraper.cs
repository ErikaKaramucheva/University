using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day3_Demo
{
    internal class WebScraper
    {
        private readonly HttpClient _httpClient=new HttpClient();

        public async Task<decimal> GetPrice(string url)
        {
            string html = await _httpClient.GetStringAsync(url);
            decimal price = ExtractPrice(html);
            return price;

        }
        private decimal ExtractPrice(string html)
        {
            // Търсим число с десетична точка или запетая
            var match = Regex.Match(html, @"(\d+[\.,]?\d*)\s?(лв|BGN|€|\$)");

            if (match.Success)
            {
                string priceText = match.Groups[1].Value.Replace(",", ".");
                if (decimal.TryParse(priceText, out decimal price))
                {
                    return price;
                }
            }

            return -1;
        }
    }
//    static async Task Main()
//    {
//        var products = ReadCsv("products.csv");
//        var scraper = new WebScraper();
//        await scraper.ProcessProducts(products);
//    }

//    static List<Product> ReadCsv(string filePath)
//    {
//        using var reader = new StreamReader(filePath);
//        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
//        return csv.GetRecords<Product>().ToList();
//    }
//}

//class Product
//{
//    public string ProductName { get; set; }
//    public string Url { get; set; }
//}

//class WebScraper
//{
//    private readonly HttpClient _httpClient = new HttpClient();
//    private readonly Dictionary<string, SemaphoreSlim> _semaphores = new();
//    private const int MaxConnectionsPerDomain = 2;

//    public async Task ProcessProducts(List<Product> products)
//    {
//        var groupedProducts = products.GroupBy(p => p.ProductName);

//        foreach (var group in groupedProducts)
//        {
//            Console.WriteLine($"Processing product: {group.Key}");
//            var tasks = group.Select(p => GetPriceAsync(p)).ToList();
//            var prices = await Task.WhenAll(tasks);

//            var bestPrice = prices.Where(p => p.Price > 0).OrderBy(p => p.Price).FirstOrDefault();
//            if (bestPrice != null)
//            {
//                Console.WriteLine($"Lowest price for {group.Key}: {bestPrice.Price} at {bestPrice.Url}");
//            }
//        }
//    }

//    private async Task<PriceResult> GetPriceAsync(Product product)
//    {
//        string domain = new Uri(product.Url).Host;
//        if (!_semaphores.ContainsKey(domain))
//        {
//            _semaphores[domain] = new SemaphoreSlim(MaxConnectionsPerDomain);
//        }

//        await _semaphores[domain].WaitAsync();
//        try
//        {
//            var html = await _httpClient.GetStringAsync(product.Url);
//            var price = ExtractPrice(html);
//            return new PriceResult { Url = product.Url, Price = price };
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error fetching {product.Url}: {ex.Message}");
//            return new PriceResult { Url = product.Url, Price = -1 };
//        }
//        finally
//        {
//            _semaphores[domain].Release();
//        }
//    }

//    private decimal ExtractPrice(string html)
//    {
//        var doc = new HtmlDocument();
//        doc.LoadHtml(html);

//        // Тук трябва да анализираш HTML и да намериш правилния XPath или CSS селектор
//        var priceNode = doc.DocumentNode.SelectSingleNode("//span[contains(@class, 'price')]");
//        if (priceNode != null && decimal.TryParse(priceNode.InnerText.Trim().Replace("лв.", ""), out decimal price))
//        {
//            return price;
//        }
//        return -1;
//    }
//}

//class PriceResult
//{
//    public string Url { get; set; }
//    public decimal Price { get; set; }
//}

}
