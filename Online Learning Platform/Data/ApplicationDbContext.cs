using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
          
        }
        public DbSet<Category> Categoreis { get; set; }
        public DbSet<SubCategory> SubCategoreis { get; set; }
        //public DbSet<Category_SubCategory> Category_SubCategory { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
           
        }
    }
}