using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.Shop.Models;

namespace MMT.Shop.DataInterfaces
{
    public interface ICategoryData
    {
        public Task<List<string>> GetCategories();
    }
}