using Microsoft.AspNetCore.Mvc;

namespace MyProjectEduHome.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
