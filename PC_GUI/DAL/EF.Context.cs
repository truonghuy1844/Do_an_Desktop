﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PC_GUI.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLMHEntities4 : DbContext
    {
        public QLMHEntities4()
            : base("name=QLMHEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BAOGIA> BAOGIAs { get; set; }
        public virtual DbSet<CT_BAOGIA> CT_BAOGIA { get; set; }
        public virtual DbSet<CT_DONMUAHANG> CT_DONMUAHANG { get; set; }
        public virtual DbSet<CT_YEUCAU> CT_YEUCAU { get; set; }
        public virtual DbSet<DANHGIA_NCC> DANHGIA_NCC { get; set; }
        public virtual DbSet<DanhGiaNCC_SPDMH> DanhGiaNCC_SPDMH { get; set; }
        public virtual DbSet<DANHGIASP_TRONGDON> DANHGIASP_TRONGDON { get; set; }
        public virtual DbSet<DONMUAHANG> DONMUAHANGs { get; set; }
        public virtual DbSet<HANGHOA_VANCHUYEN> HANGHOA_VANCHUYEN { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<HOPDONGMH> HOPDONGMHs { get; set; }
        public virtual DbSet<KHOHANG> KHOHANGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHANCONG_CONGVIEC> PHANCONG_CONGVIEC { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SANPHAM_XUATKHO> SANPHAM_XUATKHO { get; set; }
        public virtual DbSet<THANHTOAN> THANHTOANs { get; set; }
        public virtual DbSet<YEUCAU_MUAHANG> YEUCAU_MUAHANG { get; set; }
    }
}
