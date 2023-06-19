using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ? NameCPU { get; set; }
        public string ? Controller { get; set; }
        public string ? Action { get; set; }
        public string ? Route { get; set; }

        public ICollection<SubCategory> ? SubCategory { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
