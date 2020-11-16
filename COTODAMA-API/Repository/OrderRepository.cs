using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;

namespace COTODAMA_API.Repository
{

    public class OrderRepository
    {
        private cotodamaEntities db = new cotodamaEntities();

        public V_Order GetOrder()
        {

            return new V_Order
            {
                Order = new T_Order(),
                Situation = db.M_Situation.OrderBy(r => r.SortID),
            };
        }

    }

    public static class OrderRepositoryStatic
    {
        public static T_Order AddByOrderClass(this T_Order order,string UserName,string TalentName)
        {

            //※OrderIDの取り方は考える
            order.OrderID = "1";
            order.UserName = UserName;
            order.TalentName = TalentName;
            order.UnlockFlag = true;
            order.IsAccepting = false;
            order.IsDownloading = false;
            order.OrdererCheckFlag = false;
            order.SellerCheckFlag = false;

            order.RegisterDateTime = DateTime.UtcNow.AddHours(9);
            order.EditDateTime = DateTime.UtcNow.AddHours(9);

            return order;
        }

    }

}