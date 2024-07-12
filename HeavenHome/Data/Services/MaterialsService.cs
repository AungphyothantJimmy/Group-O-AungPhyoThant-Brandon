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
        public async Task AddAsync(Material material)
        {
            await _context.Materials.AddAsync(material);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Materials.FirstOrDefaultAsync(n => n.Id == id);
            _context.Materials.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Material>> GetAllAsync()
        {
            var result = await _context.Materials.ToListAsync();
            return result;
        }

        public async Task<Material> GetByIdAsync(int id)
        {
            var result = await _context.Materials.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Material> UpdateAsync(int id, Material newMaterial)
        {
            _context.Update(newMaterial);
            await _context.SaveChangesAsync();
            return newMaterial;
        }
    }
}
