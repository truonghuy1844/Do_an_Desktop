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
    
    public partial class YEUCAU_MUAHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YEUCAU_MUAHANG()
        {
            this.CT_YEUCAU = new HashSet<CT_YEUCAU>();
            this.DONMUAHANGs = new HashSet<DONMUAHANG>();
        }
    
        public string MaYC { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> NgayYC { get; set; }
        public Nullable<System.DateTime> NgayDuyet { get; set; }
        public string PhongBanYC { get; set; }
        public string TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_YEUCAU> CT_YEUCAU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONMUAHANG> DONMUAHANGs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
