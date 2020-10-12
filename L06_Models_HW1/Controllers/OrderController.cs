using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using L06_Models_HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace L06_Models_HW1.Controllers
{
    public class OrderController : Controller
    {
        List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Cheese Pizza", Descripion = "It should be no shocker that a classic is the statistical favorite. Cheese pizza is one of the most popular choices. It will always be a simple, unadorned masterpiece on its own.", Price = 3 },
                new Product { Id = 2, Name = "Veggie Pizza", Descripion = "When you want to jazz up your cheese pizza with color and texture, veggies are the perfect topping. And you’re only limited by your imagination. Everything from peppers and mushrooms, to eggplant and onions make for an exciting and tasty veggie pizza.", Price = 3 },
                new Product { Id = 3, Name = "Pepperoni Pizza", Descripion = "There’s a reason this is one of the most popular types of pizza. Who doesn’t love biting into a crispy, salty round of pepperoni?", Price = 4 },
                new Product { Id = 4, Name = "Meat Pizza", Descripion = "If pepperoni just isn’t enough, and you’re looking for a pie with a bit more heft, a meat pizza is a perfect and popular choice. Pile on ground beef and sausage for a hearty meal.", Price = 5 },
                new Product { Id = 5, Name = "BBQ Chicken Pizza", Descripion = "If you love BBQ chicken and you love pizza, why not put them together? This has long been a cult favorite of sports fans and college kids. The chicken slathered over the top of a pie gives it a tangy, sweet flavor that can’t be beaten.", Price = 6 },
                new Product { Id = 6, Name = "Hawaiian Pizza", Descripion = "Pineapple might not be the first thing that comes to mind when you think pizza. But add in some ham and it creates an unexpectedly solid sweet and salty combination for this type of pizza.", Price = 3 },
                new Product { Id = 7, Name = "Supreme Pizza", Descripion = "When you can’t decide which toppings to get, it’s time for the supreme pizza. The “supreme” refers to the litany of toppings that come scattered on these pies, from sausage to vegetables to pepperoni. And it’s the combination of the flavors that really makes it sing.", Price = 4 },
                new Product { Id = 8, Name = "Margherita Pizza", Descripion = "Deceptively simple, the Margherita pizza is made with basil, fresh mozzarella, and tomatoes. There’s a reason it’s an Italian staple and one of the most popular types of pizza in the country.", Price = 3 }
            };

        public IActionResult Index()
        {
            return View(products);
        }

        [HttpPost]
        public IActionResult Index(int quantity)
        {
            TempData["quantity"] = quantity;

            return RedirectToAction("CreateOrder", "Order");
        }

        public IActionResult CreateOrder()
        {
            ViewBag.quantity = TempData["quantity"];
            ViewData["products"] = products;

            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Product[] products)
        {
            var currentTime = DateTime.Now; 

            string result = "Thank You for Your order!\n";
            foreach (var product in products)
            {
                if (!string.IsNullOrEmpty(product.Name))
                result += "* " + product.Name + "\n";
            }

            result += "Your order will be ready till " + currentTime.AddHours(1).ToShortTimeString();

            return Content(result);
        }

    }
}
