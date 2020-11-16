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
    public class ItemRepository
    {
        private cotodamaEntities db = new cotodamaEntities();
        public M_Item GetItem(int MemberID)
        {
            try
            {
                int ItemID = db.M_Item.Where(r => r.MemberID == MemberID).Single().ItemID;


                return db.M_Item.Find(ItemID);


            }
            catch
            {
                return null;

            }


        }
        //会員登録時のアイテム作成
        public M_Item AddByMember(M_Member member)
        {
            M_Item item = new M_Item
            {
                ItemName = "",
                ItemDiscription = "",
                ItemPriceUnit = 0,
                CategoryID = null,
                ItemDeliveryDate = null,
                ItemStock = null,
                MemberID = member.MemberID,
                MemberName = member.HundleName,
                RegisterDateTime = DateTime.UtcNow.AddHours(9),
                EditDateTime = DateTime.UtcNow.AddHours(9)
            };

            return item;
        }


    }

    public static class ItemRepositoryStatic
    {
        public static M_Item AddByItemClass(this M_Item item)
        {
            item.RegisterDateTime = DateTime.UtcNow.AddHours(9);
            item.EditDateTime = DateTime.UtcNow.AddHours(9);

            return item;
        }

        public static M_Item EditByItemClass(this M_Item old, M_Item edit)
        {

            old.ItemName = edit.ItemName;
            old.ItemDiscription = edit.ItemDiscription;
            old.ItemPriceUnit = edit.ItemPriceUnit;
             old.ItemDeliveryDate = edit.ItemDeliveryDate;
            old.ItemStock = edit.ItemStock;
            old.CategoryID = edit.CategoryID;
            old.EditDateTime = DateTime.UtcNow.AddHours(9);

            return old;
        }

        public static M_Item EditByMemberName(this M_Item old, string MemberName)
        {

            old.MemberName = MemberName;
            old.EditDateTime = DateTime.UtcNow.AddHours(9);

            return old;
        }
    }
}