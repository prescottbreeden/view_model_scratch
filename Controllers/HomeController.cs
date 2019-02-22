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
        private static User bobRoss = new User("Bob", "Ross"); // current user
        private static BookLibrary allBooks = new BookLibrary(); // collection of books

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {

            Dashboard dashboard = new Dashboard(bobRoss, allBooks);
            /* 
                we create a "wrapper" class that provides properties for classes
                that we wish to pass into our View.
            */
            return View(dashboard);
        }

    }
}
