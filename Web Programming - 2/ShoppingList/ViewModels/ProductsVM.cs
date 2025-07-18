using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.ViewModels
{
    public class ProductsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Priority { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
}
