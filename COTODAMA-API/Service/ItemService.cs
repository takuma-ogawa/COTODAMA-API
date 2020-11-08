﻿using System;
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
    public class ItemService
    {
        private cotodamaEntities db = new cotodamaEntities();

        //会員登録をするときのアイテムの登録、とりあえず適当な値を入れておく
        public Boolean RegisterItemByMember(M_Member member)
        {
            try
            {

                db.M_Item.Add(new ItemRepository().AddByMember(member));

                db.SaveChanges();

                return true;

            }
            catch
            {
                return false;
            }

        }

        public Boolean EditMember(M_Member edit)
        {
            try
            {

                var member = db.M_Member.Find(edit.MemberID).Edit(edit);
                db.Entry(member).State = EntityState.Modified;


                //メンバーのハンドルネームが変わったときItemのMemberNameも変える
                var item = db.M_Item.Find(edit.ItemID).EditByMemberName(edit.HundleName);
                db.Entry(item).State = EntityState.Modified;


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