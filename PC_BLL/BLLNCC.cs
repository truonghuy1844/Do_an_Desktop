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
            if (!dTONCC.MaNCC.StartsWith("NCC"))
                throw new ArgumentException("Mã nhà cung cấp phải bắt đầu bằng 'NCC'.");
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
        public void AddDGNCC(DTODGNCC dTODGNCC, string maNCC, List<string> listDGSP, DateTime? frmDate, DateTime? toDate)
        {
            if (string.IsNullOrEmpty(dTODGNCC.MaDGNCC))
                throw new ArgumentException("Mã đánh giá nhà cung cấp không được để trống.");
            if (!dTODGNCC.MaDGNCC.StartsWith("DG"))
                throw new ArgumentException("Mã đánh giá nhà cung cấp phải bắt đầu bằng 'DG'.");
            if (string.IsNullOrEmpty(dTODGNCC.MaNV))
                throw new ArgumentException("Mã nhân viên đánh giá không được để trống.");
            if (!dTODGNCC.MaNV.StartsWith("NV"))
                throw new ArgumentException("Mã nhân viên đánh giá phải bắt đầu bằng 'NV'.");
            if (string.IsNullOrEmpty(dTODGNCC.MaNCC))
                throw new ArgumentException("Mã nhà cung cấp không được để trống.");
            if (!dTODGNCC.MaNCC.StartsWith("NCC"))
                throw new ArgumentException("Mã nhà cung cấp phải bắt đầu bằng 'NCC'.");
            if (string.IsNullOrEmpty(dTODGNCC.TieuChiDanhGia))
                throw new ArgumentException("Vui lòng chọn tiêu chí đánh giá để tiến hành đánh giá");
            dALNCC.AddDGNCC(dTODGNCC, maNCC, listDGSP, frmDate, toDate);
        }
        
        public List<DTOTieuChiDanhGia> LoadTieuChi()
        {
            return dALNCC.LoadTieuChi();
        }
        public List<DTOTieuChiSearch> TieuChiSearch()
        {
            return dALNCC.TieuChiSearch();
        }
        public List<DTODSDMH> LoadTieuChiDMH(string maNCC)
        {
                return dALNCC.LoadTieuChiDMH(maNCC);
        }

        public List<DTOMucDo> LoadMucDoDG()
        {
            return dALNCC.LoadMucDoDG();
        }
        public List<DTODGNCC> TimDGNCC(string maTim)
        {
            if (string.IsNullOrEmpty(maTim))
                throw new ArgumentException("Vui lòng nhập mã nhà đánh giá để tìm kiếm.");

            if (!maTim.StartsWith("DG"))
                throw new ArgumentException("Mã đánh giá nhà cung cấp phải bắt đầu bằng 'DG'.");
            try
            {
                return dALNCC.TimDGNCC(maTim);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm đánh giá: " + ex.Message);
            }
        }
        public List<DTODGNCC> LocDGNCC(string tuKhoa, string mucDo, DateTime fromDate, DateTime toDate, List<string> tieuChiDanhGia)
        {
            return dALNCC.LocDGNCC(tuKhoa, mucDo, fromDate, toDate, tieuChiDanhGia);
        }
        public List<DTODSDMH> LoadDMHChon(string maDGNCC)
        {
            return dALNCC.LoadDMHChon(maDGNCC);
        }
        public void AddDGNCC_SPDMH(string maDGNCC,string maNCC, List<string> listDGSP, DateTime? frmDate, DateTime? toDate)
        {
            dALNCC.AddDGNCC_SPDMH(maDGNCC, maNCC, listDGSP, frmDate, toDate);
        }
        public void XoaDGNCC(string maDGNCC, List<string> listDGSP)
        {
            dALNCC.XoaDGNCC(maDGNCC, listDGSP);
        }
        public List<DTODGDMH> LoadDGDMH(string maDGNCC)
        {
            return dALNCC.LoadDGDMH(maDGNCC);
        }
        public List<DTODGNCCReport> LoadDGNCCReport()
        {
            return dALNCC.LoadDGNCCReport();
        }
    }
}
