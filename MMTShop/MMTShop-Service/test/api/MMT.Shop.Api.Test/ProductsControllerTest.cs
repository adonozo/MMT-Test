using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MMT.Shop.Api.Controllers;
using MMT.Shop.Models;
using MMT.Shop.ServiceInterfaces;
using NSubstitute;
using Xunit;

namespace MMT.Shop.Api.Test
{
    public class ProductsControllerTest
    {
        [Fact]
        public async Task GetFeaturedProducts_OnValidRequest_ShouldReturnStatusOk()
        {
            // Arrange
            var logger = Substitute.For<ILogger<ProductController>>();
            var service = Substitute.For<IProductService>();
            service.GetFeaturedProducts().Returns(Task.FromResult(new List<Product>()));
            var controller = new ProductController(logger, service);
            
            // Act
            var result = await controller.GetFeaturedProduct();

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            ((OkObjectResult) result).StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}