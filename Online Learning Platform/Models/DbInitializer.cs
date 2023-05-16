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
            modelBuilder.Entity<SubCategory>().HasData(
                  new SubCategory
                  {
                      Id = 1,
                      Name = "Подкатегория 1",
                      CategoryId = 1

                  },
               new SubCategory
               {
                   Id = 2,
                   Name = "Подкатегория 2",
                   CategoryId = 2

               },
                new SubCategory
                {
                    Id = 3,
                    Name = "Подкатегория 3",
                    CategoryId = 3
                },
                 new SubCategory
                 {
                     Id = 4,
                     Name = "Подкатегория 4",
                     CategoryId = 4
                 }



           );
            // modelBuilder.Entity<Category_SubCategory>().HasData(
            //       new Category_SubCategory
            //       {
            //           Id = 1,
            //           CategoryID = 1,
            //           SubCategoryID = 1

            //       },
            //    new Category_SubCategory
            //    {
            //        Id = 2,
            //        CategoryID = 2,
            //        SubCategoryID = 2

            //    },
            //     new Category_SubCategory
            //     {
            //         Id = 3,
            //         CategoryID = 3,
            //         SubCategoryID = 3

            //     },
            //      new Category_SubCategory
            //      {
            //          Id = 4,
            //          CategoryID = 4,
            //          SubCategoryID = 4

            //      }



            //); 

        }

    }
}
