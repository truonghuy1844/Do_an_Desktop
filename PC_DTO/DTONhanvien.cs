using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTONhanvien
    {
        private string maNV;
        private string tenNV;
        private string DiaChi;
        private string GioiTinh;
        private string dienthoai;
        private string chucvu;
        private string phongban;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Phongban { get => phongban; set => phongban = value; }
    }
}
