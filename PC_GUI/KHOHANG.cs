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
    
    public partial class KHOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOHANG()
        {
            this.SANPHAM_XUATKHO = new HashSet<SANPHAM_XUATKHO>();
        }
    
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string LoaiKho { get; set; }
        public string DiaChi { get; set; }
        public string Suc_Chua { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM_XUATKHO> SANPHAM_XUATKHO { get; set; }
    }
}