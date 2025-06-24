using DevAcademyOnlineShop.Data;
using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Extensions
{
    public static class ConfigureServiceExtensions
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextFactory<ApplicationDbContext_old>(
                static options => options.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=Test;ConnectRetryCount=0"));
        }
    }
}
