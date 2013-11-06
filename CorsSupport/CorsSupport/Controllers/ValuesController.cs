using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CorsSupport.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [EnableCors("http://mydomain.com, http://anotherdomain.com", "accept, content-type, origin", "get,post")]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }
    }
}
