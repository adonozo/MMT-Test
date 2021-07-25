using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.Shop.Models;

namespace MMT.Shop.ServiceInterfaces
{
    public interface ICategoryService
    {
        public Task<List<string>> GetCategories();
        Task<List<Product>> GetProducts();
    }
}