using FirstDemo.Majors;
using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
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
    }
}
