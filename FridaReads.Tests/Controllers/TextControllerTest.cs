using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FridaReads.Server.Controllers;
using FridaReads.Server.BusinessLogics;
using FridaReads.Server.Entities;
using Moq;
using Xunit;
using FridaReads.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace FridaReads.Tests.Controllers
{
    public class TextControllerTest
    {
        [Fact]
        public void GetAllAsync_ReturnsAllTexts()
        {
            // Arrange
            var mockRepo = new Mock<TextRepository>();
            mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(GetSampleTexts());

            var mockUserBusinessLogic = new Mock<UserBusinessLogic>();
            var mockMapper = new Mock<IMapper>();

            var service = new TextBusinessLogic(mockRepo.Object, mockUserBusinessLogic.Object, mockMapper.Object);
            var controller = new TextController(service);

            // Act
            var result = controller.GetAllTexts();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<Text>>(okResult.Value);

            Assert.Equal(2, returnValue.Count);
        }

        private List<Text> GetSampleTexts()
        {
            return new List<Text>
        {
            new Text { Id = 1, Name = "Text1" },
            new Text { Id = 2, Name = "Text2" }
        };
        }
    }
}