using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MMT.Shop.ServiceInterfaces;

namespace MMT.Shop.Api.Controllers
{
    public class ProductController
    {
        public ProductController(ILogger<ProductController> logger, IProductService service)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IActionResult> GetFeaturedProduct()
        {
            throw new System.NotImplementedException();
        }
    }
}