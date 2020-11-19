using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;
using COTODAMA_API.Repository;
using COTODAMA_API.Service;

namespace COTODAMA_API.Controllers
{
    public class LoginController : ApiController
    {
        private cotodamaEntities db = new cotodamaEntities();
        [HttpPost]
        public LoginToken CreateToken([FromBody] Login login) 
        {
            var member = new LoginService().SearchMember(login);

            if(member != null)
            {
                return new LoginToken { 
                   Token = new LoginService().CreateToken(login.email) ,
                   Member = member
                };
                

            }
            else
            {
                
                return null;

            }

        }

        


    }
}
