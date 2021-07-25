using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using MMT.Shop.DataInterfaces;
using MMT.Shop.Models;
using NSubstitute;
using Xunit;

namespace MMT.Shop.ServiceImplementation.Test
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetCategories_OnValidInput_ShouldReturnCategoryList()
        {
            // Arrange
            var logger = Substitute.For<ILogger<CategoryService>>();
            var categoryData = Substitute.For<ICategoryData>();
            categoryData.GetCategories().Returns(Task.FromResult(new List<Category> {new Category()}));
            var service = new CategoryService(logger, categoryData);

            // Act
            var result = await service.GetCategories();

            // Assert
            result.Should().NotBeEmpty();
        }
    }
}
