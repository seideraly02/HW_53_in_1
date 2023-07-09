using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class DescriptionController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}