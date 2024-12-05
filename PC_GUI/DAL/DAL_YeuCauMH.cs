using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class DAL_YeuCauMH
    {
        //Load dữ liệu
        public DataTable Load_YC_MuaHang()
        {
            QLMHEntities1 cnn = new QLMHEntities1();
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               select new
                               {
                                   MaYC = yc.MaYC,
                                   TenNV = nv.TenNV,
                                   NgayYC = yc.NgayYC,
                                   NgayDuyet = yc.NgayDuyet,
                                   PhongBanYC = yc.PhongBanYC,
                                   TinhTrang = yc.TinhTrang
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaYC", typeof(string));
                dt.Columns.Add("PhongBanYC", typeof(string));
                dt.Columns.Add("TenNV", typeof(string));
                dt.Columns.Add("NgayYC", typeof(DateTime));
                dt.Columns.Add("TinhTrang", typeof(string));
                dt.Columns.Add("NgayDuyet", typeof(DateTime));
                //Thêm vào bảng
                foreach (var item in list_YC)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaYC"] = item.MaYC;
                    dr["PhongBanYC"] = item.PhongBanYC;
                    dr["TenNV"] = item.TenNV;
                    dr["NgayYC"] = item.NgayYC;
                    dr["TinhTrang"] = item.TinhTrang;
                    dr["NgayDuyet"] = item.NgayDuyet;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "NgayYC DESC";
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Lỗi", typeof(string));
                dt.Columns.Add("Chi tiết", typeof(string));
                DataRow dr1 = dt.NewRow();
                dr1["Lỗi"] = ex.Message;
                dr1["Chi tiết"] = ex.InnerException?.Message;
                dt.Rows.Add(dr1);
                return dt;
            }
        }
        //thêm yêu cầu mua hàng
        public bool Them_YeuCauMH(DTO_YeuCauMH ycMH)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            try
            {
                YEUCAU_MUAHANG ycau = new YEUCAU_MUAHANG();
                ycau.MaYC = ycMH.MaYC.Trim();
                ycau.MaNV = ycMH.MaNV.Trim();
                ycau.PhongBanYC = ycMH.PhongBanYC.Trim();


                conn.YEUCAU_MUAHANG.Add(ycau);
                conn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //Sửa Yêu cầu mua hàng
        public bool Sua_YC_MH(DTO_YeuCauMH ycMH)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            YEUCAU_MUAHANG yc = conn.YEUCAU_MUAHANG.Find(ycMH.MaYC.Trim());

            if (yc != null)
            {
                yc.MaNV = ycMH.MaNV.Trim();
                yc.NgayDuyet = ycMH.NgayDuyet;
                yc.PhongBanYC = ycMH.PhongBanYC.Trim();
                yc.TinhTrang = ycMH.TinhTrang.Trim();
                yc.MaYC = ycMH.MaYC;

                try
                {
                    conn.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        //Xóa yêu cầu mua hàng
        public bool Xoa_YC_MH(DTO_YeuCauMH ycMH)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            YEUCAU_MUAHANG yc = conn.YEUCAU_MUAHANG.Find(ycMH.MaYC.Trim());
            if (yc != null)
            {

                try
                {
                    conn.YEUCAU_MUAHANG.Remove(yc);
                    conn.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
    }
    /// <summary>
    /// Chi tiết yêu cầu mua hàng
    /// </summary>
    public class DAL_CT_YeuCau
    {
        //Load dữ liệu
        public DataTable Load_CT_YC_MuaHang()
        {
            QLMHEntities1 cnn = new QLMHEntities1();
            try
            {
                var list_CT_YC = (from yc in cnn.CT_YEUCAU
                                  join sp in cnn.SANPHAMs on yc.MaSP equals sp.MaSP
                               select new
                               {
                                   MaYC = yc.MaYC,
                                   MaSP = yc.MaSP,
                                   TenSP = sp.TenSP,
                                   SoLuong = yc.SoLuong
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaYC", typeof(string));
                dt.Columns.Add("MaSP", typeof(string));
                dt.Columns.Add("TenSP", typeof(string));
                dt.Columns.Add("SoLuong", typeof(int));
                //Thêm vào bảng
                foreach (var item in list_CT_YC)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaYC"] = item.MaYC;
                    dr["MaSP"] = item.MaSP;
                    dr["TenSP"] = item.MaSP;
                    dr["SoLuong"] = item.SoLuong;
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Lỗi", typeof(string));
                dt.Columns.Add("Chi tiết", typeof(string));
                DataRow dr1 = dt.NewRow();
                dr1["Lỗi"] = ex.Message;
                dr1["Chi tiết"] = ex.InnerException?.Message;
                dt.Rows.Add(dr1);
                return dt;
            }
        }
        //thêm CT_yêu cầu mua hàng
        public bool Them_CT_YeuCauMH(DTO_CT_YeuCauMH ct_ycMH)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            try
            {
                CT_YEUCAU ct = new CT_YEUCAU();
                ct.MaYC = ct_ycMH.MaYC.Trim();
                ct.MaSP = ct_ycMH.MaSP.Trim();
                ct.SoLuong = ct_ycMH.SoLuong;


                conn.CT_YEUCAU.Add(ct);
                conn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //Sửa CT_Yêu cầu mua hàng
        public bool Sua_CT_YC_MH(DTO_CT_YeuCauMH ct_ycMH)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            CT_YEUCAU ct = conn.CT_YEUCAU.SingleOrDefault( t => t.MaYC == ct_ycMH.MaYC && t.MaSP == ct_ycMH.MaSP);

            if (ct != null)
            {
                ct.SoLuong = ct_ycMH.SoLuong;
                
                try
                {
                    conn.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        //Xóa toàn bộ CT_yêu cầu mua hàng
        public bool Xoa_ALL_CT_YC_MH(DTO_CT_YeuCauMH ct_ycMH)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            var ct = conn.CT_YEUCAU.Where(item => item.MaYC == ct_ycMH.MaYC).ToList();
            if (ct != null)
            {

                try
                {
                    conn.CT_YEUCAU.RemoveRange(ct);
                    conn.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        public bool Xoa_SP_CT_YC(DTO_CT_YeuCauMH ct_ycMH)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            CT_YEUCAU ct = conn.CT_YEUCAU.SingleOrDefault(t => t.MaYC == ct_ycMH.MaYC && t.MaSP == ct_ycMH.MaSP);

            if (ct != null)
            {
                try
                {
                    conn.CT_YEUCAU.Remove(ct);
                    conn.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
    

