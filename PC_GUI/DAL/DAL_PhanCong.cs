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
    public class DAL_PhanCong : ConnectDB_Manual
    {
        //load phân công công việc vào datagridview 
        public DataTable loadphancong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from PHANCONG_CONGVIEC order by NgayGiao desc", conn);
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
            finally { conn.Close(); }
        }
        //Tạo phân công mới     
        public bool Taophancong(DTOPhancong pc)
        {
            try
            {
                conn.Open();
                string myQuery = "Insert into PHANCONG_CONGVIEC (MaPC, MaNV, NgayGiao, NgayHT, Congviec, TThai) values (@mapc,@manv,@ngaygiao,@ngayht,@cv,@tthai)";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@mapc", pc.MaPC);
                cmd.Parameters.AddWithValue("@manv", pc.MaNV);
                cmd.Parameters.AddWithValue("@ngaygiao", pc.Ngaygiao);
                cmd.Parameters.AddWithValue("@ngayht", pc.Ngayht);
                cmd.Parameters.AddWithValue("@cv", pc.Congviec);
                cmd.Parameters.AddWithValue("@tthai", pc.Tthai);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception) { return false; }
            finally { conn.Close(); }
        }
        //Kiểm tra mã phân công tồn tại trong hệ thống 
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
        //Cập nhật phân công 
        public bool Suaphancong(DTOPhancong pc)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update PHANCONG_CONGVIEC set NgayHT = @ngayht, Congviec = @cv,TThai = @tt where MaPC = @mapc", conn);
                cmd.Parameters.AddWithValue("@mapc", pc.MaPC);
                cmd.Parameters.AddWithValue("@ngayht", pc.Ngayht);
                cmd.Parameters.AddWithValue("@cv", pc.Congviec);
                cmd.Parameters.AddWithValue("@tt", pc.Tthai);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        //Xóa phân công 
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
        //Tìm phân công theo mã, tên nhân viên, mã phân công hoặc khối lượng 
        public DataTable Timphancong(string tukhoa)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                if (string.IsNullOrEmpty(tukhoa))
                {
                    cmd = new SqlCommand("Select * from PHANCONG_CONGVIEC order by NgayGiao desc");
                }
                else
                {
                    cmd = new SqlCommand("Select pc.MaPC, pc.MaNV,nv.TenNV, pc.NgayGiao,pc.NgayHT,pc.Congviec,pc.TThai from PHANCONG_CONGVIEC pc join NHANVIEN nv on pc.MaNV = nv.MaNV " +
                        "where nv.TenNV LIKE @tennv or pc.MaPC LIKE @pc or pc.Congviec LIKE @cv or nv.MaNV LIKE @manv", conn);
                    cmd.Parameters.AddWithValue("@tennv", "%" + tukhoa + "%");
                    cmd.Parameters.AddWithValue("@pc", "%" + tukhoa + "%");
                    cmd.Parameters.AddWithValue("@cv", "%" + tukhoa + "%");
                    cmd.Parameters.AddWithValue("@manv", "%" + tukhoa + "%");
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
        //Load combobox trạng thái phân công 
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
        //Lọc datagridview theo trạng thái 
        public DataTable hoanthanh(string trangthai)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from PHANCONG_CONGVIEC order by NgayGiao desc" +
                    "where TThai = @tthai", conn);
                cmd.Parameters.AddWithValue("@tthai", trangthai);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable chuaht = new DataTable();
                da.Fill(chuaht);
                return chuaht;
            }
            catch (Exception)
            { return null; }
            finally { conn.Close(); }
        }
    }
}
