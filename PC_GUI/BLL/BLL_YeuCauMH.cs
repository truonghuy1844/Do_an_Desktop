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
    /// <summary>
    /// Yêu cầu mua hàng
    /// </summary>
    public class BLL_YeuCauMH
    {
        //Load dữ liệu
        public DataTable Load_YC_MH()
        {
            DAL_YeuCauMH dal =new DAL_YeuCauMH();
            return dal.Load_YC_MuaHang();
        }
        ///Thêm mới Yêu cầu mua hàng
        ///
        public bool Them_YCMH(DTO_YeuCauMH yc)
        {
            if (yc.MaYC != "") 
            {
                DAL_YeuCauMH dal = new DAL_YeuCauMH();
                return dal.Them_YeuCauMH(yc);
            }
            return false;
        }
        //Sua Yêu cầu mua hàng
        public bool Sua_YCMH(DTO_YeuCauMH yc)
        {
            if (yc.MaYC != "")
            {
                DAL_YeuCauMH dal = new DAL_YeuCauMH();
                return dal.Them_YeuCauMH(yc) ;
            }
            return false;
        }
        ///Xoa Yêu cầu mua hàng
        public bool Xoa_YCMH(DTO_YeuCauMH yc) 
        { 
            if(yc.MaYC != "")
            {
                DAL_YeuCauMH dal = new DAL_YeuCauMH() ;
                return dal.Xoa_YC_MH(yc);
            }
            return false;
        }
    }
    
    ///
    /// Chi tiets Yêu cầu
    ///
    public class BLL_CT_YCMH
    {

        //Load dữ liệu
        public DataTable Load_CT_YC_MH()
        {
            DAL_CT_YeuCau dal = new DAL_CT_YeuCau();
            return dal.Load_CT_YC_MuaHang();
        }
        ///Thêm mới CT_Yêu cầu mua hàng
        ///
        public bool Them_CT_YCMH(DTO_CT_YeuCauMH ct)
        {
            if (ct.MaYC != "" && ct.MaSP != "")
            {
                DAL_CT_YeuCau dal = new DAL_CT_YeuCau();
                return dal.Them_CT_YeuCauMH(ct);
            }
            return false;
        }
        //Sua CT_Yêu cầu mua hàng
        public bool Sua_CT_YCMH(DTO_CT_YeuCauMH ct)
        {
            if (ct.MaYC != "" && ct.MaSP != "")
            {
                DAL_CT_YeuCau dal = new DAL_CT_YeuCau();
                return dal.Sua_CT_YC_MH(ct);
            }
            return false;
        }
        ///Xoa Toàn bộ CT_Yêu cầu mua hàng
        public bool Xoa_ALL_CT_YCMH(DTO_CT_YeuCauMH ct)
        {
            if (ct.MaYC != "")
            {
                DAL_CT_YeuCau dal = new DAL_CT_YeuCau();
                return dal.Xoa_ALL_CT_YC_MH(ct);
            }
            return false;
        }
        public bool Xoa_SP_CT_YCMH(DTO_CT_YeuCauMH ct) 
        {
            if (ct.MaYC != "" && ct.MaSP != "")
            {
                DAL_CT_YeuCau dal = new DAL_CT_YeuCau();
                return dal.Xoa_SP_CT_YC(ct);
            }
            return false;
        }
    }

}
