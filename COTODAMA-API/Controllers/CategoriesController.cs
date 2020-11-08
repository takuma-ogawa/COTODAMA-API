using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;


namespace COTODAMA_API.Controllers
{
    public class CategoriesController : ApiController
    {

        private cotodamaEntities db = new cotodamaEntities();
        [NonAction]
        public Boolean RegisterCategory(M_Category category)
        {
            category.RegisterDateTime = DateTime.UtcNow.AddHours(9);
            category.EditDateTime = DateTime.UtcNow.AddHours(9);

            db.M_Category.Add(category);

            db.SaveChanges();

            return true;


        }

    }
}
