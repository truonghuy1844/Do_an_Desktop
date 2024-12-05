using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class LoadComboBox
    {
        /// <summary>
        /// Combobox San Pham
        /// </summary>
        /// <returns></returns>
        public DataTable Load_ComboBox_SanPham()
        {
            try
            {
                QLMHEntities1 db = new QLMHEntities1();
                var list = (from sp in db.SANPHAMs
                            select new
                            {
                                MaSP = sp.MaSP,
                                TenSP = sp.TenSP
                            }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaSP", typeof(string));
                dt.Columns.Add("TenSP", typeof(string));
                DataRow dong = dt.NewRow();
                dong["MaSP"] = 0;
                dong["TenSP"] = "";
                dt.Rows.Add(dong);
                foreach (var item in list)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaSP"] = item.MaSP;
                    dr["TenSP"] = item.TenSP;
                    dt.Rows.Add(dr);
                }
                return dt; 
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Lỗi", typeof(string));
                
                DataRow dr1 = dt.NewRow();
                dr1["Lỗi"] = ex.Message;
                
                dt.Rows.Add(dr1);
                return dt;
            }
        }
        //Combobox Nha Cung Cap
        public DataTable Load_Cb_NCC()
        {
            try
            {
                QLMHEntities1 db = new QLMHEntities1();
                var list = (from ncc in db.NHACUNGCAPs
                            select new
                            {
                                MaNCC = ncc.MaNCC,
                                TenNCC = ncc.TenNCC
                            }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaNCC", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));
                DataRow dong = dt.NewRow();
                dong["MaNCC"] = 0;
                dong["TenNCC"] = "";
                dt.Rows.Add(dong);
                foreach (var item in list)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaNCC"] = item.MaNCC;
                    dr["TenNCC"] = item.TenNCC;
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaNCC", typeof(string));
                dt.Columns.Add("TenNCC", typeof(string));

                DataRow dr1 = dt.NewRow();
                dr1["MaNCC"] = 0;
                dr1["TenNCC"] = ex.Message;
                

                dt.Rows.Add(dr1);
                return dt;
            }
        }



            

    }

}

