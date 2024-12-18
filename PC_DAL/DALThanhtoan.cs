using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;

namespace PC_DAL
{
    public class DALThanhtoan : DBConnect
    {
        
        public DataTable LoadThanhtoan(string mahd)
        {
            try
            {

                conn.Open();
                string myQuery = "Select * from THANHTOAN where MaHD=@mahd";
                SqlDataAdapter adapter = new SqlDataAdapter(myQuery, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { return null; }
            finally { conn.Close(); }


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
