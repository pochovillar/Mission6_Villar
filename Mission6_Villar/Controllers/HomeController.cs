using Microsoft.AspNetCore.Mvc;
using Mission6_Villar.Models;
using System.Diagnostics;

namespace Mission6_Villar.Controllers
{
    public class HomeController : Controller
    {          

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult about()
        {
            return View("about");
        }

        [HttpGet]
        public IActionResult form()
        {
            return View("form");
        }
        [HttpPost]
        public IActionResult form(Application response)
        {

        }
    }
}
