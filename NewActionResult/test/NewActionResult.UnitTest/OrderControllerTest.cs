using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using NewActionResult.Controllers;
using NewActionResult.Models;
using NUnit.Framework;

namespace NewActionResult.UnitTest
{
    [TestFixture]
    public class OrderControllerTest
    {
        [Test]
        public void Get_ShouldReturnTwoOrders()
        {
            //arrange
            var controller = new OrderController {Configuration = GetConfiguration(), Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost")};

            //act
            var response = controller.Get().ExecuteAsync(new CancellationToken());

            //assert
            IEnumerable<Order> orders;
            response.Result.TryGetContentValue(out orders);

            Assert.AreEqual(2, orders.Count());
        }

        private HttpConfiguration GetConfiguration()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            return config;
        }
    }
}
