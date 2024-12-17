using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_GUI.DAL
{
    
    public class DAL_YeuCauMH 
    {
        /// Kiểm tra mã yêu cầu
        /// 
        public bool Kiem_Tra_MaYC(DTO_YeuCauMH dTO_YeuCauMH)
        {
            QLMHEntities3 conn = new QLMHEntities3();


            YEUCAU_MUAHANG bg = conn.YEUCAU_MUAHANG.Find(dTO_YeuCauMH.MaYC.Trim());
            if (bg != null) return false;
            return true;
        }
        public bool Kiem_Tra_TT_Duyet(DTO_YeuCauMH dTO_YeuCauMH)
        {
            QLMHEntities3 conn = new QLMHEntities3();


            YEUCAU_MUAHANG bg = conn.YEUCAU_MUAHANG.FirstOrDefault(s => s.MaYC == dTO_YeuCauMH.MaYC && s.TinhTrang != "Chờ duyệt");
            if (bg != null) return false;
            return true;
        }
        //Lấy giá thấp nhất từ báo giá
        public double Lay_DonGia_SP(DTO_YeuCauMH dto)
        {
            QLMHEntities3 context = new QLMHEntities3();
            YEUCAU_MUAHANG ycmh = new YEUCAU_MUAHANG();
            ycmh.MaYC = dto.MaYC;
            var oneYearAgo = DateTime.Now.AddYears(-1);
            try
            {
                // Truy vấn con: Tìm MIN(DonGia) theo MaSP
                var minDonGiaQuery = from ct_bg in context.CT_BAOGIA
                                     join bg in context.BAOGIAs on ct_bg.MaBG equals bg.MaBG
                                     where bg.NgayBG > oneYearAgo
                                     group ct_bg by ct_bg.MaSP into grouped
                                     select new
                                     {
                                         MaSP = grouped.Key,
                                         DonGia = grouped.Min(x => x.DonGia)
                                     };

                // Truy vấn chính: Tính SUM(DonGia * SoLuong)
                var total = (from ct in context.CT_YEUCAU
                             join t1 in minDonGiaQuery on ct.MaSP equals t1.MaSP
                             where ct.MaYC == ycmh.MaYC
                             select (t1.DonGia * ct.SoLuong)).Sum();
                return (double)total;
            }
            catch (Exception ) { return -1; }
            
        }
        //Load dữ liệu
        public DataTable Load_YC_MuaHang()
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               select new
                               {
                                   MaYC = yc.MaYC,
                                   MaNV = yc.MaNV,
                                   TenNV = nv.TenNV,
                                   NgayYC = yc.NgayYC,
                                   NgayDuyet = yc.NgayDuyet,
                                   PhongBanYC = yc.PhongBanYC,
                                   TinhTrang = yc.TinhTrang
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaYC", typeof(string));
                dt.Columns.Add("PhongBanYC", typeof(string));
                dt.Columns.Add("MaNV", typeof(string));
                dt.Columns.Add("TenNV", typeof(string));
                dt.Columns.Add("NgayYC", typeof(DateTime));
                dt.Columns.Add("TinhTrang", typeof(string));
                dt.Columns.Add("NgayDuyet", typeof(DateTime));
                //Thêm vào bảng
                foreach (var item in list_YC)
                {

                    DataRow dr = dt.NewRow();
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["MaNV"] = item.MaNV ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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
            QLMHEntities3 conn = new QLMHEntities3();
            try
            {
                YEUCAU_MUAHANG ycau = new YEUCAU_MUAHANG();
                ycau.MaYC = ycMH.MaYC.Trim();
                ycau.MaNV = ycMH.MaNV.Trim();
                ycau.PhongBanYC = ycMH.PhongBanYC.Trim();
                ycau.NgayYC = ycMH.NgayYC;
                ycau.TinhTrang = ycMH.TinhTrang;


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
            QLMHEntities3 conn = new QLMHEntities3();
            YEUCAU_MUAHANG yc = conn.YEUCAU_MUAHANG.Find(ycMH.MaYC.Trim());

            if (yc != null)
            {
                yc.MaNV = ycMH.MaNV.Trim();              
                yc.PhongBanYC = ycMH.PhongBanYC.Trim();
                
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
            QLMHEntities3 conn = new QLMHEntities3();
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
        //đồng ý duyệt
        public bool Duyet_YC_MH(DTO_YeuCauMH ycMH)
        {
            QLMHEntities3 conn = new QLMHEntities3();
            YEUCAU_MUAHANG yc = conn.YEUCAU_MUAHANG.Find(ycMH.MaYC.Trim());

            if (yc != null)
            {

                yc.NgayDuyet = ycMH.NgayDuyet;
                yc.TinhTrang = ycMH.TinhTrang.Trim();


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
    }
    /// <summary>
    /// Chi tiết yêu cầu mua hàng
    /// </summary>
    public class DAL_CT_YeuCau
    {
        //Load dữ liệu
        public DataTable Load_CT_YC_MuaHang(DTO_CT_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            CT_YEUCAU ct_yc = new CT_YEUCAU();
            ct_yc.MaYC = dto.MaYC;
            try
            {
                var list_CT_YC = (from yc in cnn.CT_YEUCAU
                                  join sp in cnn.SANPHAMs on yc.MaSP equals sp.MaSP
                                  where yc.MaYC == ct_yc.MaYC
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["MaSP"] = item.MaSP ?? string.Empty;
                    dr["TenSP"] = item.TenSP ?? string.Empty;

                    // Handle null values for integer column
                    dr["SoLuong"] = item.SoLuong ?? 0;
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
            QLMHEntities3 conn = new QLMHEntities3();
            CT_YEUCAU spham = conn.CT_YEUCAU.FirstOrDefault(s => s.MaYC == ct_ycMH.MaYC && s.MaSP == ct_ycMH.MaSP);
            if (spham == null)
            {
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
            else
            {
                try
                {
                    spham.SoLuong += ct_ycMH.SoLuong;
                    conn.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
            

        }
        //Sửa CT_Yêu cầu mua hàng
        public bool Sua_CT_YC_MH(DTO_CT_YeuCauMH ct_ycMH)
        {
            QLMHEntities3 conn = new QLMHEntities3();
            CT_YEUCAU ct = conn.CT_YEUCAU.SingleOrDefault(t => t.MaYC == ct_ycMH.MaYC && t.MaSP == ct_ycMH.MaSP);

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
            QLMHEntities3 conn = new QLMHEntities3();
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
            QLMHEntities3 conn = new QLMHEntities3();
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

    //Lọc
    public class DAL_Loc_YC
    {
       // Locj chỉ thời gian
        public DataTable Loc_YC_TG(DateTime start, DateTime end)
        {
            DateTime s = start;
            DateTime e = end;
            QLMHEntities3 cnn = new QLMHEntities3();
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               where yc.NgayYC >= s && yc.NgayYC <= e
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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
        //Locj theo tình trạng duyệt, TG
        public DataTable Loc_YC_TG_TT(DateTime start, DateTime end, DTO_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            DateTime s = start;
            DateTime e = end;
            YEUCAU_MUAHANG ycmh = new YEUCAU_MUAHANG();
            ycmh.TinhTrang = dto.TinhTrang;
            ycmh.PhongBanYC = dto.PhongBanYC;
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               where yc.NgayYC >= s && yc.NgayYC <= e && yc.TinhTrang == ycmh.TinhTrang.Trim()
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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

        //Lọc theo TG, Phòng ban yêu cầu
        public DataTable Loc_YC_TG_PB(DateTime start, DateTime end, DTO_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            DateTime s = start;
            DateTime e = end;
            YEUCAU_MUAHANG ycmh = new YEUCAU_MUAHANG();
            ycmh.TinhTrang = dto.TinhTrang;
            ycmh.PhongBanYC = dto.PhongBanYC;
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               where yc.NgayYC >= s && yc.NgayYC <= e && yc.PhongBanYC == ycmh.PhongBanYC
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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
        // Lọc theo TG,PB,TT
        public DataTable Loc_YC_TG_PB_TT(DateTime start, DateTime end, DTO_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
           
            DateTime s = start;
            DateTime e = end;
            YEUCAU_MUAHANG ycmh = new YEUCAU_MUAHANG();
            ycmh.TinhTrang = dto.TinhTrang;
            ycmh.PhongBanYC = dto.PhongBanYC;
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               where yc.NgayYC >= s && yc.NgayYC <= e && yc.PhongBanYC == ycmh.PhongBanYC && yc.TinhTrang == ycmh.TinhTrang
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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

        //Lọc theo TÍnh tragnj
        public DataTable Loc_YC_TT( DTO_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            YEUCAU_MUAHANG ycmh = new YEUCAU_MUAHANG();
            ycmh.TinhTrang = dto.TinhTrang;
            ycmh.PhongBanYC = dto.PhongBanYC;
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               where  yc.PhongBanYC == ycmh.PhongBanYC.Trim()
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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
        //Lọc theo Phòng ban yêu cầu
        public DataTable Loc_YC_PB( DTO_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            YEUCAU_MUAHANG ycmh = new YEUCAU_MUAHANG();
            ycmh.TinhTrang = dto.TinhTrang;
            ycmh.PhongBanYC = dto.PhongBanYC;
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               where  yc.PhongBanYC == ycmh.PhongBanYC
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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
        //Lọc theo Phòng ban và tình trạng
        public DataTable Loc_YC_TT_PB( DTO_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            YEUCAU_MUAHANG ycmh = new YEUCAU_MUAHANG();
            ycmh.TinhTrang = dto.TinhTrang;
            ycmh.PhongBanYC = dto.PhongBanYC;
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               join nv in cnn.NHANVIENs on yc.MaNV equals nv.MaNV
                               where yc.TinhTrang == ycmh.TinhTrang && yc.PhongBanYC == ycmh.PhongBanYC
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
                    dr["MaYC"] = item.MaYC ?? string.Empty;
                    dr["PhongBanYC"] = item.PhongBanYC ?? string.Empty;
                    dr["TenNV"] = item.TenNV ?? string.Empty;
                    dr["NgayYC"] = item.NgayYC ?? DateTime.MinValue;
                    dr["TinhTrang"] = item.TinhTrang ?? string.Empty;

                    //Xử lý giá trị null

                    dr["NgayDuyet"] = item.NgayDuyet ?? DateTime.MinValue;
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

        // Đếm số sản phẩm yêu cầu

        public int Count_CT_YC(DTO_YeuCauMH dto)
        {
            QLMHEntities3 cnn = new QLMHEntities3();
            
            try
            {
                int count = cnn.CT_YEUCAU.Count(a => a.MaYC == dto.MaYC);
                return count;
            }
            catch (Exception) { return 0; }
        }

        
    }
}
    

