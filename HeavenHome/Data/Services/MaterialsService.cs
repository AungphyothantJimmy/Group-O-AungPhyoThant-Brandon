using HeavenHome.Models;
using Microsoft.EntityFrameworkCore;

namespace HeavenHome.Data.Services
{
    public class MaterialsService : IMaterialsService
    {
        private readonly AppDbContext _context;

        public MaterialsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Material material)
        {
            _context.Materials.Add(material);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Material>> GetAll()
        {
            var result = await _context.Materials.ToListAsync();
            return result;
        }

        public Material GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Material Update(int id, Material newMaterial)
        {
            throw new NotImplementedException();
        }
    }
}
