using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTONV
    {
        private string maNV;
        private string tenNV;
        private string diaChi;
        private string gioiTinh;
        private string sDT;
        private string chucVu;
        private string phongBan;
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }
        public string PhongBan { get; set; }
    }
    public class DTOChucVu
    {
        private string chucVu;
        public string ChucVu { get; set; }
    }
    public class DTOPhongBan
    {
        private string phongBan;
        public string PhongBan { get; set; }
    }
}
