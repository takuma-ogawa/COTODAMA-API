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
    public class SellService
    {
        private cotodamaEntities db = new cotodamaEntities();

        public bool RegisterListing(V_Sell sell)
        {

            try
            {
                var Item = sell.Item.AddByItemClass();

                db.M_Item.Add(Item);

                db.SaveChanges();

                for(var i = 0; i < sell.Question.Count(); i++)
                {
                    var question = new QuestionOfItemRepository().AddByQuestionName(sell.Question[i], i,Item.MemberID, Item.ItemID);

                    db.T_QuestionOfItem.Add(question);
                }

                db.SaveChanges();

                return true;

            }
            catch
            {
                return false;
            }


        }


        public bool EditListing(V_Sell sell)
        {

            try
            {
                var item = db.M_Item.Find(sell.Item.ItemID).EditByItemClass(sell.Item) ;

                db.Entry(item).State = EntityState.Modified;

                db.SaveChanges();

                for (var i = 0; i < sell.Question.Count(); i++)
                {

                    var question = db.T_QuestionOfItem.Where(r => r.ItemID == sell.Item.ItemID && r.SortID == i).SingleOrDefault();

                    if(question == null)
                    {
                        question = new QuestionOfItemRepository().AddByQuestionName(sell.Question[i], i, item.MemberID, item.ItemID);

                        db.T_QuestionOfItem.Add(question);
                    }
                    else
                    {

                        db.Entry(question.EditByQuestionName(sell.Question[i])).State = EntityState.Modified;

                    }

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