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
    
    public partial class SANPHAM_XUATKHO
    {
        public string MaSP { get; set; }
        public string MaKho { get; set; }
        public Nullable<int> SoLuongXuat { get; set; }
        public System.DateTime NgayXuat { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
