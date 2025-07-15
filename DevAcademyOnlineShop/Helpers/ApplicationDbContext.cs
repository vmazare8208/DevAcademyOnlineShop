using DevAcademyOnlineShop.View.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Helpers
{
    public class ApplicationDbContext    : DbContext
    {
        
         // public DbSet<YourType> YourEntity { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
