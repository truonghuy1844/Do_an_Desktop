using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;
using PC_DAL;
using System.Data;
using System.Text.RegularExpressions;

namespace PC_BLL
{
    public class BLLNV
    {
        DALNV dALNV = new DALNV();
        public List<DTONV> LoadNVBlL()
        {
            return dALNV.LoadNV();
        }
       public List<DTOChucVu> LoadChucVu()
        {
            return dALNV.LoadChucVu();
        }
        public List<DTOPhongBan> LoadPhongBan()
        {
            return dALNV.LoadPhongBan();
        }
        public void AddNhanVien(DTONV dTONV)
        {
            if (string.IsNullOrEmpty(dTONV.MaNV))
                throw new ArgumentException("Mã nhân viên không được để trống.");
            if (dTONV.MaNV.Length != 5)
                throw new ArgumentException("Mã nhân viên phải gồm đúng 5 ký tự.");
            if (string.IsNullOrEmpty(dTONV.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống.");
            if (string.IsNullOrEmpty(dTONV.SDT))
                throw new ArgumentException("Số điện thoại của nhân viên không được để trống.");
            if (!Regex.IsMatch(dTONV.SDT, @"^\d{10}$"))
                throw new ArgumentException("Số điện thoại phải là chuỗi số gồm đúng 10 chữ số.");
            if (string.IsNullOrEmpty(dTONV.GioiTinh))
                throw new ArgumentException("Giới tính của nhân viên không được để trống.");
            if (string.IsNullOrEmpty(dTONV.ChucVu))
                throw new ArgumentException("Chức vụ của nhân viên không được để trống.");
            if (string.IsNullOrEmpty(dTONV.PhongBan))
                throw new ArgumentException("Phòng ban của nhân viên không được để trống.");
            dALNV.AddNV(dTONV);
        }
        public List<DTONV> TimNV(string maNV)
        {
            return dALNV.TimNhanVien(maNV);
        }
        public void SuaNV(DTONV dTONV)
        {
            if (string.IsNullOrEmpty(dTONV.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống.");
            if (string.IsNullOrEmpty(dTONV.SDT))
                throw new ArgumentException("Số điện thoại của nhân viên không được để trống.");
            if (!Regex.IsMatch(dTONV.SDT, @"^\d{10}$"))
                throw new ArgumentException("Số điện thoại phải là chuỗi số gồm đúng 10 chữ số.");
            if (string.IsNullOrEmpty(dTONV.GioiTinh))
                throw new ArgumentException("Giới tính của nhân viên không được để trống.");
            if (string.IsNullOrEmpty(dTONV.ChucVu))
                throw new ArgumentException("Chức vụ của nhân viên không được để trống.");
            if (string.IsNullOrEmpty(dTONV.PhongBan))
                throw new ArgumentException("Phòng ban của nhân viên không được để trống.");
            dALNV.SuaNV(dTONV);
        }    
        public void XoaNV(DTONV dTONV)
        {
            dALNV.XoaNV(dTONV);
        }
        public List<DTONV> TimNVCV(string maNV, string chucVu)
        {
            return dALNV.TimNhanVienChucVu(maNV, chucVu);
        }
        public List<DTONV> TimNVPB(string maNV, string phongBan)
        {
            return dALNV.TimNhanVienPhongBan(maNV, phongBan);
        }
        public List<DTONV> TimNVCVPB(string maNV, string chucVu, string phongBan)
        {
            return dALNV.TimNhanVienChucVuVaPhongBan(maNV, chucVu, phongBan);
        }
        public List<DTONV> TimCVPB(string chucVu, string phongBan)
        {
            return dALNV.TimChucVuVaPhongBan(chucVu, phongBan);
        }
        public List<DTONV> TimCV(string chucVu)
        {
            return dALNV.TimChucVu(chucVu);
        }
        public List<DTONV> TimPB(string phongBan)
        {
            return dALNV.TimPhongBan(phongBan);
        }
    }
}
