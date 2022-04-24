using FoodProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FoodProject.Controllers
{
    public class PizzaController : Controller
    {
        Food Context=new Food();
        public IActionResult Index()
        {
            List<Pizza> Pizzas=Context.Pizzas.ToList();
            return View(Pizzas);
        }
        public IActionResult Details(int id)
        {
            Pizza Pizza=Context.Pizzas.FirstOrDefault(p=>p.Id==id);
            return View(Pizza);

        }

    }
}
