using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTO_BaoGia
    {
        string maBG;
        string maNCC;
        DateTime ngayBG;

        public string MaBG { get => maBG; set => maBG = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public DateTime NgayBG { get => ngayBG; set => ngayBG = value; }
    }
    public class DTO_CT_BaoGia
    {
        string maBG;
        string maSP;
        int donGia;
        string moTa;

        public string MaBG { get => maBG; set => maBG = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
