using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DTO
{
    public class DTO_YeuCauMH
    {
        string maYC;
        string maNV;
        DateTime ngayYC;
        DateTime ngayDuyet;
        string phongBanYC;
        string tinhTrang;

        public string MaYC { get => maYC; set => maYC = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayYC { get => ngayYC; set => ngayYC = value; }
        public DateTime NgayDuyet { get => ngayDuyet; set => ngayDuyet = value; }
        public string PhongBanYC { get => phongBanYC; set => phongBanYC = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
    public class DTO_CT_YeuCauMH
    {
        string maYC;
        string maSP;
        int soLuong;

        public string MaYC { get => maYC; set => maYC = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
