using PC_DTO;
using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public bool KiemTra_TT_Duyet(DTO_YeuCauMH dTO_YeuCauMH)
        {
            DAL_YeuCauMH dal = new DAL_YeuCauMH();
            if (dTO_YeuCauMH.MaYC == "" || dTO_YeuCauMH.MaYC == null) return false;
            return dal.Kiem_Tra_TT_Duyet(dTO_YeuCauMH);
        }
        //Kiểm tra mãYC
        public bool Kiem_Tra_MaYC(DTO_YeuCauMH dto_YCMH)
        {
            DAL_YeuCauMH dal = new DAL_YeuCauMH();
            if (dto_YCMH.MaYC == "" || dto_YCMH.MaYC == null) return false;
            return dal.Kiem_Tra_MaYC(dto_YCMH);
        }
        //Lấy giá ước tính
        public double Gia_Uoc_Tinh(DTO_YeuCauMH dto)
        {
            DAL_YeuCauMH dal = new DAL_YeuCauMH();
            return dal.Lay_DonGia_SP(dto);
        }
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
                return dal.Sua_YC_MH(yc) ;
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
        public bool Duyet_YCMH(DTO_YeuCauMH yc)
        {
            if (yc.MaYC != "")
            {
                DAL_YeuCauMH dal = new DAL_YeuCauMH();
                return dal.Duyet_YC_MH(yc);
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
        public DataTable Load_CT_YC_MH(DTO_CT_YeuCauMH dto)
        {
            DAL_CT_YeuCau dal = new DAL_CT_YeuCau();
            return dal.Load_CT_YC_MuaHang(dto);
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
    public class Loc_YCMH
    {
        public DataTable Loc_YC_TG(DateTime start, DateTime end)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Loc_YC_TG(start, end);
        }
        public DataTable Loc_YC_TG_TT(DateTime start, DateTime end, DTO_YeuCauMH dto)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Loc_YC_TG_TT(start, end, dto);
        }
        public DataTable Loc_YC_TG_PB(DateTime start, DateTime end, DTO_YeuCauMH dto)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Loc_YC_TG_PB(start, end, dto);
        }
        public DataTable Loc_YC_TG_TT_PB(DateTime start, DateTime end, DTO_YeuCauMH dto)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Loc_YC_TG_PB_TT(start, end, dto);
        }
        public DataTable Loc_YC_TT( DTO_YeuCauMH dto)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Loc_YC_TT( dto);
        }
        public DataTable Loc_YC_PB(DTO_YeuCauMH dto)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Loc_YC_PB(dto);
        }
        public DataTable Loc_YC_TT_PB(DTO_YeuCauMH dto)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Loc_YC_TT_PB(dto);
        }

        //Lấy số lượng ct sp trong yêu cầu
        public int Count_CT_YC(DTO_YeuCauMH dto)
        {
            DAL_Loc_YC dal = new DAL_Loc_YC();
            return dal.Count_CT_YC(dto);
        }

       
    }

}
