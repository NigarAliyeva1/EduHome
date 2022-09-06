using Microsoft.EntityFrameworkCore;
using MyProjectEduHome.Models;
using System.Collections.Generic;

namespace MyProjectEduHome.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public About About { get; set; }
        public Feedback Feedback { get; set; }
        public List<Service> Services { get; set; }
        public List<Course> Courses { get; set; }
        public List<Notice> Notices { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Event> Events { get; set; }



    }
}
