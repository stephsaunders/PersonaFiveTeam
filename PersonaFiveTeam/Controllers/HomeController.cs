using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonaFiveTeam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Confidants()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Skills()
        {
            ViewData["Message"] = "Your skills page.";

            return View();
        }
        public IActionResult Mementos()
        {
            return View();
        }
        public IActionResult Questions()
        {
            return View();
        }
        public IActionResult Jobs()
        {
            return View();
        }
        public IActionResult Maps()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
