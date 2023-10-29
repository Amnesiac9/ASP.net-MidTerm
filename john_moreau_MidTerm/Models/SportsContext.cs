using Microsoft.EntityFrameworkCore;
using System.Numerics;
//@*
//*John Moreau
//* CSS233
//* 10/28/2023
//*@
namespace john_moreau_MidTerm.Models
{
    public class SportsContext : DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options)
            : base(options)
        { }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Technician> Technicians { get; set; } = null!;


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
                ReleaseDate = new DateTime(2019, 05, 1),
                DateAdded = DateTime.Now.ToString("MM/dd/yyyy 'at' h:mm tt")
            },
            new Product
            {
                ProductId = 3,
                Code = "LEAGD10",
                Name = "League Scheduler Deluxe 1.0",
                Price = 7.99M,
                ReleaseDate = new DateTime(2019, 08, 1),
                DateAdded = DateTime.Now.ToString("MM/dd/yyyy 'at' h:mm tt")
            },
            new Product
            {
                ProductId = 4,
                Code = "PS5",
                Name = "Play Station 5",
                Price = 699.99M,
                ReleaseDate = new DateTime(2020, 11, 12),
                DateAdded = DateTime.Now.ToString("MM/dd/yyyy 'at' h:mm tt")
            });

            modelBuilder.Entity<Technician>().HasData(
                new Technician 
                {
                Id = -1,
                    Name = "Not Assigned",
                    Email = "",
                    Phone = ""
                },
                new Technician 
                {
                    Id = 1,
                    Name = "John Moreau",
                    Email = "email@email.com",
                    Phone = "509-559-5959"
                },
                new Technician
                {
                    Id = 2,
                    Name = "Robin Greene",
                    Email = "robin@wwcc.com",
                    Phone = "509-955-9595"
                },
                new Technician
                {
                    Id = 3,
                    Name = "Alison Diaz",
                    Email = "alison@email.com",
                    Phone = "509-555-0443"
                },
                new Technician
                {
                    Id = 4,
                    Name = "Andrew Wilson",
                    Email = "andrew@email.com",
                    Phone = "509-555-0449"
                },
                new Technician
                {
                    Id = 5,
                    Name = "Gina Fiori",
                    Email = "gina@email.com",
                    Phone = "509-555-0459"
                }


            );

        }

    }
}
