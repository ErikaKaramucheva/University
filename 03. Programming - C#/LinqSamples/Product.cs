using System;
using System.Collections.Generic;
using System.Text;

namespace LinqSamples
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"Product: {ProductName}, Category: {Category}, Unitprice: {UnitPrice},  UnitsInStock: {UnitsInStock}";
        }
    }
}
