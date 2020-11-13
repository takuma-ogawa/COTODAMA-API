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
    public class SellController : ApiController
    {

        [HttpGet]
        public V_Sell GetListing(int MemberID)
        {
            return new SellRepository().GetListing(MemberID);

        }


        [NonAction]
        public bool RegisterListing([FromBody] V_Sell sell)
        {
            return new SellService().RegisterListing(sell);
        }


        [HttpPut]
        public bool EditListing([FromBody] V_Sell sell)
        {
            return new SellService().EditListing(sell);
        }




    }
}
