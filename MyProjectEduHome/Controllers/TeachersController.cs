using Microsoft.AspNetCore.Mvc;

namespace MyProjectEduHome.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
