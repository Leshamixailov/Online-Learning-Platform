namespace Online_Learning_Platform.Models
{
    public class CourseViewModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string UserId { get; set; }
        public int SubCategoryId { get; set; }
        public string? Keywords { get; set; }
        public string? Preview { get; set; }
        public DateTime DateTime { get; set; }
        public int ? Count { get; set; }
        public SubCategory? SubCategory { get; set; }
        public User? User { get; set; }
        public IFormFile Image { get; set; }
    }
}
