using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task1.Entities;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>()
            {
                new Drink { Id = 1, Name = "Limonad", IsCarbonated = true, Price = 2, Size = "500 ml",IsSugar = true },
                new Drink { Id = 2, Name = "Cay", IsCarbonated = false, Price = 1, Size = "250 ml",  IsSugar = false},
                new Drink { Id = 3, Name = "Cofee", IsCarbonated = false, Price = 3, Size = "300 ml", IsSugar = true },
                new Drink { Id = 4, Name = "Nar Siresi", IsCarbonated = false, Price = 4,  Size = "250 ml", IsSugar = true },
                new Drink { Id = 5, Name = "Buzlu Cay", IsCarbonated = false, Price = 2,Size = "400 ml", IsSugar = true  },
                new Drink { Id = 6, Name = "Sokoladlı Sud", IsCarbonated = false, Price = 3, Size = "300 ml" , IsSugar = true},
                new Drink { Id = 7, Name = "Soda", IsCarbonated = true, Price = 1, Size = "500 ml",IsSugar = false  },
                new Drink { Id = 8, Name = "Smoothie", IsCarbonated = false, Price = 5,Size = "350 ml",IsSugar = true  },
                new Drink { Id = 9, Name = "Mojito", IsCarbonated = true, Price = 3,Size = "400 ml",IsSugar = true },
                new Drink { Id = 10, Name = "Mineral Su", IsCarbonated = true, Price = 1, Size = "500 ml",IsSugar = false  }
            };
            return View(drinks);

        }
        public IActionResult FastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood { Id = 1, Name = "Burger", IsSpicy = false, IsVegetarian = false, Price = 5 },
                new FastFood { Id = 2, Name = "Pizza", IsSpicy = true, IsVegetarian = false, Price = 7 },
                new FastFood { Id = 3, Name = "Fries", IsSpicy = false, IsVegetarian = true, Price = 3 },
                new FastFood { Id = 4, Name = "Hot Dog", IsSpicy = false, IsVegetarian = false, Price = 4 },
                new FastFood { Id = 5, Name = "Kabab", IsSpicy = true, IsVegetarian = false, Price = 8 },
                new FastFood { Id = 6, Name = "Toyuq Nugget", IsSpicy = false, IsVegetarian = false, Price = 6 },
                new FastFood { Id = 7, Name = "Taco", IsSpicy = true, IsVegetarian = false, Price = 5 },
                new FastFood { Id = 8, Name = "Quesadilla", IsSpicy = false, IsVegetarian = true, Price = 7 }
            };
            return View(fastFoods);
        }
        public  IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal { Id = 1, Name = "Plov", MealSize = "Big", IsVegetarian = true, Price = 7, IsSpicy = false },
                new HotMeal { Id = 2, Name = "Kabab", MealSize = "Big", IsVegetarian = false, Price = 10, IsSpicy = true },
                new HotMeal { Id = 3, Name = "Lazanya", MealSize = "Small", IsVegetarian = false, Price = 8, IsSpicy = false },
                new HotMeal { Id = 4, Name = "Lahmacun", MealSize = "Big", IsVegetarian = false, Price = 7, IsSpicy = true },
                new HotMeal { Id = 5, Name = "Dovga", MealSize = "Middle", IsVegetarian = true, Price = 9, IsSpicy = false },
                new HotMeal { Id = 6, Name = "Dolma", MealSize = "Small", IsVegetarian = false, Price = 6, IsSpicy = false },
                new HotMeal { Id = 7, Name = "Börek", MealSize = "Big", IsVegetarian = true, Price = 5, IsSpicy = false }
            };
            return View(hotMeals);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
