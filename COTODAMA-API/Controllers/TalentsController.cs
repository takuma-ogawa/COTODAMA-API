using System;
using System.Collections.Generic;
using System.Linq;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;
using COTODAMA_API.Repository;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace COTODAMA_API.Controllers
{
    public class TalentsController : ApiController
    {
        private cotodamaEntities db = new cotodamaEntities();
        [HttpGet]
        public V_Talent GetTalent(int MemberID)
        {

            return new TalentRepository().GetTalent(MemberID);
        }

    }
}

