using Catalog.Domain;
using Catalog.Persistence.DataBase.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Catalog.Persistence.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Catalog");

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ProductConfiguration(modelBuilder.Entity<Product>());
            new ProductInStockCongiguration(modelBuilder.Entity<ProductInStock>());
        }
    }
}
