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
    public class SellRepository
    {

        private cotodamaEntities db = new cotodamaEntities();

        public V_Sell GetListing(int MemberID)
        {
            try
            {
                int ItemID = db.M_Item.Where(r => r.MemberID == MemberID).Single().ItemID;

                var questionOfItem = db.T_QuestionOfItem.Where(r => r.ItemID == ItemID).OrderBy(r => r.SortID);

                List<string> Question = new List<string>();

                foreach (var i in questionOfItem)
                {
                    Question.Add(i.QuestionName);
                }

                return new V_Sell
                {
                    Item = db.M_Item.Find(ItemID),
                    Question = Question

                };

            }
            catch
            {
                return null;

            }


        }
    }
}