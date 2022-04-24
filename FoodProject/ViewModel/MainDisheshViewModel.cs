using FoodProject.Models;
using System.Collections.Generic;

namespace FoodProject.ViewModel
{
    public class MainDisheshViewModel
    {
       public List<Pizza>Pizzas { get; set; }
        public List<Pasta> Pastas { get; set; }
        public List<Soup> Soups { get; set; }
        public List<Salad> Salads { get; set; }
    }
}
