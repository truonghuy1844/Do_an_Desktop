using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PC_DAL;
using PC_DTO;

namespace PC_BLL
{
    public class BLLNCC
    {
        DALNCC dALNCC = new DALNCC();
        public List<DTONCC> LoadNCC()
        {
            return dALNCC.LoadNCC();
        }
        public void AddNCC(DTONCC dTONCC)
        {
            if (string.IsNullOrEmpty(dTONCC.MaNCC))
                throw new ArgumentException("Mã nhà cung cấp không được để trống.");
            if (dTONCC.MaNCC.Length != 6)
                throw new ArgumentException("Mã nhà cung cấp phải gồm đúng 6 ký tự.");
            if (string.IsNullOrEmpty(dTONCC.TenNCC))
                throw new ArgumentException("Tên nhà cung cấp không được để trống.");
            if (string.IsNullOrEmpty(dTONCC.SDT))
                throw new ArgumentException("Số điện thoại của nhà cung cấp không được để trống.");
            if (!Regex.IsMatch(dTONCC.SDT, @"^\d{10}$"))
                throw new ArgumentException("Số điện thoại phải là chuỗi số gồm đúng 10 chữ số.");
            dALNCC.AddNCC(dTONCC);
        }
        public List<DTONCC> TimNCC(string maTim)
        {
            if (string.IsNullOrEmpty(maTim))
                throw new ArgumentException("Vui lòng nhập mã nhà cung cấp để tìm kiếm.");

            if (maTim.Length != 6)
                throw new ArgumentException("Mã nhà cung cấp phải gồm đúng 6 ký tự.");
            try
            {
                return dALNCC.TimNCC(maTim);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm nhà cung cấp: " + ex.Message);
            }
        }
        public void SuaNCC(DTONCC dTONCC)
        {
            if (string.IsNullOrEmpty(dTONCC.TenNCC))
                throw new ArgumentException("Tên nhà cung cấp không được để trống.");
            if (string.IsNullOrEmpty(dTONCC.SDT))
                throw new ArgumentException("Số điện thoại của nhà cung cấp không được để trống.");
            if (!Regex.IsMatch(dTONCC.SDT, @"^\d{10}$"))
                throw new ArgumentException("Số điện thoại phải là chuỗi số gồm đúng 10 chữ số.");
            dALNCC.SuaNCC(dTONCC);
        }
        public void XoaNCC(DTONCC dTONCC)
        {
            dALNCC.XoaNCC(dTONCC);
        }
        public List<DTONCC> TimTuKhoaNCC(string tuKhoa)
        {
            return dALNCC.TimTuKhoaNCC(tuKhoa);
        }
        public List<DTODGNCC> LoadDGNCC()
        {
            return dALNCC.LoadDGNCC();
        }
        public List<DTONV> LoadNVDGNCC(string maDanhGia)
        {

            var listNV = dALNCC.LoadNVDGNCC(maDanhGia);
            return listNV ?? new List<DTONV>();
        }
        public List<DTONCC> LoadNCCDG(string maDanhGia)
        {

            var listNCC = dALNCC.LoadNCCDG(maDanhGia);
            return listNCC ?? new List<DTONCC>();
        }
        public void AddDGNCC(DTODGNCC dTODGNCC)
        {
            if (string.IsNullOrEmpty(dTODGNCC.MaDGNCC))
                throw new ArgumentException("Mã đánh giá nhà cung cấp không được để trống.");
            if (dTODGNCC.MaDGNCC.Length != 5)
                throw new ArgumentException("Mã đánh giá nhà cung cấp phải gồm đúng 5 ký tự.");
            if (string.IsNullOrEmpty(dTODGNCC.MaNV))
                throw new ArgumentException("Mã nhân viên đánh giá không được để trống.");
            if (dTODGNCC.MaNV.Length != 5)
                throw new ArgumentException("Mã nhân viên đánh giá phải gồm đúng 5 ký tự.");
            if (string.IsNullOrEmpty(dTODGNCC.MaNCC))
                throw new ArgumentException("Mã nhà cung cấp không được để trống.");
            if (dTODGNCC.MaNCC.Length != 6)
                throw new ArgumentException("Mã nhà cung cấp phải gồm đúng 6 ký tự.");
            dALNCC.AddDGNCC(dTODGNCC);
        }
        public List<DTOChatLuong> LoadDiemChatLuong()
        {
            return dALNCC.LoadDiemChatLuong();
        }
        public List<DTOHieuQua> LoadDiemHieuQua()
        {
            return dALNCC.LoadDiemHieuQua();
        }
        public List<DTOGiaCa> LoadDiemGiaCa()
        {
            return dALNCC.LoadDiemGiaCa();
        }
        public List<DTOMucDo> LoadMucDoDG()
        {
            return dALNCC.LoadMucDoDG();
        }
        public List<DTODGNCC> TimDGNCC(string maTim)
        {
            if (string.IsNullOrEmpty(maTim))
                throw new ArgumentException("Vui lòng nhập mã nhà đánh giá để tìm kiếm.");

            if (maTim.Length != 5)
                throw new ArgumentException("Mã đánh giá phải gồm đúng 5 ký tự.");
            try
            {
                return dALNCC.TimDGNCC(maTim);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm đánh giá: " + ex.Message);
            }
        }
        public void SuaDGNCC(DTODGNCC dTODGNCC)
        {
            if (string.IsNullOrEmpty(dTODGNCC.MaNV))
                throw new ArgumentException("Mã nhân viên đánh giá không được để trống.");
            if (dTODGNCC.MaNV.Length != 5)
                throw new ArgumentException("Mã nhân viên đánh giá phải gồm đúng 5 ký tự.");
            if (string.IsNullOrEmpty(dTODGNCC.MaNCC))
                throw new ArgumentException("Mã nhà cung cấp không được để trống.");
            if (dTODGNCC.MaNCC.Length != 6)
                throw new ArgumentException("Mã nhà cung cấp phải gồm đúng 6 ký tự.");
            dALNCC.SuaDGNCC(dTODGNCC);
        }
        public void XoaDGNCC(DTODGNCC dTODGNCC)
        {
            dALNCC.XoaDGNCC(dTODGNCC);
        }
        public List<DTODGNCC> LocDGNCC(string tuKhoa, int? diemChatLuong, int? diemGiaCa, int? diemHieuQua, string mucDo, DateTime fromDate, DateTime toDate)
        {
            return dALNCC.LocDGNCC(tuKhoa, diemChatLuong, diemGiaCa, diemHieuQua, mucDo, fromDate, toDate);
        }
    }
}
