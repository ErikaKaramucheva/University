using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.ViewModels
{
    public class AddProductVM
    {
        public string Name { get; set; }

        public int Category { get; set; }
        public double Quantity { get; set; }
        public string Priority { get; set; }
    }
}
