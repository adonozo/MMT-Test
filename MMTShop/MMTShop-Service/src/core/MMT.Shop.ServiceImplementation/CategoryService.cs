using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MMT.Shop.DataInterfaces;
using MMT.Shop.Models;
using MMT.Shop.ServiceInterfaces;

namespace MMT.Shop.ServiceImplementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ILogger<CategoryService> logger;
        private readonly ICategoryData categoryData;

        public CategoryService(ILogger<CategoryService> logger, ICategoryData categoryData)
        {
            this.logger = logger;
            this.categoryData = categoryData;
        }

        public async Task<List<string>> GetCategories()
        {
            var result =  await this.categoryData.GetCategories();
            this.logger.LogDebug($"Found {result.Count} categories");
            return result;
        }

        public async Task<List<Product>> GetProductsByCategoryId(int categoryId)
        {
            var result = await this.categoryData.GetProductsByCategoryId(categoryId);
            this.logger.LogDebug($"Found {result.Count} Products");
            return result;
        }
    }
}