using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Demo
{
    
    internal class Product
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
        public Product() { }
        public Product(string name,string url,decimal price) {
            this.Name = name;
            this.Url = url;
            this.Price = price;
        }
        public Product(string name, string url)
        {
            this.Name = name;
            this.Url = url;

    }
}
