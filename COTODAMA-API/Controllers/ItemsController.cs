using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using COTODAMA_API.Models;

using System.Web.Http;

namespace COTODAMA_API.Controllers
{
    public class ItemsController : ApiController
    {
        private cotodamaEntities db = new cotodamaEntities();
 
        [NonAction]
        public Boolean RegisterItem(M_Item item)
        {
            item.RegisterDateTime = DateTime.UtcNow.AddHours(9);
            item.EditDateTime = DateTime.UtcNow.AddHours(9);

            db.M_Item.Add(item);

            db.SaveChanges();

            return true;
            

        }

    }
}
