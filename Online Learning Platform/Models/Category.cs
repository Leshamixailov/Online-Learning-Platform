namespace Online_Learning_Platform.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ? Controller { get; set; }
        public string ? Action { get; set; }
        public string ? Route { get; set; }

        public ICollection<SubCategory> ? SubCategory { get; set; }
    }
}
