using HeavenHome.Models;

namespace HeavenHome.Data.Services
{
    public interface IMaterialsService
    {
        Task<IEnumerable<Material>> GetAll();
        Material GetById(int id);
        void Add(Material material);
        Material Update(int id, Material newMaterial);
        void Delete(int id);
    }
}
