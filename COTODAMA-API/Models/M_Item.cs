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
    
    public partial class M_Item
    {
        public string ItemName { get; set; }
        public string ItemDiscription { get; set; }
        public int ItemPriceUnit { get; set; }
        public Nullable<int> ItemDeliveryDate { get; set; }
        public Nullable<int> ItemStock { get; set; }
        public System.DateTime RegisterDateTime { get; set; }
        public System.DateTime EditDateTime { get; set; }
        public int ItemID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public int MemberID { get; set; }
        public string MemberName { get; set; }
    }
}
