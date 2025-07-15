using DevAcademyOnlineShop.Data;
using DevAcademyOnlineShop.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Extensions
{
    public static class ConfigureServiceExtensions
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContextFactory<ApplicationContext>(
            //  static options => options.UseSqlServer(
            //     @"Server=(localdb)\mssqllocaldb;Database=Test;ConnectRetryCount=0"));

            services.AddDbContextFactory<ApplicationDbContext>(
                options => options.UseInMemoryDatabase("TestInMemoryDb"));

            return services;
        }
    }
}
