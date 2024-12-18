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
    public class DALThanhtoan: DBConnect 
    {
        public DataTable LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT    THANHTOAN.MaTT ,HOADON.MaHD,    THANHTOAN.NgayTT , THANHTOAN.TrangThai       FROM HOADON JOIN THANHTOAN  ON HOADON.MaHD =  THANHTOAN.MaHD";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception) { return null; }
            finally { conn.Close(); }

        }
        public bool Taothanhtoan(DTOThanhtoan tt)
        {
            try
            {
                conn.Open();
                string myQuery = "Insert into THANHTOAN (MaTT, MaHD, NgayTT,TrangThai) values (@matt, @mahd,@ngaytt,@trangthai)";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@matt", tt.MaTT);
                cmd.Parameters.AddWithValue("@ngaytt", tt .NgayTT.Date);
                cmd.Parameters.AddWithValue("@madmh", tt.MaHD);
                cmd.Parameters.AddWithValue("@trangthai", tt.TrangThai);


                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
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
        public bool Xoathanhtoan(DTOThanhtoan tt)
        {
            try
            {
                conn.Open();
                string myQuery = "Delete from THANHTOAN where MaTT = @matt";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@matt", tt.MaTT);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public DataTable Timthanhtoan(string tukhoa)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                if (string.IsNullOrWhiteSpace(tukhoa))
                {
                    cmd = new SqlCommand("Select * from THANHTOAN", conn);
                }
                else
                {
                    cmd = new SqlCommand("Select * from THANHTOAN where MaHD LIKE @mahd", conn);
                    cmd.Parameters.AddWithValue("@mahd", "%" + tukhoa + "%");
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (SqlException)
            { return null; }
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
