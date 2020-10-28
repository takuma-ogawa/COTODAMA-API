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

        private COTODAMAContext db = new COTODAMAContext();

        [HttpPost]
        public Boolean RegisterMember([FromBody] Member member)
        {
            try
            {
                member.RegisterDateTime = DateTime.UtcNow.AddHours(9);
                member.EditDateTime = DateTime.UtcNow.AddHours(9);

                db.Members.Add(member);

                db.SaveChanges();

                return true;

            }
            catch
            {
                return false;

            }
        }

        }
    }
