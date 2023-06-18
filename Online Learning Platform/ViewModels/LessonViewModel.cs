using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.ViewModels
{
    public class LessonViewModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CourseId { get; set; }
        public string Type { get; set; }
        public Course? Course { get; set; }
        public IFormFile Video { get; set; }
    }
}
