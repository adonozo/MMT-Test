using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MMT.Shop.ServiceInterfaces;

namespace MMT.Shop.Api.Controllers
{
    public class CategoryController
    {
        public CategoryController(ILogger<CategoryController> logger, ICategoryService service)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IActionResult> GetCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}