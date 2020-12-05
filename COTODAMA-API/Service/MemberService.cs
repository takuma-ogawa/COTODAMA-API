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

    public class MemberService
    {
        private cotodamaEntities db = new cotodamaEntities();


        public int? RegisterMember(M_Member member)
        {

                if (!this.OverlapEmail(member.MemberEmail))
                {
                    db.M_Member.Add(member.Add());

                    db.SaveChanges();

                    return member.MemberID;

                }
                else
                {
                    return null;

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

        public Boolean OverlapEmail(string email)
        {
            var members = db.M_Member;

            bool is_exsist = false;
            foreach(var i in members)
            {
                if(i.MemberEmail == email)
                {
                    is_exsist = true;
                }
            }

            return is_exsist;
        }

    }
}