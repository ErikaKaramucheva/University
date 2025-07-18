using System;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            var example1 = t.findProductByID(3);
            Console.WriteLine(example1.ToString());
            var example2 = t.findFirstProductByID(5);
            Console.WriteLine(example2.ToString());
            var example3 = t.FindProductsInStocks();
            Console.WriteLine(example3.ToString());
        }
    }
}
