using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_Villar.Models;
using System.Diagnostics;

namespace Mission6_Villar.Controllers
{
    public class HomeController : Controller
    {
        private MovieDatabaseContext _context;
        public HomeController(MovieDatabaseContext temp)
        {
            _context = temp;
        }
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("form", new Movie());
        }


        [HttpPost]
        public IActionResult form(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add a record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

                return View(response);
            }
        }
        public IActionResult display()
        {
            // First Linq query
            var movies = _context.Movies
                .Include("Category")
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int MovieId) 
        {

            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == MovieId);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("form", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("display");
        }
    }
}
