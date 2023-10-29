﻿using Microsoft.EntityFrameworkCore;

namespace john_moreau_MidTerm.Models
{
    public class SportsContext : DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options)
            : base(options)
        { }
        public DbSet<Product> Contacts { get; set; } = null!;
        //public DbSet<Category> Categories { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Code = "TRNY",
                Name = "Tournament Master 1.0",
                Price = 4.99M,
                ReleaseDate = new DateTime(2018, 12, 1),
                DateAdded = DateTime.Now.ToString("MM/dd/yyyy 'at' h:mm tt")
            },
            new Product
            {
                ProductId = 2,
                Code = "LEAG10",
                Name = "League Scheduler 1.0",
                Price = 4.99M,
                ReleaseDate = new DateTime(2018, 12, 1),
                DateAdded = DateTime.Now.ToString("MM/dd/yyyy 'at' h:mm tt")
            },
            new Product
            {
                ProductId = 3,
                Code = "LEAGD10",
                Name = "League Scheduler Deluxe 1.0",
                Price = 4.99M,
                ReleaseDate = new DateTime(2018, 12, 1),
                DateAdded = DateTime.Now.ToString("MM/dd/yyyy 'at' h:mm tt")
            });


            //modelBuilder.Entity<Category>().HasData(
            //    new Category
            //    {
            //        CategoryId = 1,
            //        CategoryName = "Family"
            //    },
            //    new Category
            //    {
            //        CategoryId = 2,
            //        CategoryName = "Friend"
            //    },
            //    new Category
            //    {
            //        CategoryId = 3,
            //        CategoryName = "Work"
            //    });
        }

    }
}
