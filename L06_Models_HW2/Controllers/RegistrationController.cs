using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using L06_Models_HW2.Models;
using Microsoft.AspNetCore.Mvc;

namespace L06_Models_HW2.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Age >= 14)
                    return Content($"Welcome, {user.FName} {user.LName}!");
                else
                    throw new Exception("You must be at least 14 years old to access!");
            }

            return View(user);
        }
    }
}
