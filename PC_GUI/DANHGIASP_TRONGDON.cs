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
    
    public partial class DANHGIASP_TRONGDON
    {
        public string MaDGSP { get; set; }
        public Nullable<System.DateTime> NgayDG { get; set; }
        public string MaSP { get; set; }
        public string MaDMH { get; set; }
        public string MoTaDG { get; set; }
        public Nullable<int> DiemDG { get; set; }
        public string MucdoDG { get; set; }
        public string GhiChu { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
        public virtual DONMUAHANG DONMUAHANG { get; set; }
    }
}
