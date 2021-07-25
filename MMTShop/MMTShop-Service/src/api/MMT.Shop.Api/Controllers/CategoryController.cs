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
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> logger;
        private readonly ICategoryService categoryService;
        
        public CategoryController(ILogger<CategoryController> logger, ICategoryService service)
        {
            this.logger = logger;
            this.categoryService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var result = await this.categoryService.GetCategories();
                return this.Ok(result);
            }
            catch (Exception exception)
            {
                this.logger.LogError(exception, "Could not get the categories list");
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("{id}/products")]
        public async Task<IActionResult> GetProducts([FromBody] int id)
        {
            throw new NotImplementedException();
        }
    }
}