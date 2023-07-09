using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class UsersController : Controller
    {
        private StoreContext _db;

        public UsersController(StoreContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View(_db.Users.ToString());
        }

        public IActionResult Create()//http://Localhost:5000/Users/Create
        {
            Dictionary<int, string> sex = new Dictionary<int, string>();
            sex.Add(0,"Мужской");
            sex.Add(1,"Женский");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Order user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}