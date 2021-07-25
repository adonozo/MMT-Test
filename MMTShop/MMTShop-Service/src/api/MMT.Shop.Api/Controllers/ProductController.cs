using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MMT.Shop.ServiceInterfaces;

namespace MMT.Shop.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;
        private readonly IProductService service;
        
        public ProductController(ILogger<ProductController> logger, IProductService service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpGet]
        [Route("featured")]
        public async Task<IActionResult> GetFeaturedProducts()
        {
            try
            {
                var result = await this.service.GetFeaturedProducts();
                return this.Ok(result);
            }
            catch (Exception exception)
            {
                this.logger.LogError(exception, "Error trying to get the featured products");
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}