using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVAMVC.Models;

namespace MVAMVC.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Foo()
        {
            return View();
        }
        
        // POST /HOME/ABOUT WITH 
        [HttpPost]
        public IActionResult About(Person personIn)
        {
            // DO SOME STUFF

           return View(personIn);
        }

        // GET /HOME/ABOUT
        public IActionResult About()
        {
            ViewData["Message"] = "Here is a person";
            var p = new Person() {
                FristName = "FF",
                LastName = "LL",
                Birthdate = new DateTime(2000, 01, 01)
            };

            return View(p);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
