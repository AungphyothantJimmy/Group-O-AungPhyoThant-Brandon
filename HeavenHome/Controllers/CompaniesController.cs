using HeavenHome.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace HeavenHome.Controllers
{
    public class CompaniesController : Controller
    {
        public readonly AppDbContext _context;

        public CompaniesController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allcompanies = await _context.Companies.ToListAsync();
            return View(allcompanies);
        }
    }
}