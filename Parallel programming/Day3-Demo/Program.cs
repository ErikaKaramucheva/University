using Day3_Demo;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Progrma
{
    static List<Product> products = new List<Product>();

    private readonly HttpClient _httpClient = new HttpClient();

    static void ReadFile(string filePath)
    {
        StreamReader sr = new StreamReader(filePath);
        string line=sr.ReadLine();
        while(line != null)
        {
            var info = line.Split(',');
            string name=info[0];
            string url=info[1];
            products.Add(new Product(name, url));
        }

    }
     void ExtractPrice()
    {
        foreach (var product in products)
        {
            decimal price = GetPrice(product.Url);

        }
    }
     async Task<decimal> GetPrice(string url)
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

    public static void Main(string[] args)
    {

    }
}