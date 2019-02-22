using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using view_models.Models;

namespace view_models.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            User bobRoss = new User("Bob", "Ross"); // current user
            BookLibrary allBooks = new BookLibrary(); // collection of books

            Dashboard dashboard = new Dashboard(bobRoss, allBooks);
            /* 
                we create a "wrapper" class that provides properties for classes
                that we wish to pass into our View.
            */
            return View(dashboard);
        }

    }
}
