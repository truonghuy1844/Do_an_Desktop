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
        public void XoaNCC (DTONCC dTONCC)
        {
            dALNCC.XoaNCC(dTONCC);
        }
        public List<DTONCC> TimTuKhoaNCC(string tuKhoa)
        {
           return dALNCC.TimTuKhoaNCC(tuKhoa);
        }
    }
}
