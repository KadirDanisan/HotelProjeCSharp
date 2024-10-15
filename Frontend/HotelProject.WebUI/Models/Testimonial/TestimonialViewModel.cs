using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Testimonial
{
    public class TestimonialViewModel
    {
        [Key]
        public int TestimoniaID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
