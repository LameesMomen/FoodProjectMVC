using FoodProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FoodProject.Controllers
{
    public class SoupController : Controller
    {
        Food Context = new Food();
        public IActionResult Index()
        {
            List<Soup> soup = Context.Soups.ToList();
            return View(soup);
        }
        public IActionResult Details(int id)
        {
            Soup soup = Context.Soups.FirstOrDefault(p => p.Id == id);
            return View(soup);

        }
    }
}
