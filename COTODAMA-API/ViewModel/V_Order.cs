using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;

namespace COTODAMA_API.ViewModel
{
    public class V_QuestionOfOrder
    {
        public string QuestionName { get; set; }
        public string AnswerName { get; set; } 
    }


    public class V_Order
    {
        public T_Order Order { get; set; }

        public List<V_QuestionOfOrder> Question { get; set; }

    }
}