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
    
    public partial class T_Sale
    {
        public int SaleID { get; set; }
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int OrdererID { get; set; }
        public int SellerID { get; set; }
        public string UserName { get; set; }
        public string TalentName { get; set; }
        public int TotalPrice { get; set; }
        public int OrderLengthTime { get; set; }
        public string OrderFreeTextArea { get; set; }
        public string UserRating { get; set; }
        public string TalentRating { get; set; }
    }
}
