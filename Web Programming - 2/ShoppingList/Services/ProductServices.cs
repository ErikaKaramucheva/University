using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingList.Models;
using ShoppingList.ViewModels;

namespace ShoppingList.Services
{
    
    public class ProductServices:IProductService
    {
        private readonly ShoppingListDbContext _context;

        public ProductServices(ShoppingListDbContext shoppingListDb) => _context = shoppingListDb;
        public List<Product> getGroceryProduct()
        =>_context
                 .Products
                 .Where(p => p.CategoryID == 1)
                 .Select(p => new Product()
                 {
                     Id=p.Id,
                     Name = p.Name,
                     Priority = p.Priority,
                     Quantity = p.Quantity
                 }). ToList();

        public List<Product> getPetProduct()
        => _context
                 .Products
                 .Where(p => p.CategoryID == 4)
                 .Select(p => new Product()
                 {
                     Id = p.Id,
                     Name = p.Name,
                     Priority = p.Priority,
                     Quantity = p.Quantity
                 }).ToList();

        public List<Product> getHomeProducts()
       => _context
                .Products
                .Where(p => p.CategoryID == 3)
                .Select(p => new Product()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Priority = p.Priority,
                    Quantity = p.Quantity
                }).ToList();

        public List<Product> getClothesProduct()
       => _context
                .Products
                .Where(p => p.CategoryID == 2)
                .Select(p => new Product()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Priority = p.Priority,
                    Quantity = p.Quantity
                }).ToList();
        public bool isEmpty(List<Product> products)
        {
            if (products.Count == 0)
            {
                return true;
            }
            return false;
        }
        
        }
    }
