using DevAcademyOnlineShop.View.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Helpers
{
    public class ApplicationContext    : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Your conn string");
            // in memory database used for simplicity, change to a real db for production applications
            optionsBuilder.UseInMemoryDatabase("TestDb");
        }

       // public DbSet<YourType> YourEntity { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
