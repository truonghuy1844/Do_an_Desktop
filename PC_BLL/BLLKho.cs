using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;
using PC_DAL;
using System.Text.RegularExpressions;

namespace PC_BLL
{
    public class BLLKho
    {
        DALKho dALKho= new DALKho();
        public List<DTOKho> LoadKho()
        {
            return dALKho.LoadKho();
        }
        public void AddKho(DTOKho dTOKho)
        {
            if (string.IsNullOrEmpty(dTOKho.MaKho))
                throw new ArgumentException("Mã kho không được để trống.");
            if (dTOKho.MaKho.Length != 6)
                throw new ArgumentException("Mã nhân viên phải gồm đúng 6 ký tự.");
            if (string.IsNullOrEmpty(dTOKho.TenKho))
                throw new ArgumentException("Tên kho không được để trống.");
            if (string.IsNullOrEmpty(dTOKho.LoaiKho))
                throw new ArgumentException("Loại kho không được để trống.");
            if (string.IsNullOrEmpty(dTOKho.SucChua))
                throw new ArgumentException("Sức chứa của kho không được để trống.");
            if (!double.TryParse(dTOKho.SucChua.Replace("tấn", "").Trim(), out double sucChuaTons) || sucChuaTons <= 0)
                throw new ArgumentException("Sức chứa của kho phải là số hợp lệ lớn hơn 0.");

            dTOKho.SucChua = $"{sucChuaTons} tấn";
            dALKho.AddKho(dTOKho);
        }
        public List<DTOLoaiKho> LoadLoaiKho()
        {
            return dALKho.LoadLoaiKho();
        }
        public List<DTOKho> TimKho(string maKho)
        {
            return dALKho.TimKho(maKho);
        }
        public void SuaKho(DTOKho dTOKho)
        {
            if (string.IsNullOrEmpty(dTOKho.TenKho))
                throw new ArgumentException("Tên kho không được để trống.");
            if (string.IsNullOrEmpty(dTOKho.LoaiKho))
                throw new ArgumentException("Loại kho không được để trống.");
            if (string.IsNullOrEmpty(dTOKho.SucChua))
                throw new ArgumentException("Sức chứa của kho không được để trống.");
            if (!double.TryParse(dTOKho.SucChua.Replace("tấn", "").Trim(), out double sucChuaTons) || sucChuaTons <= 0)
                throw new ArgumentException("Sức chứa của kho phải là số hợp lệ lớn hơn 0.");

            dTOKho.SucChua = $"{sucChuaTons} tấn";
            dALKho.SuaKho(dTOKho);
        }
        public void XoaKho(DTOKho dTOKho)
        {
            dALKho.XoaKho(dTOKho);
        }
    }
}
