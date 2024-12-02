﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using PC_DTO;

namespace PC_DAL
{
    public class DALNV
    {
        QLMHEntities db = new QLMHEntities();
        public List<DTONV> LoadNV()
        {
            var listNV = from nv in db.NHANVIENs
                         select new DTONV
                         {
                             MaNV = nv.MaNV,
                             TenNV = nv.TenNV,
                             DiaChi = nv.DiaChi,
                             GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                             SDT = nv.DienThoai,
                             ChucVu = nv.ChucVu,
                             PhongBan = nv.PhongBan
                         };
            return listNV.ToList();
        }
        public List<DTOChucVu> LoadChucVu()
        {
            List<DTOChucVu> chucVuList = new List<DTOChucVu>
            {
                new DTOChucVu { ChucVu = "Trưởng phòng" },
                new DTOChucVu { ChucVu = "Nhân viên" },
                new DTOChucVu { ChucVu = "Quản lý" }
            };

            return chucVuList;
        }
        public List<DTOPhongBan> LoadPhongBan()
        {
            List<DTOPhongBan> phongBanList = new List<DTOPhongBan>
            {
                new DTOPhongBan { PhongBan = "Kinh doanh" },
                new DTOPhongBan { PhongBan = "Tài chính" },
                new DTOPhongBan { PhongBan = "Kế toán" },
                new DTOPhongBan {PhongBan = "Nhân sự"},
                new DTOPhongBan {PhongBan = "Sản xuất"},
                new DTOPhongBan {PhongBan = "Kỹ thuật"},
                new DTOPhongBan {PhongBan = "Marketing"},
                new DTOPhongBan {PhongBan = "Bán hàng"}
            };
            return phongBanList;
        }
        public void AddNV(DTONV dTONV)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN()
                {
                    MaNV = dTONV.MaNV,             
                    TenNV = dTONV.TenNV,           
                    DiaChi = dTONV.DiaChi,         
                    GioiTinh = dTONV.GioiTinh,     
                    DienThoai = dTONV.SDT,         
                    ChucVu = dTONV.ChucVu,         
                    PhongBan = dTONV.PhongBan
                };
                using (var db = new QLMHEntities())
                {
                    db.NHANVIENs.Add(nv);  
                    db.SaveChanges();  
                }
            }
            catch (Exception ex) {
                throw new Exception("Có lỗi trong lúc thêm nhân viên mới: " + ex.Message);
            }
        }
        public List<DTONV> TimNhanVien(string maNV)
        {
            var nvTim = from nv in db.NHANVIENs
                         where nv.MaNV == maNV
                         select new DTONV
                         {
                             MaNV = nv.MaNV,
                             TenNV = nv.TenNV,
                             DiaChi = nv.DiaChi,
                             GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                             SDT = nv.DienThoai,
                             ChucVu = nv.ChucVu,
                             PhongBan = nv.PhongBan
                         };
            return nvTim.ToList();
        }
        public void SuaNV(DTONV dTONV)
        {
            var nv = db.NHANVIENs.Find(dTONV.MaNV);
            nv.TenNV = dTONV.TenNV;
            nv.DiaChi = dTONV.DiaChi;
            nv.GioiTinh = dTONV.GioiTinh;
            nv.DienThoai = dTONV.SDT;
            nv.ChucVu = dTONV.ChucVu;
            nv.PhongBan = dTONV.PhongBan;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi cập nhật thông tin: {ex.Message}");
            }
        }
        public void XoaNV(DTONV dTONV)
        {
            var nv = db.NHANVIENs.Find(dTONV.MaNV);
            if (nv != null)
            {
                try
                {
                    db.NHANVIENs.Remove(nv);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi xóa nhân viên: {ex.Message}");
                }
            }
        }
        public List<DTONV> TimNhanVienChucVu(string maNV, string chucVu)
        {
            var nvTim = from nv in db.NHANVIENs
                        where nv.MaNV == maNV && chucVu == nv.ChucVu
                        select new DTONV
                        {
                            MaNV = nv.MaNV,
                            TenNV = nv.TenNV,
                            DiaChi = nv.DiaChi,
                            GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                            SDT = nv.DienThoai,
                            ChucVu = nv.ChucVu,
                            PhongBan = nv.PhongBan
                        };
            return nvTim.ToList();
        }
        public List<DTONV> TimNhanVienPhongBan(string maNV, string phongBan)
        {
            var nvTim = from nv in db.NHANVIENs
                        where nv.MaNV == maNV && phongBan == nv.PhongBan
                        select new DTONV
                        {
                            MaNV = nv.MaNV,
                            TenNV = nv.TenNV,
                            DiaChi = nv.DiaChi,
                            GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                            SDT = nv.DienThoai,
                            ChucVu = nv.ChucVu,
                            PhongBan = nv.PhongBan
                        };
            return nvTim.ToList();
        }
        public List<DTONV> TimNhanVienChucVuVaPhongBan(string maNV, string chucVu, string phongBan)
        {
            var nvTim = from nv in db.NHANVIENs
                        where nv.MaNV == maNV && chucVu == nv.ChucVu && phongBan == nv.PhongBan
                            select new DTONV
                            {
                                MaNV = nv.MaNV,
                                TenNV = nv.TenNV,
                                DiaChi = nv.DiaChi,
                                GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                                SDT = nv.DienThoai,
                                ChucVu = nv.ChucVu,
                                PhongBan = nv.PhongBan
                            };
            return nvTim.ToList();
        }
        public List<DTONV> TimChucVuVaPhongBan(string chucVu, string phongBan)
        {
            var nvTim = from nv in db.NHANVIENs
                        where chucVu == nv.ChucVu && phongBan == nv.PhongBan
                            select new DTONV
                            {
                                MaNV = nv.MaNV,
                                TenNV = nv.TenNV,
                                DiaChi = nv.DiaChi,
                                GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                                SDT = nv.DienThoai,
                                ChucVu = nv.ChucVu,
                                PhongBan = nv.PhongBan
                            };
            return nvTim.ToList();
        }
        public List<DTONV> TimChucVu(string chucVu)
        {
            var nvTim = from nv in db.NHANVIENs
                        where chucVu == nv.ChucVu
                        select new DTONV
                        {
                            MaNV = nv.MaNV,
                            TenNV = nv.TenNV,
                            DiaChi = nv.DiaChi,
                            GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                            SDT = nv.DienThoai,
                            ChucVu = nv.ChucVu,
                            PhongBan = nv.PhongBan
                        };
            return nvTim.ToList();
        }
        public List<DTONV> TimPhongBan(string phongBan)
        {
            var nvTim = from nv in db.NHANVIENs
                        where phongBan == nv.PhongBan
                        select new DTONV
                        {
                            MaNV = nv.MaNV,
                            TenNV = nv.TenNV,
                            DiaChi = nv.DiaChi,
                            GioiTinh = nv.GioiTinh.HasValue ? nv.GioiTinh.Value : false,
                            SDT = nv.DienThoai,
                            ChucVu = nv.ChucVu,
                            PhongBan = nv.PhongBan
                        };
            return nvTim.ToList();
        }

    }
}
