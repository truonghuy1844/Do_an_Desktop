//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.DANHGIA_NCC = new HashSet<DANHGIA_NCC>();
            this.DONMUAHANGs = new HashSet<DONMUAHANG>();
            this.HOPDONGMHs = new HashSet<HOPDONGMH>();
            this.PHANCONG_CONGVIEC = new HashSet<PHANCONG_CONGVIEC>();
            this.YEUCAU_MUAHANG = new HashSet<YEUCAU_MUAHANG>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string ChucVu { get; set; }
        public string PhongBan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIA_NCC> DANHGIA_NCC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONMUAHANG> DONMUAHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONGMH> HOPDONGMHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG_CONGVIEC> PHANCONG_CONGVIEC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YEUCAU_MUAHANG> YEUCAU_MUAHANG { get; set; }
    }
}
