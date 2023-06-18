namespace Online_Learning_Platform.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ? Description { get; set; }
        public byte[] ? Image { get; set; }

        public string UserId { get; set; }
        public int SubCategoryId { get; set; }
        public int ? Count { get; set;}
       
        public DateTime DateTime { get; set; }
        public SubCategory? SubCategory { get; set; }
       
        public User? User { get; set; }

        public ICollection<Lesson>? Lessons { get; set; }
    }
}
