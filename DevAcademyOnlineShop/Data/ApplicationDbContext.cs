using DevAcademyOnlineShop.View.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Product { get; set; }
    }

}
