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

        private cotodamaEntities db = new cotodamaEntities();

        [HttpPost]
        public Boolean RegisterMember([FromBody] M_Member member)
        {
                member.RegisterDateTime = DateTime.UtcNow.AddHours(9);
                member.EditDateTime = DateTime.UtcNow.AddHours(9);

                db.M_Member.Add(member);

                db.SaveChanges();

                return true;

     
        }

        }
    }
