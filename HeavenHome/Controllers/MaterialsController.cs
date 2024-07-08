using HeavenHome.Data;
using HeavenHome.Data.Services;
using Microsoft.AspNetCore.Mvc;
using HeavenHome.Models;

namespace HeavenHome.Controllers
{
    public class MaterialsController : Controller
    {
        private readonly IMaterialsService _service;

        public MaterialsController(IMaterialsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data); 
        }

        //Get: Materials/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("PictureURL,Name,Bio")]Material material)
        {
            if(!ModelState.IsValid)
            {
                return View(material);
            }
            _service.Add(material);
            return RedirectToAction(nameof(Index));
        }
    }
}
