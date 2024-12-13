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
            if (!dTOKho.MaKho.StartsWith("KHO"))
                throw new ArgumentException("Mã kho phải bắt đầu bằng 'KHO'.");
            if (string.IsNullOrEmpty(dTOKho.TenKho))
                throw new ArgumentException("Tên kho không được để trống.");
            if (string.IsNullOrEmpty(dTOKho.LoaiKho))
                throw new ArgumentException("Loại kho không được để trống.");
            if (dTOKho.SucChuaTanSo <= 0)
                throw new ArgumentException("Sức chứa của kho phải là số hợp lệ lớn hơn 0.");

            dTOKho.SucChua = $"{dTOKho.SucChuaTanSo} tấn";
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
            if (dTOKho.SucChuaTanSo <= 0)
                throw new ArgumentException("Sức chứa của kho phải là số hợp lệ lớn hơn 0.");

            dTOKho.SucChua = $"{dTOKho.SucChuaTanSo} tấn";
            dALKho.SuaKho(dTOKho);
        }
        public void XoaKho(DTOKho dTOKho)
        {
            dALKho.XoaKho(dTOKho);
        }
        public List<DTOKho> TimTuKhoaKho(string tuKhoa)
        {
            return dALKho.TimTuKhoaKho(tuKhoa);
        }
        
        public List<DTOKho> LocKho(string loaiKho, string keyword, int? sucChuaFilter)
        {
            var danhSach = dALKho.LoadKho();

            if (!string.IsNullOrEmpty(loaiKho))
            {
                danhSach = dALKho.TimLoaiKho(loaiKho);
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                danhSach = dALKho.TimTuKhoaKho(keyword);
            }

            if (sucChuaFilter.HasValue)
            {
                switch (sucChuaFilter.Value)
                {
                    case 0: // Bé hơn 80 tấn
                        danhSach = danhSach.Where(kho => kho.SucChuaKg < 80000).ToList();
                        break;
                    case 1: // Từ 80 đến 150 tấn
                        danhSach = danhSach.Where(kho => kho.SucChuaKg >= 80000 && kho.SucChuaKg <= 150000).ToList();
                        break;
                    case 2: // Lớn hơn 150 tấn
                        danhSach = danhSach.Where(kho => kho.SucChuaKg > 150000).ToList();
                        break;
                }
            }

            return danhSach;
        }

    }
}
