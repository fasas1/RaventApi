using Microsoft.EntityFrameworkCore;
using RaveEnterprise.Models;

namespace RaveEnterprise.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {   
        }
        public DbSet<Rave> Raves { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Rave>().HasData(
                 new Rave
                 {
                     Id =1,
                     Name = "Core Purple Boot",
                     Description = " It has a strong resemblance with Java, it has numerous strong programming features that make it endearing to a number of programmers worldwide. Following is the list of a few important features ",
                     Price = 17990,
                     PictureUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
                     Brand = "Net Core",
                     Type = "Boot",
                     QuantityInStock = 100
                 },
                   new Rave
                   {
                       Id = 2,
                       Name = "Core Purple Boot",
                       Description = "There are no prerequisites required to learn C#.NET as we are going to start from the very basics. It is good to have .NET Framework and Visual Studio installed on your computer, as it might assist you in executing the examples yourself and getting to know how it works.",
                       Price = 17990,
                       PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                       Brand = "Net Core",
                       Type = "Boot",
                       QuantityInStock = 100
                   },
                    new Rave
                    {
                        Id = 3,
                        Name = "Core Red Boot",
                        Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                        Price = 18999,
                        PictureUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
                        Brand = "Redis",
                        Type = "Boot",
                        QuantityInStock = 100
                    },
            new Rave
            {
                Id = 4,
                Name = "Core Purple Boot",
                Description = " It has a strong resemblance with Java, it has numerous strong programming features that make it endearing to a number of programmers worldwide. Following is the list of a few important features ",
                Price = 17990,
                PictureUrl = "https://www.pexels.com/photo/palm-trees-at-night-258154/",
                Brand = "Net Core",
                Type = "Boot",
                QuantityInStock = 100
            },
            new Rave
            {
                Id = 5,
                Name = "Angular Blue Boot",
                Description = "There are no prerequisites required to learn C#.NET as we are going to start from the very basics. It is good to have .NET Framework and Visual Studio installed on your computer, as it might assist you in executing the examples yourself and getting to know how it works.",
                Price = 430000,
                PictureUrl = "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/",
                Brand = "DELL G5",
                Type = "Angular",
                QuantityInStock = 100
            },
             new Rave
             {
                 Id = 6,
                 Name = "Core Purple Boot",
                 Description = "Running as admin worked for me after experiencing the same issue.",
                 Price = 17990,
                 PictureUrl = "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/",
                 Brand = "Net Core",
                 Type = "Boot",
                 QuantityInStock = 100
             },
            new Rave
            {
                Id = 7,
                Name = "Angular Blue Boot",
                Description = "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen",
                Price = 430000,
                PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                Brand = "DELL G5",
                Type = "Angular",
                QuantityInStock = 100
            },
             new Rave
             {
                 Id = 8,
                 Name = "Core Purple Boot",
                 Description = "Running as admin worked for me after experiencing the same issue.",
                 Price = 17990,
                 PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                 Brand = "Net Core",
                 Type = "Boot",
                 QuantityInStock = 100
             },
             new Rave
             {
                 Id = 9,
                 Name = "Core Purple Boot",
                 Description = "Running as admin worked for me after experiencing the same issue.",
                 Price = 17990,
                 PictureUrl = "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/",
                 Brand = "Net Core",
                 Type = "Boot",
                 QuantityInStock = 100
             },
              new Rave
              {
                  Id = 10,
                  Name = "Core Purple Boot",
                  Description = "There are no prerequisites required to learn C#.NET as we are going to start from the very basics. It is good to have .NET Framework and Visual Studio installed on your computer, as it might assist you in executing the examples yourself and getting to know how it works.",
                  Price = 17990,
                  PictureUrl = "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/",
                  Brand = "Net Core",
                  Type = "Boot",
                  QuantityInStock = 100
              }

          );
        }
    }
}
