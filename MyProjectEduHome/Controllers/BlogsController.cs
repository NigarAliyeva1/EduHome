using Microsoft.AspNetCore.Mvc;

namespace MyProjectEduHome.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
