using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTO_SanPham
    {
        string maSanPham;
        string tenSanPham;
        string loaiSanPham;
        string dVT;

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string LoaiSanPham { get => loaiSanPham; set => loaiSanPham = value; }
        public string DVT { get => dVT; set => dVT = value; }
    }
}
