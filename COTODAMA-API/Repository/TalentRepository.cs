using System;
using System.Collections.Generic;
using System.Linq;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace COTODAMA_API.Repository
{
    public class TalentRepository
    {
        private cotodamaEntities db = new cotodamaEntities();
        public V_Talent GetTalent(int MemberID)
        {

            V_Talent result = new V_Talent()
            {
                Member = db.M_Member.Find(MemberID),
                Item = db.M_Item.Where(r => r.MemberID == MemberID),
                Sample = db.T_Sample.Where(r => r.MemberID == MemberID),
            };

            return result;
        }

    }
}