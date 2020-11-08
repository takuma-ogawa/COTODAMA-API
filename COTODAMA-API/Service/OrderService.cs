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


namespace COTODAMA_API.Service
{
    public class OrderService
    {
        private cotodamaEntities db = new cotodamaEntities();

        public Boolean RegisterOrder(V_Order v_order)
        {
            try
            {
                string UserName = db.M_Member.Find(v_order.Order.OrdererID).HundleName;
                string TalentName = db.M_Member.Find(v_order.Order.SellerID).HundleName;

                var order = v_order.Order.AddByOrderClass(UserName, TalentName);

                db.T_Order.Add(order);

                db.SaveChanges();

                for (var i = 0; i < v_order.Question.Count(); i++)
                {
                    var question = new QuestionOfOrderRepository().AddByName(v_order.Question[i], order,i);

                    db.T_QuestionOfOrder.Add(question);
                }

                db.SaveChanges();

                return true;

            }
            catch
            {
                return false;
            }

        }
    }
}