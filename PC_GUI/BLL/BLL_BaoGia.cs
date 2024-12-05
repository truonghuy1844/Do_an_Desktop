using PC_DTO;
using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.BLL
{
    public class BLL_BaoGia
    {
        //Load dữ liệu
        public DataTable Load_BaoGia()
        {
            DAL_BaoGia dal = new DAL_BaoGia();
            return dal.Load_BaoGia();
        }
        public bool Xoa_BaoGia(DTO_BaoGia baoGia)
        {
            if (baoGia.MaBG == "")
            {
                return false;
            }
            DAL_BaoGia dAL = new DAL_BaoGia();
            return dAL.Xoa_BG(baoGia);
        }
        public bool Them_BaoGia(DTO_BaoGia baoGia)
        {
            if (baoGia.MaBG == "")
            {
                return false;
            }
            DAL_BaoGia dAL = new DAL_BaoGia();
            return dAL.Them_BG(baoGia);
        }
        public bool Sua_BaoGia(DTO_BaoGia baoGia)
        {
            if (baoGia.MaBG == "")
            {
                return false;
            }
            DAL_BaoGia dAL = new DAL_BaoGia();
            return dAL.Sua_BG(baoGia);
        }
    }



    /// <summary>
    /// /Chi tiết báo giá
    /// </summary>
    public class BLL_CT_BaoGia
    {
        public DataTable Load_CT_BG(DTO_CT_BaoGia ct_bg)
        {
            DAL_CT_BaoGia dal = new DAL_CT_BaoGia();
            DTO_CT_BaoGia ct = ct_bg;
            return dal.Load_CT_BaoGia(ct);
        }
        public bool Them_CT_BG(DTO_CT_BaoGia cT_BaoGia)
        {
            DAL_CT_BaoGia dal = new DAL_CT_BaoGia();
            return dal.Them_CT_BaoGia(cT_BaoGia);
        }
        public bool Sua_CT_BG(DTO_CT_BaoGia cT_BaoGia)
        {
            if (cT_BaoGia.MaSP == "" || cT_BaoGia.MaBG == "")
            {
                return false;
            }
            DAL_CT_BaoGia dal = new DAL_CT_BaoGia();
            return dal.Sua_CT_BG(cT_BaoGia);
        }
        public bool Xoa_SP_CT_BG(DTO_CT_BaoGia cT_BaoGia)
        {
            if (cT_BaoGia.MaSP == "" || cT_BaoGia.MaBG == "")
            {
                return false;
            }
            DAL_CT_BaoGia dal = new DAL_CT_BaoGia();
            return dal.Xoa_SP_CT_BG(cT_BaoGia);
        }
        public bool Xoa_CT_BG(DTO_CT_BaoGia cT_BaoGia)
        {
            if (cT_BaoGia.MaBG == "")
            {
                return false;
            }
            DAL_CT_BaoGia dal = new DAL_CT_BaoGia();
            return dal.Xoa_CT_BG(cT_BaoGia);
        }

    }
    ///Lọc báo giá
    ///
    public class Loc_Bao_Gia
    {
        public DataTable Loc_BG(DTO_BaoGia bgia, DTO_CT_BaoGia ctiet, DateTime start, DateTime end)
        {
            DAL_Loc_BaoGia dal = new DAL_Loc_BaoGia();
            if (bgia.MaNCC == "0" && ctiet.MaSP == "0")
            {
                return dal.Load_Loc_NT(start, end);
            }
            if (bgia.MaNCC == "0" && ctiet.MaSP != "0") return dal.Load_Loc_SP(ctiet,start,end);
            return dal.Load_Loc_NCC(bgia, start,end);

        }
    }
}
