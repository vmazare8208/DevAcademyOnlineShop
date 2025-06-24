using DevAcademyOnlineShop.View.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Data
{
    public class ApplicationDbContext_old : DbContext
    {
        public ApplicationDbContext_old(DbContextOptions<ApplicationDbContext_old> options)
            : base(options) { }

        public DbSet<Product> Product { get; set; }
    }

}
