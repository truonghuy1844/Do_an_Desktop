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
    
<<<<<<<< HEAD:PC_GUI/HANGHOA_VANCHUYEN.cs
    public partial class HANGHOA_VANCHUYEN
    {
        public string MaVC { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
========
    public partial class DanhGiaNCC_SPDMH
    {
        public string MaDGNCC { get; set; }
        public string MaDGSP { get; set; }
        public string ChuThich { get; set; }
    
        public virtual DANHGIA_NCC DANHGIA_NCC { get; set; }
        public virtual DANHGIASP_TRONGDON DANHGIASP_TRONGDON { get; set; }
>>>>>>>> origin/QLNCC:PC_DAL/DanhGiaNCC_SPDMH.cs
    }
}
