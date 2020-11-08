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
    public class QuestionOfOrderRepository
    {
        public T_QuestionOfOrder AddByName(V_QuestionOfOrder questionOfOrder,T_Order order,int SortID)
        {
            var question = new T_QuestionOfOrder
            {
                QuestionName = questionOfOrder.QuestionName,
                AnswerName = questionOfOrder.AnswerName,
                SortID = SortID,
                SellerID = order.SellerID,
                OrdererID = order.OrdererID,
                ItemID = order.ItemID,
                OrderID = order.ID,
                RegisterDateTime = DateTime.UtcNow.AddHours(9),
                EditDateTime = DateTime.UtcNow.AddHours(9),
            };

            return question;
        }

    }
}