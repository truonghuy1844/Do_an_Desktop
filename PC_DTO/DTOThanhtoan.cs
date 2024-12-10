using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTOThanhtoan
    {
        private string maTT;
        private DateTime ngayTT;
        private string maHD;
        private decimal sotien;
        private string  trangthai;
        public string MaTT { get => maTT; set => maTT = value; }
        public DateTime NgayTT { get => ngayTT;set => ngayTT = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public decimal  SoTien { get => sotien; set => sotien = value; }
        public string TrangThai { get => trangthai;set=> trangthai = value; }

    } 
}
