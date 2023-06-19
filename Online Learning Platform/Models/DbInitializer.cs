using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NickBuhro.Translit;
using Online_Learning_Platform.Data;
using System.Data;
using System.Security.Cryptography.X509Certificates;

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
                       NameCPU = Transliteration.CyrillicToLatin("Категория 1", Language.Russian).Replace(" ", "_"),
                       Controller = "",
                       Action = "",
                       Route = ""

                   },
                new Category
                {
                    Id = 2,
                    Name = "Категория 2",
                    NameCPU = Transliteration.CyrillicToLatin("Категория 2", Language.Russian).Replace(" ", "_"),
                    Controller = "",
                    Action = "",
                    Route = ""

                },
                 new Category
                 {
                     Id = 3,
                     Name = "Категория 3",
                     NameCPU = Transliteration.CyrillicToLatin("Категория 3", Language.Russian).Replace(" ", "_"),
                     Controller = "",
                     Action = "",
                     Route = ""

                 },
                  new Category
                  {
                      Id = 4,
                      Name = "Категория 4",
                      NameCPU = Transliteration.CyrillicToLatin("Категория 4", Language.Russian).Replace(" ", "_"),
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
            User admin = new User
            {
                Id = "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                Email = "Admin",
                NormalizedEmail = "ADMIN",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",

                EmailConfirmed = false,

                //SecurityStamp = "AO2TEIOS5CRVGEJCTIADNQSHLMFZWP3U",
                Year = 1010,
                NickName = "Admin",
                LockoutEnabled = true
            };
            User Teacher = new User
            {
                Id = "06674cf0–5812–4cfe - afbf - 59f706d72cf6",
                Email = "Teacher",
                NormalizedEmail = "TEACHER",
                UserName = "Teacher",
                NormalizedUserName = "TEACHER",

                EmailConfirmed = false,

               
                Year = 1010,
                NickName = "Teacher",
                LockoutEnabled = true
            };
            var hasher = new PasswordHasher<User>();
          
            admin.PasswordHash = hasher.HashPassword(admin, "Temporarypass1!");
            Teacher.PasswordHash = hasher.HashPassword(Teacher, "Temporarypass2!");


            modelBuilder.Entity<User>().HasData(
            admin,
            Teacher
            );
            
            modelBuilder.Entity<IdentityRole>().HasData(new List<IdentityRole>
            {
                new IdentityRole {
                Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                Name = "Admin",
                NormalizedName = "ADMIN"
                },
                new IdentityRole {
                Id ="fab4fac1-c546-41de-aebc-a14da6895711",
                Name = "Teacher",
                NormalizedName = "TEACHER"
                }
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330",
                    UserId = "02174cf0–9412–4cfe - afbf - 59f706d72cf6"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
                    UserId = "06674cf0–5812–4cfe - afbf - 59f706d72cf6"
                }
            ) ;
        }


    }
}
