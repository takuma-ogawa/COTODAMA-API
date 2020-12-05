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
    public class MemberRepository
    {
        private cotodamaEntities db = new cotodamaEntities();

        public M_Member GetMemberByID(int MemberID)
        {
            return db.M_Member.Find(MemberID);
        }
        
    }


    public static class MemberRepositoryStatic
    {
        public static M_Member Add(this M_Member member)
        {
            member.RegisterDateTime = DateTime.UtcNow.AddHours(9);
            member.EditDateTime = DateTime.UtcNow.AddHours(9);

            //初期は出品者じゃないとして扱う
            member.IsSeller = false;
            member.IconFilepath = "";

            return member;
        }


        public static M_Member Edit(this M_Member old,M_Member edit)
        {
            old.BankNumber = edit.BankNumber;
            old.BankBranchNumber = edit.BankBranchNumber;
            old.BankAccountNumber = edit.BankAccountNumber;
            old.HundleName = edit.HundleName;
            old.BankAccountName = edit.BankAccountName;
            old.IconFilepath = edit.IconFilepath;
            old.TokenID = edit.TokenID;
            old.TalentComment = edit.TalentComment;
            old.TwitterURL = edit.TwitterURL;
            old.InstaURL = edit.InstaURL;
            old.FBURL = edit.FBURL;
            old.MemberEmail = edit.MemberEmail;
            old.Password = edit.Password;
            old.IsSeller = edit.IsSeller;
            old.EditDateTime = DateTime.UtcNow.AddHours(9);

            return old;
        }

    }

}