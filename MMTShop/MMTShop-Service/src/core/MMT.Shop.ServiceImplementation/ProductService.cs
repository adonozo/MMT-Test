using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MMT.Shop.DataInterfaces;
using MMT.Shop.Models;
using MMT.Shop.ServiceInterfaces;

namespace MMT.Shop.ServiceImplementation
{
    public class ProductService : IProductService
    {
        public ProductService(ILogger<ProductService> logger, IProductData productData)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Product>> GetFeaturedProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}