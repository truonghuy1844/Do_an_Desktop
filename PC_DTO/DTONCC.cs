﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        private Nullable<int> diemChatLuong;
        private Nullable<int> diemHieuQua;
        private Nullable<int> diemGiaCa;
        private string mucDoDanhGia;

        public string MaDGNCC { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public DateTime? NgayDanhGia { get; set; }
        public Nullable<int> DiemChatLuong { get; set; }
        public Nullable<int> DiemHieuQua { get; set; }
        public Nullable<int> DiemGiaCa { get; set; }
        public string MucDoDanhGia { get; set; }
    }
    public class DTOChatLuong
    {
        private int diemChatLuong;
        public int DiemChatLuong { get; set; }
    }
    public class DTOHieuQua
    {
        private int diemHieuQua;
        public int DiemHieuQua { get; set; }
    }
    public class DTOGiaCa
    {
        private int diemGiaCa;
        public int DiemGiaCa { get; set; }
    }
    public class DTOMucDo
    {
        private string mucDoDanhGia;
        public string MucDoDanhGia { get; set; }
    }

}
