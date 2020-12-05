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
    public class ItemService
    {
        private cotodamaEntities db = new cotodamaEntities();

        //会員登録をするときのアイテムの登録、とりあえず適当な値を入れておく
        public Boolean RegisterItemByMember(M_Member member,int MemberID)
        {
            try
            {

                var item = new ItemRepository().AddByMember(member);
                db.M_Item.Add(item);

                db.SaveChanges();

                var editMember = db.M_Member.Find(MemberID);
                editMember.ItemID = item.ItemID;

                db.Entry(editMember).State = EntityState.Modified;

                db.SaveChanges();

                return true;

            }
            catch
            {
                return false;
            }

        }


        public bool EditItem(M_Item edit)
        {

            try
            {
                var item = db.M_Item.Find(edit.ItemID).EditByItemClass(edit);

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