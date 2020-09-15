using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_13._2_Coffee_Shop_Product_List.Models;

namespace Lab_13._2_Coffee_Shop_Product_List.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<Product> list = Product.List();
            return View(list);
        }

        public IActionResult Admin()
        {
            List<Product> ProductList = Product.List();
            return View(ProductList);
        }

        [HttpGet]
        public IActionResult NewProduct()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult NewProduct(string Name, string Description, Decimal Price, string Category)
        {
            Product prod = Product.Create(Name, Description, Price, Category);
            return View("~/Views/Product/Category.cshtml", prod);
        }

        public IActionResult EditProduct(long _id)
        {
            Product prod = Product.Read(_id);
            return View(prod);
        }

        public IActionResult SaveProduct(long _id, string Name, string Description, Decimal Price, string Category)
        {
            Product prod = Product.Read(_id);
            prod.Name = Name;
            prod.Description = Description;
            prod.Price = Price;
            prod.Category = Category;
            prod.Edit();
            return View("~/Views/Product/Category.cshtml", prod);
        }

        public IActionResult DeleteProduct(long _id)
        {
            Product.Delete(_id);
            List<Product> list = Product.List();
            return View("Admin",list);
        }

    }
}
