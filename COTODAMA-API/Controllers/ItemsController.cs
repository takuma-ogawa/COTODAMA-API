using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using COTODAMA_API.Models;
using COTODAMA_API.Service;
using COTODAMA_API.Repository;

using System.Web.Http;

namespace COTODAMA_API.Controllers
{
    public class ItemsController : ApiController
    {
        private cotodamaEntities db = new cotodamaEntities();

        [HttpGet]
        public M_Item GetItem(int MemberID)
        {
            return new ItemRepository().GetItem(MemberID);

        }

        [HttpPut]
        public bool EditItem([FromBody] M_Item item)
        {
            return new ItemService().EditItem(item);
        }


    }
}
