using System;
using System.Collections.Generic;
using System.Linq;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;
using COTODAMA_API.Repository;
using COTODAMA_API.Service;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace COTODAMA_API.Controllers
{
    public class MembersController : ApiController
    {

        private cotodamaEntities db = new cotodamaEntities();

        [HttpGet]
        public M_Member GetMember(int MemberID)
        {
            return new MemberRepository().GetMemberByID(MemberID);
        }



        [HttpPost]
        public Boolean RegisterMember([FromBody] M_Member member)
        {
            //アイテムも自動登録

            int? MemberID = new MemberService().RegisterMember(member);

            if (MemberID != null)
            {
                return new ItemService().RegisterItemByMember(member,(int)MemberID);
            }
            else
            {
                return false;
            }



           

        }

        [HttpPut]
        public Boolean EditMember([FromBody] M_Member member)
        {

            return new MemberService().EditMember(member);
        }
        



    }
}
