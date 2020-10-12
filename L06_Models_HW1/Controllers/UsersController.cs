using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using L06_Models_HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace L06_Models_HW1.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (user.Age >= 16)
                return RedirectToAction("Index", "Order");
            else
                return Content("Access denied. You must be at least 16 years old.");
        }
    }
}
