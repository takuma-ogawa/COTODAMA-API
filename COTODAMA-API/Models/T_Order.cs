//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace COTODAMA_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Order
    {
        public int ID { get; set; }
        public string ItemFilePath { get; set; }
        public string UserName { get; set; }
        public string TalentName { get; set; }
        public int TotalPrice { get; set; }
        public int OrderLengthTime { get; set; }
        public string OrderFreeTextArea { get; set; }
        public bool CheckFlag { get; set; }
        public string UserRating { get; set; }
        public string TalentRating { get; set; }
        public bool UnlockFlag { get; set; }
        public Nullable<System.DateTime> CheckDatetime { get; set; }
        public System.DateTime RegisterDateTime { get; set; }
        public System.DateTime EditDateTime { get; set; }
        public string OrderID { get; set; }
        public int ItemID { get; set; }
        public int SellerID { get; set; }
        public int OrdererID { get; set; }
    }
}
