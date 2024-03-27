using FirstDemo.Majors;
using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;

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

        public IActionResult Index()
        {
            var major = _majorService.GetAllMajor();
            return View(major);
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
        public IActionResult Create(CreateMajorViewModel model)
        {
            _majorService.CreateMajor(model);
            return RedirectToAction("Index","Home");
        }
        public IActionResult Update(Guid majorId) 
        {
            var major = _majorService.GetMajorById(majorId);
            var select = new List<SelectionItem>
            {
                new SelectionItem((int)EntityStatus.Active,EntityStatus.Active.ToString()),
                new SelectionItem((int)EntityStatus.InActive,EntityStatus.InActive.ToString()),

            };
            ViewBag.Select= select;
            return View(major);

        }
        [HttpPost]
        public IActionResult Update(UpdateMajorViewModel model)
        {
            _majorService.UpdateMajor(model);
            return RedirectToAction("Index", "Home");
        }
        /// xóa
        public IActionResult Delete(Guid majorId)
        {
            var major = _majorService.GetMajorById(majorId);
            if (major == null)
            {
                return NotFound(); // Tr? v? NotFound n?u không t?m th?y major
            }
            return View(major);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Guid majorId)
        {
           
                _majorService.DeletelMajor(majorId);
                return RedirectToAction("Index", "Home");
          
        }

    }
}
