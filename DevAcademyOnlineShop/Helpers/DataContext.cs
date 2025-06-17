﻿namespace DevAcademyOnlineShop.Helpers
{
     using DevAcademyOnlineShop.View.Model.Models;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
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
