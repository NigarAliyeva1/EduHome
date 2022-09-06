using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProjectEduHome.DAL;
using MyProjectEduHome.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjectEduHome.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderViewComponent(AppDbContext db)
        {
            _db=db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio =await _db.Bios.FirstOrDefaultAsync();
            return View(bio);
        }
    }
}
