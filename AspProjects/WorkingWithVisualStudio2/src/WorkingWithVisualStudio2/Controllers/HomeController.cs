﻿using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio2.Models;
using System.Linq;

namespace WorkingWithVisualStudio2.Controllers
{
    public class HomeController: Controller
    {
        SimpleRepository Repository = SimpleRepository.SharedRepository;


        public IActionResult Index()
            => View(Repository.Products
                .Where(p => p?.Price < 50));

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            
                Repository.AddProduct(p);
                return RedirectToAction("Index");
        
        }
    }
}
