using FirstDemo.Students;
using Microsoft.AspNetCore.Mvc;

namespace FirstDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<IActionResult> Index(int? pageIndex = null)
        {
            var query = new SearchQuery();
            query.PageIndex = pageIndex.HasValue ? pageIndex.Value : 1;
            query.PageSize = 10;

            var result = await _studentService.GetStudents(query);
            return View(result);
        }
    }
}


