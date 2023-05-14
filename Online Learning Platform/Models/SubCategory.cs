namespace Online_Learning_Platform.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
