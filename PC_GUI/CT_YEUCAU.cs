//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PC_GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_YEUCAU
    {
        public string MaYC { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
        public virtual YEUCAU_MUAHANG YEUCAU_MUAHANG { get; set; }
    }
}
