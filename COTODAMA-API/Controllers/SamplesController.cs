using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using COTODAMA_API.Models;
using COTODAMA_API.Service;

using System.Web.Http;

namespace COTODAMA_API.Controllers
{
    public class SamplesController : ApiController
    {
        private cotodamaEntities db = new cotodamaEntities();
        [HttpPost]
        public Boolean RegisterSample([FromBody] T_Sample sample)
        {
     
            return new SampleService().RegisterSample(sample);

        }

    }
}
