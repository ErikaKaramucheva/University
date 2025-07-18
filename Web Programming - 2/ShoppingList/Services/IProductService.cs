using ShoppingList.Models;
using ShoppingList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Services
{
   public  interface IProductService
    {
        public List<Product> getGroceryProduct();
        public List<Product> getPetProduct();
        public List<Product> getHomeProducts();
        public List<Product> getClothesProduct();
        public bool isEmpty(List<Product> products);
    }
}
