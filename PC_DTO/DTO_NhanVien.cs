using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTO_NhanVien
    {
        string maNV;
        string tenNV;
        string diaChi;
        string gioiTinh;
        string dienThoai;
        string chucVu;
        string phongBan;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
    }
}
