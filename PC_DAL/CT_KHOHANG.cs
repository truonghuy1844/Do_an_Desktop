//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PC_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_KHOHANG
    {
        public string MaKho { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string LoHang { get; set; }
        public Nullable<System.DateTime> HanDung { get; set; }
    
        public virtual KHOHANG KHOHANG { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
