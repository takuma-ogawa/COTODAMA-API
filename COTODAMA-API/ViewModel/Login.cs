using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COTODAMA_API.Models;

namespace COTODAMA_API.ViewModel
{
    public class Login
    {
        public string email { get; set; }

        public string password { get; set; }
    }

    public class LoginToken
    {
       
        public string Token { get; set; }
        
        public M_Member Member { get; set; }
    }
}