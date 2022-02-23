using Microsoft.EntityFrameworkCore;
using Pizza_Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Shop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category
                {
                    Id = 1,
                    CategoryName = "American",
                    Url = "america"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Italian",
                    Url = "italia"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Ekzotik",
                    Url = "ekzo"
                }
                );

            modelBuilder.Entity<Pizza>().HasData(

                new Pizza
                {
                    Id = 1,
                    Title = "Neopolitano",
                    Description = "Neopolitano pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 9.99m,
                    CategoryId = 2
                },

                new Pizza
                {
                    Id = 2,
                    Title = "4Cheese",
                    Description = "4Cheese pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 8.99m,
                    CategoryId = 3
                },

                new Pizza
                {
                    Id = 3,
                    Title = "Chicago Pizza",
                    Description = "Chicago Pizza pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },

                new Pizza
                {
                    Id = 4,
                    Title = "Sicilia",
                    Description = "Sicilia pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 9.99m,
                    CategoryId = 2
                },

                new Pizza
                {
                    Id = 5,
                    Title = "Paperoni",
                    Description = "Paperoni pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 8.99m,
                    CategoryId = 2
                },

                new Pizza
                {
                    Id = 6,
                    Title = "Bavarian",
                    Description = "Поживна, з насиченим м’ясним смаком, Баварська піца стане гарною закускою до міцного німецького пива. У складі — смачнючі баварські ковбаски, вкриті скориночкою з пармезана та моцарелли. Смакота!",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },

                new Pizza
                {
                    Id = 7,
                    Title = "Mexicano",
                    Description = "Mexicano pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 9.99m,
                    CategoryId = 3
                },

                new Pizza
                {
                    Id = 8,
                    Title = "Mashrooms Pizza",
                    Description = "Mashrooms Pizza pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 11.99m,
                    CategoryId = 1
                },

                new Pizza
                {
                    Id = 9,
                    Title = "Hawaiian pizza",
                    Description = "Hawaiian pizza pizza description",
                    ImageUrl = "http://4.bp.blogspot.com/-cXJNdO0Fris/UvldtuI4nJI/AAAAAAAABQg/29wVM7OhR6U/s1600/03-Margherita-Pizza-Totale-Pizza-Napoletana.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                }
                );
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
