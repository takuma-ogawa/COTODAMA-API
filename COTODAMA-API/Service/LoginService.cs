using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;
using COTODAMA_API.Repository;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace COTODAMA_API.Service
{
    public class LoginService
    {

        private cotodamaEntities db = new cotodamaEntities();
        
        public M_Member SearchMember(Login login)
        {
            
            var member = db.M_Member.SingleOrDefault(r => r.MemberEmail == login.email && r.Password == login.password);

            return member;

        }


        public String CreateToken(string email)
        {
            byte[] encoded = Encoding.UTF8.GetBytes(email);
             
            return string.Concat(encoded.Select(b => $"{b:x2}")); ;
        }

    }
}