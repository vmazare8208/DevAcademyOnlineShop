using DevAcademyOnlineShop.Data;
using DevAcademyOnlineShop.View.Model.Models;
using Microsoft.EntityFrameworkCore;
using DevAcademyOnlineShop.Controllers;
using Xunit;

namespace DevAcademyOnlineShop.Tests
{
    public class ProductTests
    {
        private DbContextOptions<ApplicationDbContext_old> GetInMemoryOptions()
        {
            return new DbContextOptionsBuilder<ApplicationDbContext_old>()
                .UseInMemoryDatabase("TestDb")
                .Options;
        }

        [Fact] // Add the Fact attribute to mark this as a test method
        public void CanAddProduct()
        {
            var options = GetInMemoryOptions();

            using (var _context = new ApplicationDbContext_old(options))
            {
                _context.Product.Add(new Product { ProductName = "Test Product", ProductPrice = 9.99 });
                _context.SaveChanges();
            }

            using (var context = new ApplicationDbContext_old(options))
            {
                Assert.Equal(1, context.Product.Count());
                Assert.Equal("Test Product", context.Product.Single().ProductName);
            }
        }
    }

}
