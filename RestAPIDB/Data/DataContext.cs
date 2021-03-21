using Microsoft.EntityFrameworkCore;
using RestAPIDB.Models;
namespace RestAPIDB.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Fruit> FruitItems { get; set; }
        public DbSet<Tableware> TablewareItems { get; set; }
        public DbSet<Vegetable> VegetableItems { get; set; }

    }
}
