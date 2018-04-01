using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFirstProject.Controllers
{
    public class MySchoolController : ApiController
    {
        // GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Values()
        public IEnumerable<string> Get()
        {
            return new string[] { "Razi", "Ahmad" };
        }

        // GET: api/values/5
        //[HttpGet]
        //public string Value(int id)
        public string Get(int id)
        {
            return "value";
        }
    }
}
