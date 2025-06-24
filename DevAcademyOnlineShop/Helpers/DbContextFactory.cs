using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Helpers
{
    public class DbContextFactory(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;
    }
}
