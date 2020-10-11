using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using L05_BasicsOfMVC_HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace L05_BasicsOfMVC_HW1.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Home()
        {
            Company company = new Company()
            {
                Name = "FastFood",
                Address = "Ukraine, Lviv, Naukova st.",
                Contacts = "Email: fastfood@mail.com; Phone: +38(098)123-12-12"
            };

            return View(company);
        }

        public IActionResult Production()
        {
            List<Production> production = new List<Production>()
            {
                new Production {Id = 1, Name = "Pita", Description = "Some description...", IsAvailable = true },
                new Production {Id = 2, Name = "HotDog", Description = "Some description...", IsAvailable = true },
                new Production {Id = 3, Name = "Burger", Description = "Some description...", IsAvailable = false },
                new Production {Id = 4, Name = "French Fries", Description = "Some description...", IsAvailable = true }
            };

            return View(production);
        }
    }
}
