using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class Class1
    {
    }
    public class DTOHoadon
    {
        private string maHD;
        private DateTime ngaylap;
        private string maDMH;
        private string ghichu;
        private decimal dongia;
        private int soluong;
        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string MaDMH { get => maDMH; set => maDMH = value; }

        public string GhiChu { get => ghichu; set => ghichu = value; }
        public decimal DonGia { get => dongia; set => dongia = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
    }
}
