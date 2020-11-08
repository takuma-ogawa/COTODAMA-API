using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COTODAMA_API.Models;


namespace COTODAMA_API.ViewModel
{
    public class V_Talent
    {
        public M_Member Member { get; set; }
        public IEnumerable<M_Item> Item { get; set; }

        public IEnumerable<T_Sample> Sample { get; set; }
    }
}