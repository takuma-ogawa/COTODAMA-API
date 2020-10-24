using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COTODAMA_API.Models
    {
    public class Item
        {
        public string ItemId { get; set; }
        public int ID { get; set; }

        public string ItemName { get; set; }

        public string ItemDiscription { get; set; }

        public int ItemPriceUnit { get; set; }

        public int ItemLengthMin { get; set; }

        public int ItemLengthMax { get; set; }

        public int CategoryId { get; set; }
        public DateTime? ItemDeliveryDate { get; set; }

        public int? ItemStock { get; set; }
        public DateTime RegisterDateTime { get; set; }
        public DateTime EditDateTime { get; set; }

        }
    }