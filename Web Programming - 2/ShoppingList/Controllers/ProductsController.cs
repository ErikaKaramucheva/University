using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoppingList.Models;
using ShoppingList.Services;
using ShoppingList.ViewModels;

namespace ShoppingList.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShoppingListDbContext _context;
        private readonly IProductService _services;

        public ProductsController(ShoppingListDbContext context,IProductService services)
        {
            _context = context;
            _services = services;
        }

        public IActionResult GroceriesIndex()
        {
            var groceries = new ProductsVM();
            {
                groceries.products = _services.getGroceryProduct();
            }
            return View(groceries);
        }
        [HttpPost]
        public IActionResult GroceriesIndex(ProductsVM groceries)
        {
           
            return RedirectToAction(nameof(GroceriesIndex));
        }

        public IActionResult ClothesIndex()
        {
            var clothes = new ProductsVM();
            {
               clothes.products = _services.getClothesProduct();
            }
            return View(clothes);
        }
        [HttpPost]
        public IActionResult ClothesIndex(ProductsVM groceries)
        {

            return RedirectToAction(nameof(ClothesIndex));
        }
        public IActionResult PetIndex()
        {
            var petProducts = new ProductsVM();
            {
                petProducts.products = _services.getPetProduct();
            }
            return View(petProducts);
        }
        [HttpPost]
        public IActionResult PetIndex(ProductsVM petProducts)
        {

            return RedirectToAction(nameof(PetIndex));
        }
        public IActionResult HomeIndex()
        {
            var prod = new ProductsVM();
            {
               prod.products = _services.getHomeProducts();
            }
            return View(prod);
        }
        [HttpPost]
        public IActionResult HomeIndex(ProductsVM prod)
        {

            return RedirectToAction(nameof(HomeIndex));
        }
       
        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGroceryProduct(AddProductVM addProduct)
        {
            Product product = new Product();
            product.CategoryID = 1;
            product.Name = addProduct.Name;
            product.Quantity = addProduct.Quantity;
            product.Priority = addProduct.Priority;
            _context.Add(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GroceriesIndex));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct(AddProductVM addProduct, int id)
        {
            Product product = new Product();
            product.Name = addProduct.Name;
            product.Quantity = addProduct.Quantity;
            product.Priority = addProduct.Priority;
            product.CategoryID = id;
            _context.Add(product);
            await _context.SaveChangesAsync();
            if (id == 1)
            {
                return RedirectToAction(nameof(GroceriesIndex));
            }else if (id == 2)
            {
                return RedirectToAction(nameof(ClothesIndex));
            }
            else if (id == 3)
            {
                return RedirectToAction(nameof(HomeIndex));
            }
            return RedirectToAction(nameof(PetIndex));
        }
        

        public IActionResult Delete(int id)
        {
            var exists = ProductExists(id);
            if (exists)
            {
                Product product = FindProduct(id);
                _context.Products.Remove(product);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(GroceriesIndex));
            }
            else
            {
                return RedirectToAction(nameof(GroceriesIndex));
            }
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
        private Product FindProduct(int id)
        {
            return _context.Products.FirstOrDefault(e => e.Id == id);
        }

    }
}
