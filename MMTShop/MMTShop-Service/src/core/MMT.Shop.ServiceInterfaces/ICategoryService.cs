using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.Shop.Models;

namespace MMT.Shop.ServiceInterfaces
{
    public interface ICategoryService
    {
        /// <summary>
        /// Gets the names of the registered categories
        /// </summary>
        /// <returns>The category names list</returns>
        public Task<List<string>> GetCategories();

        /// <summary>
        /// Gets the list of products for a given category ID
        /// </summary>
        /// <param name="categoryId">The category ID</param>
        /// <returns>The list of products for that category</returns>
        public Task<List<Product>> GetProductsByCategoryId(int categoryId);
    }
}