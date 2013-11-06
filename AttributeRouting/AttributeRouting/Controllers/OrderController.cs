using System.Collections.Generic;
using System.Web.Http;
using AttributeRouting.Models;

namespace AttributeRouting.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrderController : ApiController
    {
        public IEnumerable<Order> Get()
        {
            return new List<Order>();
        }

        [Route("{id:int}")]
        public Order GetById(int id)
        {
            return new Order{Id = id};
        }

        [Route("{name:alpha}")]
        public Order GetByName(string name)
        {
            return new Order{Name = name};
        }

        [HttpGet]
        [Route("~/api/customers/{customerId}/orders")]
        public IEnumerable<Order> FindByCustomer(int customerId)
        {
            return new List<Order>();
        } 
    }
}
