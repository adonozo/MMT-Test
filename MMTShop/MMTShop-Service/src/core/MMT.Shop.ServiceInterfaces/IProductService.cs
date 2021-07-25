using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.Shop.Models;

namespace MMT.Shop.ServiceInterfaces
{
    public interface IProductService
    {
        /// <summary>
        /// Gets the list of featured products.
        /// </summary>
        /// <returns>The list of featured products.</returns>
        public Task<List<Product>> GetFeaturedProducts();
    }
}