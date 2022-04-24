using FoodProject.Models;
using FoodProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FoodProject.Controllers
{
    public class MainDishesController : Controller
    {
        Food Context=new Food();
        MainDisheshViewModel MainDishes=new MainDisheshViewModel();
        public IActionResult Index()
        {
            List<Pizza> Pizzas = Context.Pizzas.ToList();
            List<Pasta> Pasta = Context.Pastas.ToList();
            List<Soup> Soups = Context.Soups.ToList();
            List<Salad> Salads = Context.Salads.ToList();
            MainDishes.Pizzas = Pizzas;
            MainDishes.Salads = Salads;
            MainDishes.Pastas = Pasta;
            MainDishes.Soups = Soups;
            return View(MainDishes);
        }
    }
}
