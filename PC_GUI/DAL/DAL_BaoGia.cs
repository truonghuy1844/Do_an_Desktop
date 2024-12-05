using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_GUI.DAL
{
    public class DAL_BaoGia
    {
        public DataTable Load_BaoGia()
        {

            QLMHEntities1 cnn = new QLMHEntities1();
            try
            {
                var list_BG = (from bg in cnn.BAOGIAs
                               join ncc in cnn.NHACUNGCAPs 
                               on bg.MaNCC equals ncc.MaNCC
                               select new
                               {
                                   MaBG = bg.MaBG,
                                   MaNCC = bg.MaNCC,
                                   TenNCC = ncc.TenNCC,
                                   NgayBG = bg.NgayBG
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaBG", typeof(string));
                dt.Columns.Add("MaNCC", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));
                dt.Columns.Add("NgayBG", typeof(DateTime));
                

                //Thêm vào bảng
                foreach (var bg in list_BG)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaBG"] = bg.MaBG;
                    dr["MaNCC"] = bg.MaNCC;
                    dr["TenNCC"] = bg.TenNCC;
                    dr["NgayBG"] = bg.NgayBG;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "NgayBG DESC";
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

        //Thêm báo giá
        public bool Them_BG(DTO_BaoGia dto_BaoGia)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            try
            {
                BAOGIA baoGia = new BAOGIA();
                baoGia.MaBG = dto_BaoGia.MaBG;
                baoGia.MaNCC = dto_BaoGia.MaNCC;
                conn.BAOGIAs.Add(baoGia);
                conn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //Xóa báo giá
        public bool Xoa_BG(DTO_BaoGia dto_BG)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            BAOGIA baoGia = conn.BAOGIAs.Find(dto_BG.MaBG.Trim());
            if (baoGia != null)
            {

                try
                {
                    conn.BAOGIAs.Remove(baoGia);
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
        //Sửa báo giá
        public bool Sua_BG(DTO_BaoGia dto_BG)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            BAOGIA baoGia = conn.BAOGIAs.Find(dto_BG.MaBG.Trim());

            if (baoGia != null)
            {
                baoGia.MaNCC = dto_BG.MaNCC;
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
    /// Chi tiết báo giá
    /// </summary>
    public class DAL_CT_BaoGia
    {
        //Load dữ liệu chi tiết báo giá
        public DataTable Load_CT_BaoGia(DTO_CT_BaoGia bgia)
        {
            DTO_CT_BaoGia dTO = new DTO_CT_BaoGia();
            dTO.MaBG = bgia.MaBG;
            try
            {
                QLMHEntities1 cnn = new QLMHEntities1();
                var list_BG = (from ct_bg in cnn.CT_BAOGIA
                               join bg in cnn.BAOGIAs
                               on ct_bg.MaBG equals bg.MaBG
                               join sp in cnn.SANPHAMs
                               on ct_bg.MaSP equals sp.MaSP
                               join ncc in cnn.NHACUNGCAPs
                               on bg.MaNCC equals ncc.MaNCC
                               where dTO.MaBG == ct_bg.MaBG
                               select new
                               {
                                   MaBG = ct_bg.MaBG,
                                   TenSP = sp.TenSP,
                                   TenNCC = ncc.TenNCC,
                                   DonGia = ct_bg.DonGia,
                                   MoTa = ct_bg.MoTa
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaBG", typeof(string));
                dt.Columns.Add("TenSP", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));
                dt.Columns.Add("DonGia", typeof(int));
                dt.Columns.Add("MoTa", typeof(string));
                //Thêm vào bảng
                foreach (var ct in list_BG)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaBG"] = ct.MaBG;
                    dr["TenSP"] = ct.TenSP;
                    dr["TenNCC"] = ct.TenNCC;
                    dr["DonGia"] = ct.DonGia;
                    dr["MoTa"] = ct.MoTa;
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

        //Thêm chi tiết báo giá
        public bool Them_CT_BaoGia(DTO_CT_BaoGia dto_CT_BG)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            try
            {
                CT_BAOGIA ct = new CT_BAOGIA();
                ct.MaBG = dto_CT_BG.MaBG;
                ct.MaSP = dto_CT_BG.MaSP;
                ct.DonGia = dto_CT_BG.DonGia;
                ct.MoTa = dto_CT_BG.MoTa;

                conn.CT_BAOGIA.Add(ct);
                conn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //Sửa chi tiết báo giá
        public bool Sua_CT_BG(DTO_CT_BaoGia dto_CT_BG)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            CT_BAOGIA ctbg = conn.CT_BAOGIA.SingleOrDefault(item => item.MaBG == dto_CT_BG.MaBG && item.MaSP == dto_CT_BG.MaSP);

            if (ctbg != null)
            {
                ctbg.DonGia = dto_CT_BG.DonGia;
                ctbg.MoTa = dto_CT_BG.MoTa;
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
        //Xóa 1 chi tiết báo giá trong 1 mã báo giá
        public bool Xoa_SP_CT_BG(DTO_CT_BaoGia cT_BaoGia)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            CT_BAOGIA ct = conn.CT_BAOGIA.SingleOrDefault(item => item.MaBG == cT_BaoGia.MaBG && item.MaSP == cT_BaoGia.MaSP);
            if (ct != null)
            {

                try
                {
                    conn.CT_BAOGIA.Remove(ct);
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
        //Xóa toàn bộ sản phẩm có mã BG
        public bool Xoa_CT_BG(DTO_CT_BaoGia baoGia)
        {
            QLMHEntities1 conn = new QLMHEntities1();
            var ct = conn.CT_BAOGIA.Where(item => item.MaBG == baoGia.MaBG).ToList();
            if (ct != null)
            {

                try
                {
                    conn.CT_BAOGIA.RemoveRange(ct);
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
    //// Lọc báo giá
    ///
    ///Lọc theo sản phẩm có trong báo giá
    public class DAL_Loc_BaoGia
    {
        public DataTable Load_Loc_SP ( DTO_CT_BaoGia ctiet, DateTime start, DateTime end)
        {
            QLMHEntities1 cnn = new QLMHEntities1();
            DTO_CT_BaoGia cT_BaoGia = new DTO_CT_BaoGia();
            cT_BaoGia.MaSP = ctiet.MaSP;
            try
            {
                var list_BG = (from bg in cnn.BAOGIAs
                               join ncc in cnn.NHACUNGCAPs
                               on bg.MaNCC equals ncc.MaNCC
                               join ct in cnn.CT_BAOGIA
                               on bg.MaBG equals ct.MaBG
                               where ct.MaSP == cT_BaoGia.MaSP && bg.NgayBG <= end && bg.NgayBG >= start
                               select new
                               {
                                   MaBG = bg.MaBG,
                                   MaNCC = bg.MaNCC,
                                   TenNCC = ncc.TenNCC,
                                   NgayBG = bg.NgayBG
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaBG", typeof(string));
                dt.Columns.Add("MaNCC", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));
                dt.Columns.Add("NgayBG", typeof(DateTime));


                //Thêm vào bảng
                foreach (var bg in list_BG)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaBG"] = bg.MaBG;
                    dr["MaNCC"] = bg.MaNCC;
                    dr["TenNCC"] = bg.TenNCC;
                    dr["NgayBG"] = bg.NgayBG;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "NgayBG DESC";
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

        //Lọc theo NCC
        public DataTable Load_Loc_NCC(DTO_BaoGia bgia, DateTime start, DateTime end)
        {
            QLMHEntities1 cnn = new QLMHEntities1();
            DTO_BaoGia dto = new DTO_BaoGia();
            dto.MaNCC = bgia.MaNCC;
            try
            {
                var list_BG = (from bg in cnn.BAOGIAs
                               join ncc in cnn.NHACUNGCAPs
                               on bg.MaNCC equals ncc.MaNCC                               
                               where bg.MaNCC == dto.MaNCC && bg.NgayBG <= end && bg.NgayBG >= start
                               select new
                               {
                                   MaBG = bg.MaBG,
                                   MaNCC = bg.MaNCC,
                                   TenNCC = ncc.TenNCC,
                                   NgayBG = bg.NgayBG
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaBG", typeof(string));
                dt.Columns.Add("MaNCC", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));
                dt.Columns.Add("NgayBG", typeof(DateTime));


                //Thêm vào bảng
                foreach (var bg in list_BG)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaBG"] = bg.MaBG;
                    dr["MaNCC"] = bg.MaNCC;
                    dr["TenNCC"] = bg.TenNCC;
                    dr["NgayBG"] = bg.NgayBG;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "NgayBG DESC";
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
        /// Lọc theo cả SP và NCC
        /// 
        public DataTable Load_Loc_SP_NCC(DTO_CT_BaoGia ctiet,DTO_BaoGia bgia, DateTime start, DateTime end)
        {
            QLMHEntities1 cnn = new QLMHEntities1();
            DTO_CT_BaoGia cT_BaoGia = new DTO_CT_BaoGia();
            DTO_BaoGia dto = new DTO_BaoGia();
            dto.MaNCC = bgia.MaNCC;
            cT_BaoGia.MaSP = ctiet.MaSP;
            try
            {
                var list_BG = (from bg in cnn.BAOGIAs
                               join ncc in cnn.NHACUNGCAPs
                               on bg.MaNCC equals ncc.MaNCC
                               join ct in cnn.CT_BAOGIA
                               on bg.MaBG equals ct.MaBG
                               where ct.MaSP == cT_BaoGia.MaSP && bg.NgayBG <= end 
                               && bg.NgayBG >= start && bg.MaNCC == dto.MaNCC
                               select new
                               {
                                   MaBG = bg.MaBG,
                                   MaNCC = bg.MaNCC,
                                   TenNCC = ncc.TenNCC,
                                   NgayBG = bg.NgayBG
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaBG", typeof(string));
                dt.Columns.Add("MaNCC", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));
                dt.Columns.Add("NgayBG", typeof(DateTime));


                //Thêm vào bảng
                foreach (var bg in list_BG)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaBG"] = bg.MaBG;
                    dr["MaNCC"] = bg.MaNCC;
                    dr["TenNCC"] = bg.TenNCC;
                    dr["NgayBG"] = bg.NgayBG;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "NgayBG DESC";
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
        //Lọc theo ngày tháng
        public DataTable Load_Loc_NT(DateTime start, DateTime end)
        {
            QLMHEntities1 cnn = new QLMHEntities1();
            
            try
            {
                var list_BG = (from bg in cnn.BAOGIAs
                               join ncc in cnn.NHACUNGCAPs
                               on bg.MaNCC equals ncc.MaNCC
                               join ct in cnn.CT_BAOGIA
                               on bg.MaBG equals ct.MaBG
                               where  bg.NgayBG <= end
                               && bg.NgayBG >= start
                               select new
                               {
                                   MaBG = bg.MaBG,
                                   MaNCC = bg.MaNCC,
                                   TenNCC = ncc.TenNCC,
                                   NgayBG = bg.NgayBG
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaBG", typeof(string));
                dt.Columns.Add("MaNCC", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));
                dt.Columns.Add("NgayBG", typeof(DateTime));


                //Thêm vào bảng
                foreach (var bg in list_BG)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaBG"] = bg.MaBG;
                    dr["MaNCC"] = bg.MaNCC;
                    dr["TenNCC"] = bg.TenNCC;
                    dr["NgayBG"] = bg.NgayBG;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "NgayBG DESC";
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
        }
}
