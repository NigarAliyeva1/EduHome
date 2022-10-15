using Microsoft.AspNetCore.Mvc;
using MyProjectEduHome.DAL;

namespace MyProjectEduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        
        private readonly AppDbContext _db;
        public DashboardController(AppDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
