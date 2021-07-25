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
        private readonly ILogger<ProductService> logger;
        private readonly IProductData productData;
        
        public ProductService(ILogger<ProductService> logger, IProductData productData)
        {
            this.logger = logger;
            this.productData = productData;
        }

        public async Task<List<Product>> GetFeaturedProducts()
        {
            var result = await this.productData.GetFeaturedProducts();
            this.logger.LogDebug($"Found {result.Count} featured products.");
            return result;
        }
    }
}