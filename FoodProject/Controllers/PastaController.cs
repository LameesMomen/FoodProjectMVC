using FoodProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FoodProject.Controllers
{
    public class PastaController : Controller
    {
        Food Context = new Food();
        public IActionResult Index()
        {
            List<Pasta> pasta = Context.Pastas.ToList();
            return View(pasta);
        }
        public IActionResult Details(int id)
        {
            Pasta pasta = Context.Pastas.FirstOrDefault(p => p.Id == id);
            return View(pasta);

        }
    }
}
