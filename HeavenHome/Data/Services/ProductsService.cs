using HeavenHome.Data.Base;
using HeavenHome.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HeavenHome.Data.Services
{
    public class ProductsService:EntityBaseRepository<Product>, IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task<Product> GetProductbyIdAsync(int id)
        {
            var productDetails = await _context.Products
                .Include(c => c.Company)
                .Include(am => am.Materials_Products).ThenInclude(a => a.Material)
                .FirstOrDefaultAsync(n => n.Id == id);

            return productDetails;
        }
    }
}
