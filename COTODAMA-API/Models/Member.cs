using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COTODAMA_API.Models
    {
    [Table("M_Members")]
    public class Member
        {
        public string MemberId { get; set; }
        public int ID { get; set; }
        public string MemberPref { get; set; }
        public string MemberAddress { get; set; }
        public string MemberPostNumber { get; set; }

        public string MemberPhone { get; set; }
        public DateTime MemberBirth { get; set; }
        public string MemberFirstName { get; set; }

        public string MemberLastName { get; set; }

        public string MemberFirstNameKana { get; set; }
        public string MemberLastNameKana { get; set; }

        public string CompanyName { get; set; }
        public string CompanyPostNumber { get; set; }
        public string CompanyAddress { get; set; }


        public string BankNumber { get; set; }
        public string BankBranchNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string HundleName { get; set; }
        public string BankAccountName { get; set; }
        public string IconFilepath { get; set; }

        public DateTime RegisterDateTime { get; set; }
        public DateTime EditDateTime { get; set; }

        }
    }