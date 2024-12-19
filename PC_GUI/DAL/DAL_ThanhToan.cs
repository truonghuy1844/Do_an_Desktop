using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class DAL_ThanhToan : ConectDB_Manual
    {
        public DTOThanhtoan LoadThanhtoan(string maHD)
        {

            DTOThanhtoan dTOThanhtoan = null;

            string query = "SELECT MaTT, NgayTT,TrangThai FROM THANHTOAN WHERE MaHD=@mahd";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mahd", maHD);
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dTOThanhtoan = new DTOThanhtoan();
                            dTOThanhtoan.MaTT = reader["MaTT"].ToString();
                            dTOThanhtoan.NgayTT = Convert.ToDateTime(reader["NgayTT"]);
                            dTOThanhtoan.TrangThai = reader["TrangThai"].ToString();
                        }

                    }
                }
                catch (SqlException ex) { return dTOThanhtoan = null; }
                finally { conn.Close(); }
                return dTOThanhtoan;
            }

        }

        public bool Kiemtramatt(string matt)
        {
            try
            {
                conn.Open();
                string myQuery = "Select COUNT(*) from THANHTOAN where MaTT = @matt";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@matt", matt);

                int count = (int)cmd.ExecuteScalar();
                return count > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public bool Capnhatthanhtoan(DTOThanhtoan tt)
        {
            try
            {
                conn.Open();
                string myQuery = "Update THANHTOAN set NgayTT = @ngaytt, TrangThai=@trangthai where MaTT = @matt";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@ngaytt", tt.NgayTT.Date);
                cmd.Parameters.AddWithValue("@trangthai", tt.TrangThai);



                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }


        public DataTable Thuchien(string mahd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE THANHTOAN SET  TrangThai = N'Đã thanh toán', NgayTT= Getdate() WHERE MaHD LIKE @mahd", conn);
                cmd.Parameters.AddWithValue("@mahd", mahd);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (SqlException)
            { return null; }
            finally { conn.Close(); }

        }
    }
}
