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

        /// <summary>
        /// Gets the category names as a string array.
        /// </summary>
        /// <returns>A HTTP OK status result if the result was successful. A Internal Server Error status otherwise.</returns>
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

        /// <summary>
        /// Gets the list of products for a given category ID.
        /// </summary>
        /// <param name="id">The Category ID.</param>
        /// <returns>A HTTP OK status result with the products list if the result was successful. A Internal Server Error status otherwise.</returns>
        [HttpGet]
        [Route("{id}/products")]
        public async Task<IActionResult> GetProducts([FromRoute] int id)
        {
            try
            {
                var result = await this.categoryService.GetProductsByCategoryId(id);
                return this.Ok(result);
            }
            catch (Exception exception)
            {
                this.logger.LogError(exception, $"Could not get the product list for category {id}");
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}