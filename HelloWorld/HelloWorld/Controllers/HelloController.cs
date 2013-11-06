using System.Collections.Generic;
using System.Web.Http;

namespace HelloWorld.Controllers
{
    public class HelloController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new[] { "World"};
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Hello " + id;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
