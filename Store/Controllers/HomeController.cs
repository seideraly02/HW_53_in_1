﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Models;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _environment;
        public HomeController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult DownloadFile()
        {
            string filePath = Path.Combine(_environment.ContentRootPath, "Files/text.pdf");
            string fileType = "application/pdf";
            string fileName = "book.pdf";
            return PhysicalFile(filePath, fileType, fileName);
        }
        
       
        public IActionResult Index()
        {
            
            return View();
        }

      // [NonAction]
        public IActionResult Privacy()
        {
            ViewData["example"] = "Hello world";
            return View();
        }
        /* 
       // [HttpGet]
        public Order SomeAction()
        {
            return new Order();
        }

        public int Calculate(int first, int second )
        {
            return first + second;   
        }
        [ActionName("CalculateArr")] 
        public int Calculate(int[] array )
        {
            return array.Sum();   
        }

        public string Phone(Phone[] phones)
        {
            string result = "";
            foreach (var phone in phones)
            {
                result += phone.ToString() + "\n";
            }

            return result;
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}