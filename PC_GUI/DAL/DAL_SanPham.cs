using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class DAL_SanPham
    {
        //Tìm kiếm sản phẩm
        public DataTable TimKiemSP( string timKiem, string loaiSP)
        {
            QLMHEntities4 cnn = new QLMHEntities4();
            
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaSP", typeof(string));
                dt.Columns.Add("TenSP", typeof(string));
                dt.Columns.Add("LoaiSP", typeof(string));
                dt.Columns.Add("DVT", typeof(string));
                var list_SP = cnn.SANPHAMs
                                    .Where(sp =>
                                    (sp.TenSP.ToLower().Contains(timKiem)) ||
                                    (sp.MaSP.ToLower().Contains(timKiem)) ||
                                    (sp.LoaiSP != null && sp.LoaiSP.ToLower().Contains(loaiSP)))
                                    .Select(sp => new
                                    {
                                        MaSP = sp.MaSP,
                                        TenSP = sp.TenSP,
                                        LoaiSP = sp.LoaiSP, 
                                        DVT = sp.DVT
                                    })
                                    .Distinct().ToList();
                //Thêm vào bảng
                foreach (var bg in list_SP)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaSP"] = bg.MaSP ?? string.Empty;
                    dr["TenSP"] = bg.TenSP ?? string.Empty;
                    dr["LoaiSP"] = bg.LoaiSP ?? string.Empty;

                    dr["DVT"] = bg.DVT ?? string.Empty;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "MaSP";
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


        //Load danh sachs sanr phaamr
        public DataTable Load_SanPham()
        {

            QLMHEntities4 cnn = new QLMHEntities4();
            try
            {
                var list_SP = (from sp in cnn.SANPHAMs                               
                               select new
                               {
                                   MaSP = sp.MaSP,
                                   TenSP = sp.TenSP,
                                   LoaiSP = sp.LoaiSP,
                                   DVT = sp.DVT
                               }).Distinct().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaSP", typeof(string));
                dt.Columns.Add("TenSP", typeof(string));
                dt.Columns.Add("LoaiSP", typeof(string));
                dt.Columns.Add("DVT", typeof(string));


                //Thêm vào bảng
                foreach (var bg in list_SP)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaSP"] = bg.MaSP ?? string.Empty;
                    dr["TenSP"] = bg.TenSP ?? string.Empty;
                    dr["LoaiSP"] = bg.LoaiSP ?? string.Empty;
                                        
                    dr["DVT"] = bg.DVT ?? string.Empty;
                    dt.Rows.Add(dr);
                }
                dt.DefaultView.Sort = "MaSP";
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
        //Thêm sanr phaamr
        public bool Them_SP(DTO_SanPham sanPham)
        {
            QLMHEntities4 conn = new QLMHEntities4();
            try
            {
                SANPHAM sp = new SANPHAM();
                sp.MaSP = sanPham.MaSanPham;
                sp.TenSP = sanPham.TenSanPham;
                sp.LoaiSP = sanPham.LoaiSanPham;
                sp.DVT = sanPham.DVT;

                conn.SANPHAMs.Add(sp);
                conn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //Xóa sản phẩm
        public bool Xoa_SP(DTO_SanPham sanPham)
        {
            QLMHEntities4 conn = new QLMHEntities4();
            SANPHAM sp = conn.SANPHAMs.Find(sanPham.MaSanPham.Trim());
            if (sp != null)
            {

                try
                {
                    conn.SANPHAMs.Remove(sp);
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
        //Sửa Sanr phaamr
        public bool Sua_SP(DTO_SanPham sanPham)
        {
            QLMHEntities4 conn = new QLMHEntities4();
            SANPHAM sp = conn.SANPHAMs.Find(sanPham.MaSanPham.Trim());

            if (sp != null)
            {
                sp.TenSP = sanPham.TenSanPham;
                sp.LoaiSP = sanPham.LoaiSanPham;
                sp.DVT = sanPham.DVT;
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
        ///KIểm tra mã báo giá
        ///
        public bool KiemTraMaSP(DTO_SanPham sanPham)
        {
            QLMHEntities4 conn = new QLMHEntities4();
            SANPHAM sp = conn.SANPHAMs.FirstOrDefault(a => a.MaSP == sanPham.MaSanPham);
            if (sp == null) return true;
            return false;
        }
    }
}
