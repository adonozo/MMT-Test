using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MMT.Shop.DataInterfaces;
using MMT.Shop.Models;

namespace MMT.Shop.DataSql
{
    public class CategoryDataSql : ICategoryData
    {
        private readonly DataContext dbContext;
        private readonly ILogger<CategoryDataSql> logger;

        public CategoryDataSql(DataContext dbContext, ILogger<CategoryDataSql> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        public async Task<List<string>> GetCategories()
        {
            this.logger.LogDebug("Getting all the categories from the database");
            var categories = await this.dbContext.Categories.FromSqlRaw("GetCategories").ToListAsync();
            return categories.Select(category => category.Name).ToList();
        }

        public async Task<List<Product>> GetProductsByCategoryId(int categoryId)
        {
            this.logger.LogDebug($"Getting the products list for category {categoryId}");
            var parameter = new SqlParameter("@categoryId", categoryId);
            var products = await this.dbContext.Products.FromSqlRaw("GetProductByCategory @categoryId", parameter).ToListAsync();
            return products;
        }
    }
}