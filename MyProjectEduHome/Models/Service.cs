using System.ComponentModel.DataAnnotations;

namespace MyProjectEduHome.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public bool IsDeactive { get; set; }
    }
}
