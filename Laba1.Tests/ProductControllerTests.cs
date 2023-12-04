using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Laba1.Controllers;
using Laba1.DAL.Entities;
using Xunit;
using Microsoft.AspNetCore.Http;
using Moq;

namespace Laba1.Tests
{
    public class ProductControllerTests
    {
        [Theory]
        //[InlineData(1, 3, 1)] // 1-я страница, кол. объектов 3, id первого  объекта 1
        //[InlineData(2, 2, 4)] // 2-я страница, кол. объектов 2, id первого объекта 4
        [MemberData(nameof(TestData.Params), MemberType = typeof(TestData))]
        public void ControllerGetsProperPage(int page, int qty, int id)
        {
			//// Arrange 
			//// Контекст контроллера
			//var controllerContext = new ControllerContext();
			//// Макет HttpContext
			//var moqHttpContext = new Mock<HttpContext>();
			//moqHttpContext.Setup(c => c.Request.Headers)
			//.Returns(new HeaderDictionary());

			//controllerContext.HttpContext = moqHttpContext.Object;
			//var controller = new ProductController()
			//{ ControllerContext = controllerContext };

			//controller._dishes = TestData.GetDishesList();
   //         // Act
   //         var result = controller.Index(pageNo: page, group: null) as ViewResult;
   //         var model = result?.Model as List<Dish>;
   //         // Assert
   //         Assert.NotNull(model);
   //         Assert.Equal(qty, model.Count);
   //         Assert.Equal(id, model[0].DishId);

        }
        [Fact]
        public void ControllerSelectsGroup()
        {
			//// arrange
			//// Контекст контроллера
			//var controllerContext = new ControllerContext();
			//// Макет HttpContext
			//var moqHttpContext = new Mock<HttpContext>();
			//moqHttpContext.Setup(c => c.Request.Headers)
			//.Returns(new HeaderDictionary());

			//controllerContext.HttpContext = moqHttpContext.Object;
			//var controller = new ProductController()
			//{ ControllerContext = controllerContext };

			//var data = TestData.GetDishesList();
   //         controller._dishes = data;
   //         var comparer = Comparer<Dish>
   //         .GetComparer((d1, d2) => d1.DishId.Equals(d2.DishId));
   //         // act
   //         var result = controller.Index(2) as ViewResult;
   //         var model = result.Model as List<Dish>;
   //         // assert
   //         Assert.Equal(2, model.Count);
   //         Assert.Equal(data[2], model[0], comparer);
        }
    }
}
