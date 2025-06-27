namespace DevAcademyOnlineShop.Helpers
{
     using DevAcademyOnlineShop.View.Model.Models;
    using Microsoft.EntityFrameworkCore;

    public class DataContext_old : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext_old(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseInMemoryDatabase("TestDb");
        }

        public DbSet<Product> Products { get; set; }
    }
}
