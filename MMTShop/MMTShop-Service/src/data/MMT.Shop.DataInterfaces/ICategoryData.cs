using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.Shop.Models;

namespace MMT.Shop.DataInterfaces
{
    public interface ICategoryData
    {
        /// <summary>
        /// Gets the list on category names.
        /// </summary>
        /// <returns>The list of category names.</returns>
        public Task<List<string>> GetCategories();
        
        
        /// <summary>
        /// Gets the list of products for a given category ID.
        /// </summary>
        /// <param name="categoryId">The category ID</param>
        /// <returns></returns>
        public Task<List<Product>> GetProductsByCategoryId(int categoryId);
    }
}