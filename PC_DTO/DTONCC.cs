using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTONCC
    {
            private string maNCC;
            private string tenNCC;
            private string diaChi;
            private string sDT;
            private string email;
            public string MaNCC { get; set; }
            public string TenNCC { get; set; }
            public string DiaChi { get; set; }
            public string SDT { get; set; }
            public string Email { get; set; }
    }
    public class DTODGNCC
    {
        private string maDGNCC;
        private string maNCC;
        private string maNV;
        private DateTime? ngayDanhGia;
        private Nullable<double> diemChatLuong;
        private Nullable<double> diemHieuQua;
        private Nullable<double> diemGiaCa;
        private string mucDoDanhGia;
        private string tieuChiDanhGia;

        public string MaDGNCC { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public DateTime? NgayDanhGia { get; set; }
        public Nullable<double> DiemChatLuong { get; set; }
        public Nullable<double> DiemHieuQua { get; set; }
        public Nullable<double> DiemGiaCa { get; set; }
        public string MucDoDanhGia { get; set; }
        public string TieuChiDanhGia { get; set; }
    }
    public class DTOMucDo
    {
        private string mucDoDanhGia;
        public string MucDoDanhGia { get; set; }
    }
    public class DTOTieuChiDanhGia
    {
        private string tieuChiDanhGia;
        public string TieuChiDanhGia { get; set; }
    }
    public class DTODSDMH
    {
        private string maDGSP;
        private string maDMH;
        private string maSP;
        private string tenSP;
        public string MaDMH { get; set; }
        public string MaDGSP { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
    }
    public class DTODGDMH
    {
        public string MaDGSP { get; set; }
        public Nullable<System.DateTime> NgayDG { get; set; }
        public string MaSP { get; set; }
        public string MaDMH { get; set; }
        public string MoTaDG { get; set; }
        public Nullable<int> DiemChatLuong { get; set; }
        public Nullable<int> DiemHieuQua { get; set; }
        public Nullable<int> DiemGiaCa { get; set; }
        public string GhiChu { get; set; }
    }
    public class DTOTieuChiSearch
    {
        private string tieuChiDanhGia;
        public string TieuChiDanhGia { get; set; }
    }
    public class DTODGTG
    {
        private string maDGNCC;
        private string maDGSP;
        public string MaDGSP { get; set; }
        public string MaDGNCC { get; set; }
    }
    public class DTODGNCCReport
    {
        private string maDGNCC;
        private string maNCC;
        private string tenNCC;
        private DateTime? ngayDanhGia;
        private Nullable<double> diemChatLuong;
        private Nullable<double> diemHieuQua;
        private Nullable<double> diemGiaCa;
        private string mucDoDanhGia;
        private string tieuChiDanhGia;

        public string MaDGNCC { get; set; }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public DateTime? NgayDanhGia { get; set; }
        public Nullable<double> DiemChatLuong { get; set; }
        public Nullable<double> DiemHieuQua { get; set; }
        public Nullable<double> DiemGiaCa { get; set; }
        public string MucDoDanhGia { get; set; }
        public string TieuChiDanhGia { get; set; }
    }

}
