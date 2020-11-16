using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;
using COTODAMA_API.Service;
using COTODAMA_API.Repository;
using COTODAMA_API.ViewModel;

namespace COTODAMA_API.Controllers
{
    public class OrdersController : ApiController
    {
        [HttpGet]
        public V_Order GetOrder()
        {
            return new OrderRepository().GetOrder();
        }
       
        [HttpPost]
        public Boolean RegisterOrder([FromBody] V_Order v_order)
        {
            return new OrderService().RegisterOrder(v_order);
        }


    }
}
