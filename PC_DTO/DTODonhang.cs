using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTODonhang
    {
        private string maDMH;
        private DateTime ngaylap;
        private string maHDMH;
        private string maYC;
        private string maNV;
        private string maNCC;
        private decimal chietkhau;
        private string tthai;
        private string mota;

        public string MaDMH { get => maDMH; set => maDMH = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string MaHDMH { get => maHDMH; set => maHDMH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string Tthai { get => tthai; set => tthai = value; }
        public string Mota { get => mota; set => mota = value; }
        public decimal Chietkhau { get => chietkhau; set => chietkhau = value; }
        public string MaYC { get => maYC; set => maYC = value; }
    }
    public class DTOTrangthai
    {
        private string luu;
        private string hienthi;

        public string Luu { get => luu; set => luu = value; }
        public string Hienthi { get => hienthi; set => hienthi = value; }
    }
    public class DTODiemDG
    {
        private int thutu;
        private int diemdg;

        public int Thutu { get => thutu; set => thutu = value; }
        public int Diemdg { get => diemdg; set => diemdg = value; }
    }
}
