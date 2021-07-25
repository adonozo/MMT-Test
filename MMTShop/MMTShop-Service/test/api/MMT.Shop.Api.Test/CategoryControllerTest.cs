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
    public class CategoryControllerTest
    {
        [Fact]
        public async Task GetCategories_OnValidRequest_ShouldReturnStatusOk()
        {
            // Arrange
            var logger = Substitute.For<ILogger<CategoryController>>();
            var service = Substitute.For<ICategoryService>();
            service.GetCategories().Returns(Task.FromResult(new List<Category>()));
            var controller = new CategoryController(logger, service);
            
            // Act
            var result = await controller.GetCategories();

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            ((OkObjectResult) result).StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}
