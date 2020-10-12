using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using L07_Views_HW2.Models;
using Microsoft.AspNetCore.Mvc;

namespace L07_Views_HW2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Game> games = new List<Game>()
            {
                new Game {Id = 1, Name = "Legacy of Kain: Soul Reaver", Price = 20},
                new Game {Id = 2, Name = "Carmageddon", Price = 15},
                new Game {Id = 3, Name = "Max Payne", Price = 18},
            };
            
            return View(games);
        }
    }
}
