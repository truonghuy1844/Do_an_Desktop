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
    
    public partial class HOPDONGMH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONGMH()
        {
            this.DONMUAHANGs = new HashSet<DONMUAHANG>();
        }
    
        public string MaHDMH { get; set; }
        public string MaNV { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public System.DateTime NgayKetThuc { get; set; }
        public string DieuKhoan { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONMUAHANG> DONMUAHANGs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
