using Microsoft.AspNetCore.Mvc;

namespace MyProjectEduHome.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
