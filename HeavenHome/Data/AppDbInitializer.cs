using HeavenHome.Data.Enums;
using HeavenHome.Models;
using Microsoft.AspNetCore.Builder;

namespace HeavenHome.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var ServicesScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = ServicesScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Companies
                if (!context.Companies.Any())
                {
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
                        }
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
                            Name = "Dining Table",
                            Description = "Family table for your meal",
                            Price = 59.90,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            CompanyId = 2,
                            ProductCategory = ProductCategory.Tables
                        }
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
                            PictureURL = "https://hips.hearstapps.com/hmg-prod/images/rustic-weathered-wood-logs-royalty-free-image-1654709658.jpg",
                            Name = "Wood",
                            Bio = "Wood's natural beauty and unique grain add warmth and enhance furniture's appeal."
                        },
                        new Material()
                        {
                            PictureURL = "https://poshele.com/cdn/shop/articles/Leather-Finishing_400x.jpg?v=1674420018",
                            Name = "Leather",
                            Bio = "Leather is strong and can withstand wear and tear, making it long-lasting."
                        }
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
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

    }

}
