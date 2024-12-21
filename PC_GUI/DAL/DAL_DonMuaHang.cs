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
    public class DAL_DonMuaHang : ConnectDB_Manual
    {
        public bool Taodonhang(DTODonhang dh)
        {
            try
            {
                conn.Open();
                string myQuery = "Insert into DONMUAHANG (MaDMH, NgayLap, MaHDMH, MaNV, MaNCC, Chietkhau, TThai, MoTa) values (@madmh, @ngaylap,@mahd,@manv,@mancc, @ck, @tthai,@mota)";

                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@madmh", dh.MaDMH);
                cmd.Parameters.AddWithValue("@ngaylap", dh.Ngaylap.Date);
                cmd.Parameters.AddWithValue("@mahd", dh.MaHDMH);
                cmd.Parameters.AddWithValue("@manv", dh.MaNV);
                cmd.Parameters.AddWithValue("@mancc", dh.MaNCC);
                cmd.Parameters.AddWithValue("@ck", dh.Chietkhau);
                cmd.Parameters.AddWithValue("@tthai", dh.Tthai);
                cmd.Parameters.AddWithValue("@mota", dh.Mota);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public bool Suadonhang(DTODonhang dh)
        {
            try
            {
                conn.Open();
                string myQuery = "Update DONMUAHANG set NgayLap = @ngaylap, MaHDMH = @mahd, MaNV = @manv, MaNCC = @mancc, Chietkhau = @ck, TThai = @tt, MoTa = @mota where MaDMH = @madmh";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@madmh", dh.MaDMH);
                cmd.Parameters.AddWithValue("@ngaylap", dh.Ngaylap.Date);
                cmd.Parameters.AddWithValue("@mahd", dh.MaHDMH);
                cmd.Parameters.AddWithValue("@manv", dh.MaNV);
                cmd.Parameters.AddWithValue("@mancc", dh.MaNCC);
                cmd.Parameters.AddWithValue("@ck", dh.Chietkhau);
                cmd.Parameters.AddWithValue("@tt", dh.Tthai);
                cmd.Parameters.AddWithValue("@mota", dh.Mota);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public bool Xoadonhang(DTODonhang dh)
        {
            try
            {
                conn.Open();
                string myQuery = "Delete from DONMUAHANG where MaDMH = @madmh";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@madmh", dh.MaDMH);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public DataTable TimDonhang(string tukhoa)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                if (string.IsNullOrWhiteSpace(tukhoa))
                {
                    cmd = new SqlCommand("Select * from DONMUAHANG", conn);
                }
                else
                {
                    cmd = new SqlCommand("Select * from DONMUAHANG where MaDMH LIKE @madmh or " +
                        "MoTa LIKE @mota", conn);
                    cmd.Parameters.AddWithValue("@madmh", "%" + tukhoa + "%");
                    cmd.Parameters.AddWithValue("@mota", "%" + tukhoa + "%");
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
        public bool Kiemtramadmh(string madm)
        {
            try
            {
                conn.Open();
                string myQuery = "Select COUNT(*) from DONMUAHANG where MaDMH = @madmh";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@madmh", madm);

                int count = (int)cmd.ExecuteScalar();
                return count > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        //kiểm tra mã sản phẩm
        public bool KiemtraMaDGSP(string madg)
        {
            try
            {
                conn.Open();
                string myQuery = "Select COUNT(*) from DANHGIASP_TRONGDON where MaDGSP = @madgsp";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@madgsp", madg);

                int countdg = (int)cmd.ExecuteScalar();
                return countdg > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        //load mã đơn mua hàng vào combobox 
        public DataTable loaddmh()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from DONMUAHANG", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception) { return null; }
            finally { conn.Close(); };
        }
        public int donhoantat()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from DONMUAHANG where TThai = N'Hoàn tất'", conn);
            int donht = (int)cmd.ExecuteScalar();
            conn.Close();
            return donht;
        }

        public int doncho()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from DONMUAHANG where TThai = N'Chờ xử lý'", conn);
            int donxl = (int)cmd.ExecuteScalar();
            conn.Close();
            return donxl;
        }

        //Kiểm tra khóa chính ghép chi tiết đơn mua 
        public bool Kiemtrakhoactdonmua(string maDMH, string maSP, string mabg)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select COUNT(*) from CT_DONMUAHANG where MaDMH = @madmh and MaSP = @masp and MaBG =@mabg", conn);
                cmd.Parameters.AddWithValue("@madmh", maDMH);
                cmd.Parameters.AddWithValue("@masp", maSP);
                cmd.Parameters.AddWithValue("@mabg", mabg);

                int countt = (int)cmd.ExecuteScalar();
                return countt > 0 ? true : false;
            }
            catch (Exception) { return false; }
            finally { conn.Close(); };
        }
        //Load chi tiết đơn mua của đơn hàng được chọn 
        //public DataTable Chitietdonmua(string madonmua)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("Select (*) from CT_DONMUAHANG where MaDMH = @madmh", conn);
        //        cmd.Parameters.AddWithValue("@madmh", madonmua);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception) { return null; }
        //    finally { conn.Close(); };
        //}
    
    }
}
