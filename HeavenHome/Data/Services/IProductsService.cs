using HeavenHome.Models;
using HeavenHome.Data.Base;
using HeavenHome.Models;
using System.Linq.Expressions;

namespace HeavenHome.Data.Services
{
    public interface IProductsService:IEntityBaseRepository<Product>
    {
        Task<Product> GetProductbyIdAsync(int id);
    }
}
