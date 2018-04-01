using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StandAloneEmptyWebApi.Controllers
{
    public class MyController : ApiController
    {
        public string Get()
        {
            return "Hi this is BizRuntime";
        }
    }
}
