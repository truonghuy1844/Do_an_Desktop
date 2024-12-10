using PC_DTO;
using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.BLL
{
    public class BLL_SanPham
    {
        public DataTable Load_SP()
        {
            DAL_SanPham dal     = new DAL_SanPham();
            return dal.Load_SanPham();
        }
        public bool Them_SP(DTO_SanPham sanPham)
        {
            DAL_SanPham dal = new DAL_SanPham();
            if (sanPham != null || sanPham.MaSanPham == "") return false;
            return dal.Them_SP(sanPham);
        }
        public bool Xoa_SP(DTO_SanPham sanPham)
        {
            DAL_SanPham dal = new DAL_SanPham();
            if (sanPham != null || sanPham.MaSanPham == "") return false;
            return dal.Xoa_SP(sanPham);
        }
        public bool Sua_SP(DTO_SanPham sanPham)
        {
            DAL_SanPham dal = new DAL_SanPham();
            if (sanPham != null || sanPham.MaSanPham == "") return false;
            return dal.Sua_SP(sanPham);
        }
        public bool KiemTra_MaSP(DTO_SanPham sanPham)
        {
            DAL_SanPham dal = new DAL_SanPham();
            if (sanPham == null || sanPham.MaSanPham == "") return false;
            return dal.KiemTraMaSP(sanPham);
        }
    }
}
