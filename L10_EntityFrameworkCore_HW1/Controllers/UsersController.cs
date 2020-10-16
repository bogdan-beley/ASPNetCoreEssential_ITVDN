using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using L10_EntityFrameworkCore_HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace L10_EntityFrameworkCore_HW1.Controllers
{
    public class UsersController : Controller
    {
        
        public IActionResult Index()
        {
            using (DataContext db = new DataContext())
            {
                var users = db.Users;

                return View(users);
            } 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id, FName, LName, Age")] User user)
        {
            using (DataContext db = new DataContext())
            {
                if (ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                
                return View();
            }
        }

        public IActionResult GetUserById(int? id)
        {
            if (id == null)
                return NotFound();

            using (DataContext db = new DataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == id);
            }

            if (User == null)
                return NotFound();

            return View();
        }
    }
}
