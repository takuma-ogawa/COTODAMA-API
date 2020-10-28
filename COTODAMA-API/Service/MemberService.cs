using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COTODAMA_API.Models;


namespace COTODAMA_API.Service
{
    public class MemberService
    {
        private COTODAMAContext db = new COTODAMAContext();
       
        public Boolean Add(Member member)
        {

            db.Members.Add(member);

            db.SaveChanges();

            return true;
        }
    }
}