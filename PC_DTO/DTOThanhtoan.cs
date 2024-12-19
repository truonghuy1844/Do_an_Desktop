using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTOThanhtoan
    {
        private  string maTT;
        private  DateTime ngayTT;
        private  int maHD;
       
        private string  trangthai;
        public string MaTT { get => maTT; set => maTT = value; }
        public DateTime NgayTT { get => ngayTT;set => ngayTT = value; }
        
        public string TrangThai { get => trangthai;set=> trangthai = value; }
        public int MaHD { get => maHD; set => maHD = value; }
    }
    public class DTOHoadon
    {
        private int maHD;
        private DateTime ngaylap;
        private string maDMH;
        private string ghichu;
        private decimal dongia;
        private int soluong;
        
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string MaDMH { get => maDMH; set => maDMH = value; }

        public string GhiChu { get => ghichu; set => ghichu = value; }
        public decimal DonGia { get => dongia; set => dongia = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
        public int MaHD { get => maHD; set => maHD = value; }
    }

}
