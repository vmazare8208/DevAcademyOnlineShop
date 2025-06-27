using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }
        public DbSet<ProductDto> Product { get; set; }
        public DbSet<UserDto> Users { get; set; } 
    }
}
