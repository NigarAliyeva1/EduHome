using System;

namespace MyProjectEduHome.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string By { get; set; }
        public string Image { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
