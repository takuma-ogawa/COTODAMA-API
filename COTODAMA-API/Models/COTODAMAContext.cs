using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace COTODAMA_API.Models
{
    public partial class COTODAMAContext:DbContext
    {
        public COTODAMAContext()
    : base("name=COTODAMAContext")
        {
        }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Item> Items { get; set; }


    }
}

