﻿using System;
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
        //会員登録時のアイテム作成
        public M_Item AddByMember(M_Member member)
        {
            //※ItemIDの取り方を後で考える
            M_Item item = new M_Item
            {
                ItemID = "1",
                ItemName = "",
                ItemDiscription = "",
                ItemPriceUnit = 0,
                ItemLengthMin = 0,
                ItemLengthMax = 5,
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
            old.ItemLengthMin = edit.ItemLengthMin;
            old.ItemLengthMax = edit.ItemLengthMax;
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