using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFirstProject.Controllers
{
    public class FormattersController : ApiController
    {
        public IEnumerable<string> Get()
        {
            IList<string> formatters = new List<string>();

            formatters.Add(GlobalConfiguration.Configuration.Formatters.JsonFormatter.GetType().FullName);
            formatters.Add(GlobalConfiguration.Configuration.Formatters.XmlFormatter.GetType().FullName);
            formatters.Add(GlobalConfiguration.Configuration.Formatters.FormUrlEncodedFormatter.GetType().FullName);

            //foreach (var item in GlobalConfiguration.Configuration.Formatters)
            //{
            //    formatters.Add(item.ToString());
            //}

            return formatters.AsEnumerable<string>();
        }
    }
}
