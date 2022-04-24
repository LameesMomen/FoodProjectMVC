using Microsoft.EntityFrameworkCore;
namespace FoodProject.Models
{
    public class Food:DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Pasta> Pastas { get; set; }
        public DbSet<Salad> Salads { get; set; }
        public DbSet<Soup> Soups { get; set; }
        public DbSet<Pastries> Pastries { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Food;Integrated Security=True");
        }
    }

}
