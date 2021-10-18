using ItalianoRestaurant.Models;
using ItalianoRestaurant.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ItalianoRestaurant.Controllers
{
    public class MenuController : Controller
    {
        private MenuService Service;
        private List<Category> Categories;
        private List<Product> Products;


        public MenuController()
        {
            Service = new MenuService();
        }

 
        public IActionResult Index(int id)
        {
            Categories = Service.GetCategories();
            ViewData["categories"] = Categories;
            ViewData["isManager"] = id;
            return View();
        }

        [HttpGet]
        public ActionResult Manager()
         {
            Index(1);
            return View("Index");
            
         }

        [HttpGet]
        public  IActionResult GetProducts(int id, bool allergic)
        {
            if(allergic == true) { 
            Products = Service.GetProducts().Where(p => p.categoryId == id)
                                            .Where(p => p.hasAllergens == false).ToList();
            }
            else
            {
                Products = Service.GetProducts().Where(p => p.categoryId == id).ToList();
            }
            //return Json(new {products = Products});
            return View(Products);
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            Products = Service.CreateProduct(product);
            return Json(new {products = Products});
        }
        [HttpPut]
        public ActionResult UpdateProduct(Product product)
        {
            Products = Service.UpdateProduct(product);
            return Json(new { Products = Products });
        }
        [HttpDelete]
        public ActionResult DeleteProduct(int id)
        {
            Products = Service.DeleteProduct(id);
            return Json(new { products = Products });
        }

    }

}
