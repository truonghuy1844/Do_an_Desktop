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
    
    public partial class DANHGIA_NCC
    {
        public string MaDGNCC { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public System.DateTime NgayDanhGia { get; set; }
        public Nullable<int> DiemChatLuong { get; set; }
        public Nullable<int> DiemHieuQua { get; set; }
        public Nullable<int> DiemGiaCa { get; set; }
        public string MucDoDanhGia { get; set; }
    
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}