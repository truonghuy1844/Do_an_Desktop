using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DAL
{
    public class DAL_YeuCauMH
    {
        public DataTable Load_YC_MuaHang()
        {
            QLMHEntities cnn = new QLMHEntities();
            try
            {
                var list_YC = (from yc in cnn.YEUCAU_MUAHANG
                               select new
                               {
                                   MaYC = yc.MaYC,
                                   MaNV = yc.MaNV,
                                   NgayYC = yc.NgayYC,
                                   NgayDuyet = yc.NgayDuyet,
                                   PhongBanYC = yc.PhongBanYC,
                                   TinhTrang = yc.TinhTrang
                               }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaYC", typeof(string));
                dt.Columns.Add("PhongBanYC", typeof(string));
                dt.Columns.Add("NgayYC", typeof(DateTime));
                dt.Columns.Add("NgayDuyet", typeof(DateTime));
                dt.Columns.Add("MaNV", typeof(string));
                dt.Columns.Add("TinhTrang", typeof(string));
                //Thêm vào bảng
                foreach (var item in list_YC)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaYC"] = item.MaYC;
                    dr["PhongBanYC"] = item.PhongBanYC;
                    dr["NgayYC"] = item.NgayYC;
                    dr["NgayDuyet"] = item.NgayDuyet;
                    dr["MaNV"] = item.MaNV;
                    dr["TinhTrang"] = item.TinhTrang;
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
    }
    public class DAL_CT_YeuCau
    {

    }
}
