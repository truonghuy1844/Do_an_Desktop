using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DAL
{
    public class DALPhancong:DBConnect
    {
        //load phân công công việc vào datagridview 
        public DataTable loadphancong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from PHANCONG_CONGVIEC", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException) { return null; }
            finally { conn.Close(); }
        }
        //load dữ liệu vào cb tên nhân viên 
        public DataTable loadtennv()
        {    
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from NHANVIEN", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);
                conn.Close();
                return dta;
            }
            catch (SqlException) { return null; }
            finally{ conn.Close(); }
        }
            
        public bool Taophancong(DTOPhancong pc)
        {
            try
            {
                conn.Open();
                string myQuery = "Insert into PHANCONG_CONGVIEC (MaPC, MaNV, NgayGiao, NgayHT, KLuong, TThai) values (@mapc,@manv,@ngaygiao,@ngayht,@kl,@tthai)";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@mapc", pc.MaPC);
                cmd.Parameters.AddWithValue("@manv", pc.MaNV);
                cmd.Parameters.AddWithValue("@ngaygiao", pc.Ngaygiao);
                cmd.Parameters.AddWithValue("@ngayht", pc.Ngayht);
                cmd.Parameters.AddWithValue("@kl", pc.Kluong);
                cmd.Parameters.AddWithValue("@tthai", pc.Tthai);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception) { return false; }
            finally { conn.Close(); }
        }
        public bool kiemtramapc(string mapc)
        {
            try
            {
                conn.Open();
                string myQuery = "Select COUNT(*) from PHANCONG_CONGVIEC where MaPC = @mapc";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@mapc", mapc);

                int count = (int)cmd.ExecuteScalar();
                return count > 0 ? true : false;
            }
            catch { return false; }
            finally { conn.Close(); }
        }
        public bool Suaphancong(DTOPhancong pc)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update PHANCONG_CONGVIEC set NgayHT = @ngayht, KLuong = @kl,TThai = @tt where MaPC = @mapc", conn);
                cmd.Parameters.AddWithValue("mapc", pc.MaPC);
                cmd.Parameters.AddWithValue("ngayht", pc.Ngayht);
                cmd.Parameters.AddWithValue("kl", pc.Kluong);
                cmd.Parameters.AddWithValue("tt", pc.Tthai);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        //Xóa
        public bool Xoaphancong(DTOPhancong pc)
        {
            try
            {
                conn.Open();
                string myQuery = "Delete from PHANCONG_CONGVIEC where MaPC = @mapc";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@mapc", pc.MaPC);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public DataTable Timphancong(string tukhoa)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                if (string.IsNullOrEmpty(tukhoa))
                {
                    cmd = new SqlCommand("Select * from PHANCONG_CONGVIEC");
                }
                else
                {
                    cmd = new SqlCommand("Select pc.MaPC, pc.MaNV,nv.TenNV, pc.NgayGiao,pc.NgayHT,pc.KLuong,pc.TThai from PHANCONG_CONGVIEC pc join NHANVIEN nv on pc.MaNV = nv.MaNV " +
                        "where nv.TenNV like @tensp or pc.MaPC = @pc", conn);
                    cmd.Parameters.AddWithValue("@tensp", "%" + tukhoa + "%");
                    cmd.Parameters.AddWithValue("@tensp", "%" + tukhoa + "%");
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            { return null; }
            finally { conn.Close(); }
        }

        public DataTable loadcbtt()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select distinct TThai from PHANCONG_CONGVIEC");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            { return null; }
            finally { conn.Close(); }
        }
        public DataTable hoanthanh(string trangthai)
        {
            try
            {
                conn.Open();    
                SqlCommand cmd = new SqlCommand("Select * from PHANCONG_CONGVIEC" +
                    "where TThai = @tthai",conn);
                cmd.Parameters.AddWithValue("@tthai", trangthai);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable chuaht = new DataTable();
                da.Fill(chuaht);
                return chuaht;
            }
            catch (Exception) { return null; }
            finally { conn.Close(); }   
        }

        //public DataTable dahoanthanh()
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("Select * from PHANCONG_CONGVIEC" +
        //            "where TThai = N'Đã hoàn thành'", conn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable chuaht = new DataTable();
        //        da.Fill(chuaht);
        //        return chuaht;
        //    }
        //    catch (Exception) { return null; }
        //    finally { conn.Close(); }
        //}
    }
}
