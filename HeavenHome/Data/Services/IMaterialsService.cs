using HeavenHome.Models;

namespace HeavenHome.Data.Services
{
    public interface IMaterialsService
    {
        Task<IEnumerable<Material>> GetAllAsync();
        Task<Material> GetByIdAsync(int id);
        Task AddAsync(Material material);
        Task<Material> UpdateAsync(int id, Material newMaterial);
        Task DeleteAsync(int id);
    }
}
