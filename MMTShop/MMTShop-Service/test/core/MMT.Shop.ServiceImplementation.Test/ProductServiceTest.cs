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
    public class ProductServiceTest
    {
        [Fact]
        public async Task GetCategories_OnValidInput_ShouldReturnCategoryNames()
        {
            // Arrange
            var logger = Substitute.For<ILogger<ProductService>>();
            var productData = Substitute.For<IProductData>();
            productData.GetFeaturedProducts().Returns(Task.FromResult(new List<Product> {new Product()}));
            var service = new ProductService(logger, productData);

            // Act
            var result = await service.GetFeaturedProducts();

            // Assert
            result.Should().NotBeEmpty();
        }
    }
}