using HeavenHome.Models;
using Microsoft.EntityFrameworkCore;
namespace HeavenHome.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material_Product>().HasKey(am => new
            {
                am.MaterialId,
                am.ProductId,
            });

            modelBuilder.Entity<Material_Product>().HasOne(m => m.Product).WithMany(am => am.Materials_Products).HasForeignKey(m  => m.MaterialId);
            modelBuilder.Entity<Material_Product>().HasOne(m => m.Product).WithMany(am => am.Materials_Products).HasForeignKey(m  => m.ProductId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Material_Product> Materials_Products { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
