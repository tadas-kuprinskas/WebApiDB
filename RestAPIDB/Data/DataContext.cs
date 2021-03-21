using Microsoft.EntityFrameworkCore;
using RestAPIDB.Models;
using System.Linq;

namespace RestAPIDB.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Fruit> FruitItems { get; set; }
        public DbSet<Tableware> TablewareItems { get; set; }
        public DbSet<Vegetable> VegetableItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            if (!TablewareItems.Any())
            {
                TablewareItems.Add(new Tableware()
                {
                    Name = "Spoon"
                });
                TablewareItems.Add(new Tableware()
                {
                    Name = "Fork"
                });
                TablewareItems.Add(new Tableware()
                {
                    Name = "Cup"
                });
                SaveChanges();
            }

            if (!FruitItems.Any())
            {
                FruitItems.Add(new Fruit()
                {
                    Name = "Banana"
                });
                FruitItems.Add(new Fruit()
                {
                    Name = "Orange"
                });
                FruitItems.Add(new Fruit()
                {
                    Name = "Apple"
                });
                SaveChanges();
            }

            if (!VegetableItems.Any())
            {
                VegetableItems.Add(new Vegetable()
                {
                    Name = "Onion"
                });
                VegetableItems.Add(new Vegetable()
                {
                    Name = "Tomato"
                });
                VegetableItems.Add(new Vegetable()
                {
                    Name = "Carrot"
                });
                SaveChanges();
            }
        }
    }
}
