﻿using PC_GUI.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;

namespace PC_GUI.DAL
{
    public class DAL_HoaDon : ConectDB_Manual
    {

        public DataTable TimKiem(string tukhoa)
        {
            try
            {
                conn.Open();
                string query = "SELECT Distinct HOADON.MaHD,  HOADON.MaDMH,  HOADON.NgayLap,SANPHAM.MaSP ,SANPHAM.TenSP, CAST(CT_BAOGIA.DonGia AS INT) as DonGia,  " +
                    "CT_DONMUAHANG.SoLuong,   CAST((CT_BAOGIA.DonGia * CT_DONMUAHANG.SoLuong) AS INT) AS ThanhTien, SUM(CAST((CT_DONMUAHANG.SoLuong * CT_BAOGIA.DonGia) AS INT)) OVER (PARTITION BY HOADON.MaHD) " +
                    "as Tonghoadon,     HOADON.GhiChu, THANHTOAN.TrangThai FROM HOADON JOIN CT_DONMUAHANG ON HOADON.MaDMH =  CT_DONMUAHANG.MaDMH " +
                    "JOIN CT_BAOGIA ON CT_DONMUAHANG.MaBG = CT_BAOGIA.MaBG JOIN SANPHAM ON CT_DONMUAHANG.MaSP = CT_BAOGIA.MaSP JOIN THANHTOAN ON HOADON.MaHD=THANHTOAN.MaHD " +
                    "WHERE CT_DONMUAHANG.MaSP=CT_BAOGIA.MaSP and CT_BAOGIA.MaSP = SANPHAM.MaSP       ";
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
        public DataTable LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT Distinct HOADON.MaHD,  HOADON.MaDMH,  HOADON.NgayLap,SANPHAM.MaSP ,SANPHAM.TenSP, CAST(CT_BAOGIA.DonGia AS INT) as DonGia,  " +
                    "CT_DONMUAHANG.SoLuong,   CAST((CT_BAOGIA.DonGia * CT_DONMUAHANG.SoLuong) AS INT) AS ThanhTien, SUM(CAST((CT_DONMUAHANG.SoLuong * CT_BAOGIA.DonGia) AS INT)) OVER (PARTITION BY HOADON.MaHD) " +
                    "as Tonghoadon,     HOADON.GhiChu, THANHTOAN.TrangThai FROM HOADON JOIN CT_DONMUAHANG ON HOADON.MaDMH =  CT_DONMUAHANG.MaDMH " +
                    "JOIN CT_BAOGIA ON CT_DONMUAHANG.MaBG = CT_BAOGIA.MaBG JOIN SANPHAM ON CT_DONMUAHANG.MaSP = CT_BAOGIA.MaSP JOIN THANHTOAN ON HOADON.MaHD=THANHTOAN.MaHD " +
                    "WHERE CT_DONMUAHANG.MaSP=CT_BAOGIA.MaSP and CT_BAOGIA.MaSP = SANPHAM.MaSP";
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
        public bool Taohoadon(DTOHoadon hd)
        {
            try
            {
                conn.Open();
                string myQuery = "Insert into HOADON (MaHD, MaDMH, NgayLap,GhiChu) values (@mahd, @madmh,@ngaylap,@ghichu)";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@mahd", hd.MaHD);
                cmd.Parameters.AddWithValue("@ngaylap", hd.Ngaylap.Date);
                cmd.Parameters.AddWithValue("@madmh", hd.MaDMH);
                cmd.Parameters.AddWithValue("@ghichu", hd.GhiChu);


                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public bool Kiemtramahd(string mahd)
        {
            try
            {
                conn.Open();
                string myQuery = "Select COUNT(*) from HOADON where MaHD = @mahd";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@mahd", mahd);

                int count = (int)cmd.ExecuteScalar();
                return count > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public bool Kiemtramadmh(string madmh)
        {
            try
            {
                conn.Open();
                string myQuery = "Select COUNT(*) from CT_DONMUAHANG where MaDMH  = @madmh";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@madmh", madmh);

                int count = (int)cmd.ExecuteScalar();
                return count > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
        public bool Capnhathoadon(DTOHoadon hd)
        {
            try
            {
                conn.Open();
                string myQuery = "Update HOADON set NgayLap = @ngaylap, MaDMH = @madh, GhiChu=@ghichu where MaHD = @mahd";
                SqlCommand cmd = new SqlCommand(myQuery, conn);
                cmd.Parameters.AddWithValue("@ngaylap", hd.Ngaylap.Date);
                cmd.Parameters.AddWithValue("@mahd", hd.MaHD);
                cmd.Parameters.AddWithValue("@madh", hd.MaDMH);
                cmd.Parameters.AddWithValue("@ghichu", hd.GhiChu);

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException) { return false; }
            finally { conn.Close(); }
        }
       public bool XoaThanhToan(DTOHoadon hd)
        {
            QLMHEntities4 qLMHEntities4 = new QLMHEntities4();
            try
            {

                THANHTOAN tt = qLMHEntities4.THANHTOANs.FirstOrDefault(a => a.MaHD == hd.MaHD);
                if (tt.TrangThai == "Đã thanh toán") return false;
                qLMHEntities4.THANHTOANs.Remove(tt);
                qLMHEntities4.SaveChanges();
                return true;

            }
            catch (Exception) { return false; }
        }
            
        public bool Xoahoadon(DTOHoadon hd)
        {
            QLMHEntities4 qLMHEntities4 = new QLMHEntities4();
            
            try
            {

                
                HOADON hdon = qLMHEntities4.HOADONs.FirstOrDefault(a => a.MaHD == hd.MaHD);
                qLMHEntities4.HOADONs.Remove(hdon);
                qLMHEntities4.SaveChanges();
                return true;

            }
            catch (Exception) { return false; }
           
        }
        public DataTable TimHoadon(string tukhoa)
        {
            try
            {
                conn.Open();
                string keyword = tukhoa; // Chuỗi tìm kiếm
                string query = @"
                                 SELECT Distinct HOADON.MaHD, HOADON.MaDMH, HOADON.NgayLap, SANPHAM.MaSP, SANPHAM.TenSP, 
                                 CAST(CT_BAOGIA.DonGia AS INT) as DonGia, CT_DONMUAHANG.SoLuong,  
                                 CAST((CT_BAOGIA.DonGia * CT_DONMUAHANG.SoLuong) AS INT) AS ThanhTien, 
                                 SUM(CAST((CT_DONMUAHANG.SoLuong * CT_BAOGIA.DonGia) AS INT)) 
                                 OVER (PARTITION BY HOADON.MaHD) as Tonghoadon, 
                                 HOADON.GhiChu, THANHTOAN.TrangThai 
                                 FROM HOADON 
                                 JOIN CT_DONMUAHANG ON HOADON.MaDMH = CT_DONMUAHANG.MaDMH 
                                 JOIN CT_BAOGIA ON CT_DONMUAHANG.MaBG = CT_BAOGIA.MaBG 
                                 JOIN SANPHAM ON CT_DONMUAHANG.MaSP = CT_BAOGIA.MaSP 
                                 JOIN THANHTOAN ON HOADON.MaHD = THANHTOAN.MaHD 
                                 WHERE CT_DONMUAHANG.MaSP = CT_BAOGIA.MaSP 
                                 AND CT_BAOGIA.MaSP = SANPHAM.MaSP 
                                 AND (LOWER(HOADON.MaHD) LIKE @keyword 
                                 OR LOWER(HOADON.MaDMH) LIKE @keyword 
                                 OR THANHTOAN.TrangThai LIKE @keyword 
                                 OR HOADON.GhiChu LIKE @keyword)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword.ToLower() + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception) { return null; }
            finally { conn.Close(); }
        }
        public DataTable loadmadmh()
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
            catch (SqlException) { return null; }
            finally { conn.Close(); }


        }
        public DataTable loadtensp(string madm)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from SANPHAM join CT_DONMUAHANG" +
                " on SANPHAM.MaSP = CT_DONMUAHANG.MaSP" +
                " where CT_DONMUAHANG.MaDMH = @madmh", conn);
                cmd.Parameters.AddWithValue("@madmh", madm);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException) { return null; }
            finally { conn.Close(); }
        }
        public DataTable loadsldg(string tensp)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from SANPHAM join CT_DONMUAHANG" +
                "on SANPHAM.MaSP = CT_DONMUAHANG.MaSP" + "join CT_BAOGIA on CT_DONMUAHANG.MaBG=CT_BAOGIA.MaBG " +
                " where SANPHAM.TenSP = @tensp", conn);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            catch (SqlException) { return null; }
            finally { conn.Close(); }
        }
    }
}
