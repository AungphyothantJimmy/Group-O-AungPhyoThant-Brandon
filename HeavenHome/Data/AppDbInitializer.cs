namespace HeavenHome.Data;
using HeavenHome.Data.Enums;
using HeavenHome.Models;


public class AppDbInitializer
{
    public static void seed(IApplicationBuilder applicationBuilder)
    {
        using (var ServicesScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = ServicesScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();

            //Companies
            if (!context.Companies.Any()) {
                context.Companies.AddRange(new List<Company>()
                    {
                        new Company()
                        {
                            Name = "Company 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first company"
                        },
                        new Company()
                        {
                            Name = "Company 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first company"
                        },
                    });
                context.SaveChanges();
            }

            //Products
            if (!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Single Bed",
                            Description = "Bed for 1 person only",
                            Price = 109.90,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            CompanyId = 1,
                            ProductCategory = ProductCategory.Beds
                        },
                        new Product()
                        {
                            Name = "Dinning Table",
                            Description = "Family table for your meal",
                            Price = 59.90,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            CompanyId = 2,
                            ProductCategory = ProductCategory.Tables
                        },
                    });
                context.SaveChanges();
            }

            //Materials
            if (!context.Materials.Any())
            {
                context.Materials.AddRange(new List<Material>()
                    {
                        new Material()
                        {
                            Name = "Wood",
                        },
                        new Material()
                        {
                            Name = "Iron",
                        },
                });
                context.SaveChanges();
            }

            //Materials & Products
            if (!context.Materials_Products.Any())
            {
                context.Materials_Products.AddRange(new List<Material_Product>()
                    {
                        new Material_Product()
                        {
                            MaterialId = 1,
                            ProductId = 3
                        },
                        new Material_Product()
                        {
                            MaterialId = 2,
                            ProductId = 4
                        },
                    });
                context.SaveChanges();
            }
        }
    }

}
