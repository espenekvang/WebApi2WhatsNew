using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using NewActionResult.ActionResults;
using NewActionResult.Models;

namespace NewActionResult.Controllers
{
    public class OrderController : ApiController
    {
        public IHttpActionResult Get()
        {
            var orders = new List<Order>
            {
                new Order{Id = 1, Name = "FirstOrder"},
                new Order{Id = 2, Name = "SecondOrder"}
            };
            return Content(HttpStatusCode.OK, orders);
        }

        [Route("api/order/{id}", Name = "GetById")]
        public IHttpActionResult GetById(int id)
        {
            var order = new Order {Id = id};
            return Content(HttpStatusCode.OK, order);
        }

        public IHttpActionResult Post()
        {
            var newId = new Random().Next(1, 100);
            return new ContentCreatedActionResult(Request, Url.Link("GetById", new{id = newId}));
        }
    }
}
