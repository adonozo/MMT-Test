using System;
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
using NSubstitute.ExceptionExtensions;
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
            service.GetCategories().Returns(Task.FromResult(new List<string>()));
            var controller = new CategoryController(logger, service);
            
            // Act
            var result = await controller.GetCategories();

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            ((OkObjectResult) result).StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact]
        public async Task GetCategories_OnInvalidRequest_ShouldReturnInternalError()
        {
            // Arrange
            var logger = Substitute.For<ILogger<CategoryController>>();
            var service = Substitute.For<ICategoryService>();
            service.GetCategories().Throws(_ => throw new Exception());
            var controller = new CategoryController(logger, service);
            
            // Act
            var result = await controller.GetCategories();

            // Assert
            result.Should().BeOfType<StatusCodeResult>();
            ((StatusCodeResult) result).StatusCode.Should().Be(StatusCodes.Status500InternalServerError);
        }
        
        [Fact]
        public async Task GetProducts_OnValidRequest_ShouldReturnStatusOk()
        {
            // Arrange
            var logger = Substitute.For<ILogger<CategoryController>>();
            var service = Substitute.For<ICategoryService>();
            service.GetProducts().Returns(Task.FromResult(new List<Product>()));
            var controller = new CategoryController(logger, service);
            
            // Act
            var result = await controller.GetProducts(1);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            ((OkObjectResult) result).StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}
