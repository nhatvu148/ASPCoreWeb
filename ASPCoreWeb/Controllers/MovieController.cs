using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWeb.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!", Id = 123456 };
            //return View(movie);
            //return Content("Hello World!");
            //return NotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
    }
}
