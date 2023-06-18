namespace Online_Learning_Platform.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ? Description { get; set; }
        public int CourseId { get; set; }
        public string Path { get; set; }
        public Course ? Course { get; set; }
    }
}