using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFirstProject.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Values()
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/values/5
        //[HttpGet]
        //public string Value(int id)
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/values
        //[HttpPost]
        //public void SaveNewValue([FromBody]string value)
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/values/5
        //[HttpPut]
        //public void UpdateValue(int id, [FromBody]string value)
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/values/5
        //[HttpDelete]
        //public void RemoveValue(int id)
        public void Delete(int id)
        {
        }
    }
}
