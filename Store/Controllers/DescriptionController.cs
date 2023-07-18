using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class DescriptionController : Controller
    {
        private StoreContext _db;

        public DescriptionController(StoreContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            List<Description> descriptions = _db.Descriptions.ToList();
            return View(descriptions);
        }
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Description description)
        {
            if (description != null)
            {
                _db.Descriptions.Add(description);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}