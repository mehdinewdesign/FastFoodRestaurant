using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodRestaurant.Models
{
    public class EntityContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Remove string on upload for security reasons.
            optionsBuilder.UseSqlServer("Server=localhost; Database=FastFood; User Id=SA; Password=0_CryptoAnarquismo@)(*&%$#@!;");
        }
    }
}
