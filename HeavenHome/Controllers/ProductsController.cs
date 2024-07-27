using HeavenHome.Data;
using HeavenHome.Data.Services;
using HeavenHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeavenHome.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducts = await _service.GetAllAsync(n => n.Company);
            return View(allProducts);
        }

        //Get: Products/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var productDetail = await _service.GetProductbyIdAsync(id);
            return View(productDetail);
        }
    }
}