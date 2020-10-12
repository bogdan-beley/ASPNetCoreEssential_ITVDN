using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace L07_Views_HW1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult IndexOne()
        {
            return View();
        }

        public IActionResult IndexTwo()
        {
            return View();
        }

        public IActionResult IndexThree()
        {
            return View();
        }
    }
}
