using PC_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_DAL
{
    public class DALChucvu :DBConnect 
    {
        public bool Kiemtraquanly(DTONhanvien nv)
        {
            try
            {
                conn.Open();
                string myQuery = "Select count(*) from NHANVIEN where MaNV = @manv and ChucVu !='Nhân viên'";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@manv", nv.MaNV);

                int dem = (int)cmd.ExecuteScalar();
                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }

        public bool Kiemtraphongban(DTONhanvien nv)
        {
            try
            {
                conn.Open();
                string myQuery = "Select count(*) from NHANVIEN where MaNV = @manv and PhongBan = N'Mua hàng'";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@manv", nv.MaNV);

                int dem = (int)cmd.ExecuteScalar();
                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }


    }
}
