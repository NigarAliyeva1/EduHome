using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProjectEduHome.DAL;
using MyProjectEduHome.Models;
using MyProjectEduHome.ViewModels;
using System.Threading.Tasks;

namespace MyProjectEduHome.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterVM footerVM = new FooterVM
            {
                SocialMedias = await _db.SocialMedias.ToListAsync(),
                Bio = await _db.Bios.FirstOrDefaultAsync()
            };
            return View(footerVM);
        } 
    }
}
