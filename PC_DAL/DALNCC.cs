using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;


namespace PC_DAL
{
    public class DALNCC
    {
        QLMHEntities db = new QLMHEntities();
        public List<DTONCC> LoadNCC()
        {
            var listNCC = from ncc in db.NHACUNGCAPs
                         select new DTONCC
                         {
                            MaNCC = ncc.MaNCC,
                            TenNCC = ncc.TenNCC,
                            DiaChi = ncc.DiaChi,
                            SDT = ncc.SDT,
                            Email = ncc.Email
                         };
            return listNCC.ToList();
        }
        public void AddNCC(DTONCC dTONCC)
        {
            try
            {
                NHACUNGCAP ncc = new NHACUNGCAP()
                {
                    MaNCC = dTONCC.MaNCC,
                    TenNCC = dTONCC.TenNCC,
                    DiaChi = dTONCC.DiaChi,
                    SDT = dTONCC.SDT,
                    Email = dTONCC.Email
                };
                using (var db = new QLMHEntities())
                {
                    var existingNCC = db.NHACUNGCAPs.Find(dTONCC.MaNCC);
                    if (existingNCC != null)
                    {
                        throw new Exception("Mã nhà cung cấp đã tồn tại.");
                    }
                    db.NHACUNGCAPs.Add(ncc);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thêm nhà cung cấp: {ex.Message}");
            }
        }
        public List<DTONCC> TimNCC(string maTim)
        {
            try
            {
                var nccTim = from ncc in db.NHACUNGCAPs
                             where ncc.MaNCC == maTim
                             select new DTONCC
                             {
                                 MaNCC = ncc.MaNCC,
                                 TenNCC = ncc.TenNCC,
                                 DiaChi = ncc.DiaChi,
                                 SDT = ncc.SDT,
                                 Email = ncc.Email
                             };
                var result = nccTim.ToList();
                if (!result.Any())
                    throw new Exception("Không tồn tại nhà cung cấp có mã này.");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SuaNCC(DTONCC dTONCC)
        {
            var ncc = db.NHACUNGCAPs.Find(dTONCC.MaNCC);
            ncc.TenNCC = dTONCC.TenNCC;
            ncc.DiaChi = dTONCC.DiaChi;
            ncc.SDT = dTONCC.SDT;
            ncc.Email = dTONCC.Email;
            db.SaveChanges();
        }
        public void XoaNCC(DTONCC dTONCC)
        {
            var ncc = db.NHACUNGCAPs.Find(dTONCC.MaNCC);
            db.NHACUNGCAPs.Remove(ncc);
            db.SaveChanges();
        }
        public List<DTONCC> TimTuKhoaNCC(string tuKhoa)
        {
            try
            {
                var nccTim = from ncc in db.NHACUNGCAPs
                             where ncc.MaNCC.Contains(tuKhoa) || ncc.TenNCC.Contains(tuKhoa) || ncc.DiaChi.Contains(tuKhoa) || ncc.SDT.Contains(tuKhoa) || ncc.Email.Contains(tuKhoa)
                             select new DTONCC
                             {
                                 MaNCC = ncc.MaNCC,
                                 TenNCC = ncc.TenNCC,
                                 DiaChi = ncc.DiaChi,
                                 SDT = ncc.SDT,
                                 Email = ncc.Email
                             };
                var result = nccTim.ToList();
                if (!result.Any())
                    throw new Exception("Không tìm thấy nhà cung cấp phù hợp.");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<DTODGNCC> LoadDGNCC()
        {
            var listDG = from dg in db.DANHGIA_NCC
                          select new DTODGNCC
                          {
                              MaDGNCC = dg.MaDGNCC,
                              MaNCC = dg.MaNCC,
                              MaNV = dg.MaNV,
                              NgayDanhGia = dg.NgayDanhGia,
                              DiemChatLuong = dg.DiemChatLuong,
                              DiemGiaCa = dg.DiemGiaCa,
                              DiemHieuQua = dg.DiemHieuQua,
                              MucDoDanhGia = dg.MucDoDanhGia
                          };
            return listDG.ToList();
        }
        public List<DTONV> LoadNVDGNCC(string maDanhGia)
        {
            var listNV = (from dg in db.DANHGIA_NCC
                          join nv in db.NHANVIENs on dg.MaNV equals nv.MaNV
                          where dg.MaDGNCC == maDanhGia
                          select new DTONV
                          {
                              MaNV = nv.MaNV,
                              TenNV = nv.TenNV,
                              DiaChi = nv.DiaChi,
                              GioiTinh = nv.GioiTinh,
                              SDT = nv.DienThoai,
                              ChucVu = nv.ChucVu,
                              PhongBan = nv.PhongBan
                          }).ToList();
            return listNV;
        }
        public List<DTONCC> LoadNCCDG(string maDanhGia)
        {
            var listNCC = (from dg in db.DANHGIA_NCC
                           join ncc in db.NHACUNGCAPs on dg.MaNCC equals ncc.MaNCC
                           where dg.MaDGNCC == maDanhGia
                           select new DTONCC
                           {
                               MaNCC = ncc.MaNCC,
                               TenNCC = ncc.TenNCC,
                               DiaChi = ncc.DiaChi,
                               SDT = ncc.SDT,
                               Email = ncc.Email
                           }).ToList();

            return listNCC;
        }
        public void AddDGNCC(DTODGNCC dTODGNCC)
        {
            try
            {
                using (var db = new QLMHEntities())
                {
                    // Kiểm tra nhân viên có tồn tại
                    var isEmployeeExists = db.NHANVIENs.Any(nv => nv.MaNV == dTODGNCC.MaNV);
                    if (!isEmployeeExists)
                    {
                        throw new Exception("Nhân viên không tồn tại.");
                    }

                    // Kiểm tra nhà cung cấp có tồn tại
                    var isSupplierExists = db.NHACUNGCAPs.Any(ncc => ncc.MaNCC == dTODGNCC.MaNCC);
                    if (!isSupplierExists)
                    {
                        throw new Exception("Nhà cung cấp không tồn tại.");
                    }

                    // Kiểm tra đánh giá nhà cung cấp có tồn tại
                    var existingDGNCC = db.DANHGIA_NCC.Find(dTODGNCC.MaDGNCC);
                    if (existingDGNCC != null)
                    {
                        throw new Exception("Mã đánh giá nhà cung cấp đã tồn tại.");
                    }

                    // Thêm mới đánh giá nhà cung cấp
                    DANHGIA_NCC dg = new DANHGIA_NCC()
                    {
                        MaDGNCC = dTODGNCC.MaDGNCC,
                        MaNV = dTODGNCC.MaNV,
                        MaNCC = dTODGNCC.MaNCC,
                        DiemChatLuong = dTODGNCC.DiemChatLuong,
                        DiemHieuQua = dTODGNCC.DiemHieuQua,
                        DiemGiaCa = dTODGNCC.DiemGiaCa,
                        MucDoDanhGia = dTODGNCC.MucDoDanhGia,
                        NgayDanhGia = DateTime.Now
                    };

                    db.DANHGIA_NCC.Add(dg);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thêm đánh giá mới: {ex.Message}");
            }
        }

        public List<DTOHieuQua> LoadDiemHieuQua()
        {
            List<DTOHieuQua> list = new List<DTOHieuQua>
            {
                new DTOHieuQua { DiemHieuQua = 1},
                new DTOHieuQua {DiemHieuQua = 2},
                new DTOHieuQua {DiemHieuQua = 3},
                new DTOHieuQua {DiemHieuQua = 4},
                new DTOHieuQua {DiemHieuQua = 5}
            };
            return list;
        }
        public List<DTOChatLuong> LoadDiemChatLuong()
        {
            List<DTOChatLuong> list = new List<DTOChatLuong>
            {
                new DTOChatLuong { DiemChatLuong = 1},
                new DTOChatLuong {DiemChatLuong = 2},
                new DTOChatLuong {DiemChatLuong = 3},
                new DTOChatLuong {DiemChatLuong = 4},
                new DTOChatLuong {DiemChatLuong = 5}
            };
            return list;
        }
        public List<DTOGiaCa> LoadDiemGiaCa()
        {
            List<DTOGiaCa> list = new List<DTOGiaCa>
            {
                new DTOGiaCa { DiemGiaCa = 1},
                new DTOGiaCa {DiemGiaCa = 2},
                new DTOGiaCa {DiemGiaCa = 3},
                new DTOGiaCa {DiemGiaCa = 4},
                new DTOGiaCa {DiemGiaCa = 5}
            };
            return list;
        }
        public List<DTOMucDo> LoadMucDoDG()
        {
            List<DTOMucDo> list = new List<DTOMucDo>
            {
                new DTOMucDo { MucDoDanhGia = "Tốt"},
                new DTOMucDo { MucDoDanhGia = "Trung bình"},
                new DTOMucDo { MucDoDanhGia = "Kém"}
            };
            return list;
        }
        public List<DTODGNCC> TimDGNCC(string maTim)
        {
            try
            {
                var dgTim = from dg in db.DANHGIA_NCC
                             where dg.MaDGNCC == maTim
                             select new DTODGNCC
                             {
                                 MaDGNCC = dg.MaDGNCC,
                                 MaNV = dg.MaNV,
                                 MaNCC = dg.MaNCC,
                                 NgayDanhGia = dg.NgayDanhGia,
                                 DiemChatLuong = dg.DiemChatLuong,
                                 DiemHieuQua = dg.DiemHieuQua,
                                 DiemGiaCa = dg.DiemGiaCa,
                                 MucDoDanhGia = dg.MucDoDanhGia
                             };
                var result = dgTim.ToList();
                if (!result.Any())
                    throw new Exception("Không tồn tại mã đánh giá này.");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SuaDGNCC(DTODGNCC dTODGNCC)
        {
            try
            {
                using (var db = new QLMHEntities())
                {
                    var isEmployeeExists = db.NHANVIENs.Any(nv => nv.MaNV == dTODGNCC.MaNV);
                    if (!isEmployeeExists)
                    {
                        throw new Exception("Nhân viên không tồn tại.");
                    }

                    var isSupplierExists = db.NHACUNGCAPs.Any(ncc => ncc.MaNCC == dTODGNCC.MaNCC);
                    if (!isSupplierExists)
                    {
                        throw new Exception("Nhà cung cấp không tồn tại.");
                    }

                    var dg = db.DANHGIA_NCC.Find(dTODGNCC.MaDGNCC);
                    dg.MaNV = dTODGNCC.MaNV;
                    dg.MaNCC = dTODGNCC.MaNCC;
                    dg.NgayDanhGia = DateTime.Now;
                    dg.DiemChatLuong = dTODGNCC.DiemChatLuong;
                    dg.DiemHieuQua = dTODGNCC.DiemHieuQua;
                    dg.DiemGiaCa = dTODGNCC.DiemGiaCa;
                    dg.MucDoDanhGia = dTODGNCC.MucDoDanhGia;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi cập nhật đánh giá nhà cung cấp: {ex.Message}");
            }
        }
        public void XoaDGNCC(DTODGNCC dTODGNCC)
        {
            var dg = db.DANHGIA_NCC.Find(dTODGNCC.MaDGNCC);
            db.DANHGIA_NCC.Remove(dg);
            db.SaveChanges();
        }




    }
}
