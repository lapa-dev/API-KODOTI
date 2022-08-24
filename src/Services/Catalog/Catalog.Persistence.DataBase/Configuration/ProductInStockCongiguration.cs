using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.DataBase.Configuration
{
    public class ProductInStockCongiguration
    {
        public ProductInStockCongiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductInStockId);

            var randon = new Random();

            var productInStock = new List<ProductInStock>();

            for (int i = 1; i < 100; i++)
            {
                productInStock.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = randon.Next(0, 100)
                });
            }

            entityBuilder.HasData(productInStock);
        }
    }
}
