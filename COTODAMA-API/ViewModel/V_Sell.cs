using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;

namespace COTODAMA_API.ViewModel
{
    public class V_Sell
    {
        public M_Item Item { get; set; }

        public List<String> Question { get; set; }
    }
}