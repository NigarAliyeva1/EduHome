using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProjectEduHome.DAL;
using MyProjectEduHome.Models;
using MyProjectEduHome.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjectEduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {


            HomeVM homeVM = new HomeVM
            {
                Sliders= _db.Sliders.Where(x=>!x.IsDeactive).ToList(),
                About= _db.Abouts.FirstOrDefault(),
                Services = _db.Services.Where(x => !x.IsDeactive).ToList(),
                Courses= _db.Courses.Take(3).ToList(),
                Notices = _db.Notices.ToList(),
                Feedback = _db.Feedbacks.FirstOrDefault(),
                Blogs= _db.Blogs.OrderByDescending(x => x.Id).Take(3).ToList(),
                Events= _db.Events.OrderByDescending(x => x.Id).Take(4).ToList()
            };   
            return View(homeVM);
        }

        
    }
}
