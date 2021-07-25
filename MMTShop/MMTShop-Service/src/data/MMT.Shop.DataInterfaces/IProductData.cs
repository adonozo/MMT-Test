using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.Shop.Models;

namespace MMT.Shop.DataInterfaces
{
    public interface IProductData
    {
        public Task<List<Product>> GetFeaturedProducts();
    }
}