using PC_DAL;
using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_BLL
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
    //Chi tiết báo giá
    public class BLL_CT_BaoGia
    {
        public DataTable Load_CT_BG()
        {
            DAL_CT_BaoGia dal = new DAL_CT_BaoGia();
            return dal.Load_CT_BaoGia();
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
}
