using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Models
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Category>().HasData(
                   new Category
                   {
                       Id = 1,
                       Name = "Категория 1",
                       Controller = "",
                       Action = "",
                       Route = ""
                   },
                new Category
                {
                    Id = 2,
                    Name = "Категория 2",
                    Controller = "",
                    Action = "",
                    Route = ""
                },
                 new Category
                 {
                     Id = 3,
                     Name = "Категория 3",
                     Controller = "",
                     Action = "",
                     Route = ""
                 },
                  new Category
                  {
                      Id = 4,
                      Name = "Категория 4",
                      Controller = "",
                      Action = "",
                      Route = ""
                  }


            );
        }
        
    }
}
