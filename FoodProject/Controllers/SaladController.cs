using FoodProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FoodProject.Controllers
{
    public class SaladController : Controller
    {
        Food Context = new Food();
        public IActionResult Index()
        {
            List<Salad> salad = Context.Salads.ToList();
            return View(salad);
        }
        public IActionResult Details(int id)
        {
            Salad salad = Context.Salads.FirstOrDefault(p => p.Id == id);
            return View(salad);

        }
    }
}
