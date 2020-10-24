using System;
using System.Collections.Generic;
using System.Linq;
using COTODAMA_API.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace COTODAMA_API.Controllers
    {
    public class MembersController : ApiController
        {

        [HttpPost]
        public Boolean RegisterMember()
        {
            return true;
        }

        }
    }
