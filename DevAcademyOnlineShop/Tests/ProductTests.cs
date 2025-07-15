using DevAcademyOnlineShop.Data;
using DevAcademyOnlineShop.Helpers;
using DevAcademyOnlineShop.View.Model.Models;
using Microsoft.EntityFrameworkCore;
using DevAcademyOnlineShop.Controllers;
using Xunit;

namespace DevAcademyOnlineShop.Tests
{
    public class ProductTests
    {
        private DbContextOptions<ApplicationDbContext> GetInMemoryOptions()
        {
            return new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
        }

        [Fact] // Add the Fact attribute to mark this as a test method
        public void CanAddProduct()
        {
            var options = GetInMemoryOptions();

            using (var _context = new ApplicationDbContext(options))
            {
                _context.Product.Add(new Product { ProductName = "Test Product", ProductPrice = 9.99 });
                _context.SaveChanges();
            }

            using (var context = new ApplicationDbContext(options))
            {
                Assert.Equal(1, context.Product.Count());
                Assert.Equal("Test Product", context.Product.Single().ProductName);
            }
        }
    }

}
