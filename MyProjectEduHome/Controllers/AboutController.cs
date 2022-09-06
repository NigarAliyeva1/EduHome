using Microsoft.AspNetCore.Mvc;

namespace MyProjectEduHome.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
