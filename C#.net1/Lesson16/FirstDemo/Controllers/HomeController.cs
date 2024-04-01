using FirstDemo.Majors;
using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.WebSockets;

namespace FirstDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMajorService _majorService;

        public HomeController(ILogger<HomeController> logger, IMajorService majorService)
        {
            _logger = logger;
            _majorService = majorService;

        }

        public async Task<IActionResult> Index()
        {
            var majors = await _majorService.GetAllMajor();
            return View(majors);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMajorViewModel model)
        {
            await _majorService.CreateMajor(model);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Update(Guid majorId)
        {
            var major = await _majorService.GetMajorById(majorId);
            var select = new List<SelectionItem> {
                new SelectionItem( (int) EntityStatus.Active, EntityStatus.Active.ToString()),
                new SelectionItem( (int) EntityStatus.InActive, EntityStatus.InActive.ToString()),
            };
            ViewBag.Select = select;
            return View(major);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateMajorViewModel model)
        {
            await _majorService.UpdateMajor(model);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid majorId)
        {
            await _majorService.DeleteMajor(majorId);
            return RedirectToAction("Index", "Home");
        }
    }
}

