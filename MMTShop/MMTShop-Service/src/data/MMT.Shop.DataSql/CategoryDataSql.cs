using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<List<Category>> GetCategories()
        {
            this.logger.LogDebug("Getting all the categories from the database");
            return await this.dbContext.Categories.FromSqlRaw("GetCategories").ToListAsync();
        }
    }
}