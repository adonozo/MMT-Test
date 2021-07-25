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
        public async Task GetCategories_OnValidInput_ShouldReturnCategoryNames()
        {
            // Arrange
            var logger = Substitute.For<ILogger<CategoryService>>();
            var categoryData = Substitute.For<ICategoryData>();
            categoryData.GetCategories().Returns(Task.FromResult(new List<string> {string.Empty}));
            var service = new CategoryService(logger, categoryData);

            // Act
            var result = await service.GetCategories();

            // Assert
            result.Should().NotBeEmpty();
        }
        
        [Fact]
        public async Task GetProductsByCategoryId_OnValidInput_ShouldReturnProductsList()
        {
            // Arrange
            var logger = Substitute.For<ILogger<CategoryService>>();
            var categoryData = Substitute.For<ICategoryData>();
            categoryData.GetProductsByCategoryId(Arg.Any<int>()).Returns(Task.FromResult(new List<Product> {new Product()}));
            var service = new CategoryService(logger, categoryData);

            // Act
            var result = await service.GetProductsByCategoryId(1);

            // Assert
            result.Should().NotBeEmpty();
        }
    }
}
