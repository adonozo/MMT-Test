using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.Shop.Models;

namespace MMT.Shop.ServiceInterfaces
{
    public interface IProductService
    {
        public Task<List<Product>> GetFeaturedProducts();
    }
}