﻿using Microsoft.EntityFrameworkCore;

namespace DevAcademyOnlineShop.Helpers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
