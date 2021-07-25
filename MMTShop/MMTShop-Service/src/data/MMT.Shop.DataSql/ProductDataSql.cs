using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MMT.Shop.DataInterfaces;
using MMT.Shop.Models;

namespace MMT.Shop.DataSql
{
    public class ProductDataSql : IProductData
    {
        private readonly DataContext dbContext;
        private readonly ILogger<ProductDataSql> logger;

        public ProductDataSql(DataContext dbContext, ILogger<ProductDataSql> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        public async Task<List<Product>> GetFeaturedProducts()
        {
            this.logger.LogDebug("Getting the list of featured products");
            return await this.dbContext.Products.FromSqlRaw("GetFeaturedProducts").ToListAsync();
        }
    }
}