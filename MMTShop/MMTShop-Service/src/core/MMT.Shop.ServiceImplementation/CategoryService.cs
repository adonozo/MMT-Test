using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MMT.Shop.DataInterfaces;
using MMT.Shop.Models;

namespace MMT.Shop.ServiceImplementation
{
    public class CategoryService
    {
        public CategoryService(ILogger<CategoryService> logger, ICategoryData categoryData)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}