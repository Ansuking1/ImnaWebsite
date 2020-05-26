using System;
using ImnaWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImnaWebsite.Controllers {
    public class HomeController : Controller {
        // GET
        public IActionResult Index() {
            Movie movie = new Movie();
            movie.Title = "Breaking Bad";
            movie.ReleaseDate = DateTime.Today;

            return View(movie);
        }
    }
}