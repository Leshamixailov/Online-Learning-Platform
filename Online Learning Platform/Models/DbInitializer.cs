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


            ) ;
            modelBuilder.Entity<SubCategory>().HasData(
                  new SubCategory
                  {
                      Id = 1,
                      Name = "Податегория 1",
                      CategoryID=1,
                     
                  },
               new SubCategory
               {
                   Id = 2,
                   Name = "Податегория 2",
                   CategoryID = 2,
               },
                new SubCategory
                {
                    Id = 3,
                    Name = "Податегория 3",
                    CategoryID = 3,
                },
                 new SubCategory
                 {
                     Id = 4,
                     Name = "Податегория 4",
                     CategoryID = 4,
                 }


           );
        }
        
    }
}
