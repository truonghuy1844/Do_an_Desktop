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
                string query = "SELECT    THANHTOAN.MaTT ,HOADON.Matt,    THANHTOAN.NgayTT , THANHTOAN.SoTien, THANHTOAN.TrangThai       FROM HOADON JOIN THANHTOAN  ON HOADON.MaHD =  THANHTOAN.MaHD ;";
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
                string myQuery = "Insert into THANHTOAN (MaTT, MaHD, NgayTT,SoTien,TrangThai) values (@matt, @mahd,@ngaytt,@sotien,@trangthai)";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@matt", tt.MaTT);
                cmd.Parameters.AddWithValue("@ngaytt", tt .NgayTT.Date);
                cmd.Parameters.AddWithValue("@madmh", tt.MaHD);
                cmd.Parameters.AddWithValue("@sotien",tt.SoTien);
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
                    cmd = new SqlCommand("Select * from THANHTOAN where MaTT LIKE @matt", conn);
                    cmd.Parameters.AddWithValue("@matt", "%" + tukhoa + "%");
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
    }
    
}
