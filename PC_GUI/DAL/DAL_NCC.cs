using PC_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class DAL_NCC
    {
        QLMHEntities4 db = new QLMHEntities4();
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
                using (var db = new QLMHEntities4())
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
                             TieuChiDanhGia = dg.TieuChiDanhGia,
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
        public void AddDGNCC(DTODGNCC dTODGNCC, string maNCC, List<string> listDGSP, DateTime? frmDate, DateTime? toDate)
        {
            try
            {
                using (var db = new QLMHEntities4())
                {
                    if (!db.NHANVIENs.Any(nv => nv.MaNV == dTODGNCC.MaNV))
                    {
                        throw new Exception("Nhân viên không tồn tại.");
                    }

                    if (!db.NHACUNGCAPs.Any(ncc => ncc.MaNCC == dTODGNCC.MaNCC))
                    {
                        throw new Exception("Nhà cung cấp không tồn tại.");
                    }

                    if (db.DANHGIA_NCC.Any(dgncc => dgncc.MaDGNCC == dTODGNCC.MaDGNCC))
                    {
                        throw new Exception("Mã đánh giá nhà cung cấp đã tồn tại.");
                    }

                    double? diemChatLuong = null;
                    double? diemHieuQua = null;
                    double? diemGiaCa = null;

                    if (listDGSP != null && listDGSP.Any())
                    {
                        var query = from dgsp in db.DANHGIASP_TRONGDON
                                    where listDGSP.Contains(dgsp.MaDGSP)
                                    select new
                                    {
                                        dgsp.DiemChatLuong,
                                        dgsp.DiemHieuQua,
                                        dgsp.DiemGiaCa
                                    };

                        var result = query.ToList();
                        if (result.Any())
                        {
                            diemChatLuong = result.Average(x => x.DiemChatLuong);
                            diemHieuQua = result.Average(x => x.DiemHieuQua);
                            diemGiaCa = result.Average(x => x.DiemGiaCa);
                        }
                    }
                    else if (frmDate.HasValue && toDate.HasValue)
                    {
                        var query = (from dgsp in db.DANHGIASP_TRONGDON
                                     join dmh in db.DONMUAHANGs on dgsp.MaDMH equals dmh.MaDMH
                                     where dmh.MaNCC == maNCC
                                           && dgsp.NgayDG >= frmDate.Value
                                           && dgsp.NgayDG <= toDate.Value
                                     select new
                                     {
                                         dgsp.DiemChatLuong,
                                         dgsp.DiemHieuQua,
                                         dgsp.DiemGiaCa
                                     });

                        var result = query.ToList();
                        if (result.Any())
                        {
                            diemChatLuong = result.Average(x => x.DiemChatLuong);
                            diemHieuQua = result.Average(x => x.DiemHieuQua);
                            diemGiaCa = result.Average(x => x.DiemGiaCa);
                        }
                    }

                    string mucDoDanhGia = "Chưa đánh giá";
                    if (diemChatLuong.HasValue && diemHieuQua.HasValue && diemGiaCa.HasValue)
                    {
                        double diemTrungBinh = (diemChatLuong.Value + diemHieuQua.Value + diemGiaCa.Value) / 3;

                        if (diemTrungBinh >= 4)
                            mucDoDanhGia = "Tốt";
                        else if (diemTrungBinh >= 2.5)
                            mucDoDanhGia = "Trung bình";
                        else
                            mucDoDanhGia = "Thấp";
                    }
                    var dg = new DANHGIA_NCC
                    {
                        MaDGNCC = dTODGNCC.MaDGNCC,
                        MaNV = dTODGNCC.MaNV,
                        MaNCC = dTODGNCC.MaNCC,
                        TieuChiDanhGia = dTODGNCC.TieuChiDanhGia,
                        DiemChatLuong = diemChatLuong,
                        DiemHieuQua = diemHieuQua,
                        DiemGiaCa = diemGiaCa,
                        MucDoDanhGia = mucDoDanhGia,
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
        public void AddDGNCC_SPDMH(string maDGNCC, string maNCC, List<string> listDGSP, DateTime? frmDate, DateTime? toDate)
        {
            if (listDGSP != null && listDGSP.Any())
            {
                foreach (var maDGSP in listDGSP)
                {
                    var danhGiaNCC_SPDMH = new DanhGiaNCC_SPDMH
                    {
                        MaDGNCC = maDGNCC,
                        MaDGSP = maDGSP,
                        ChuThich = string.Empty,
                    };
                    db.DanhGiaNCC_SPDMH.Add(danhGiaNCC_SPDMH);

                }
            }
            else if (frmDate.HasValue && toDate.HasValue)
            {
                var danhGiaList = (from dgsp in db.DANHGIASP_TRONGDON
                                   join dmh in db.DONMUAHANGs on dgsp.MaDMH equals dmh.MaDMH
                                   where dmh.MaNCC == maNCC
                                         && dgsp.NgayDG >= frmDate.Value
                                         && dgsp.NgayDG <= toDate.Value
                                   select dgsp).ToList();
                foreach (var dg in danhGiaList)
                {
                    var danhGiaNCC_SPDMH = new DanhGiaNCC_SPDMH
                    {
                        MaDGNCC = maDGNCC,
                        MaDGSP = dg.MaDGSP,
                        ChuThich = string.Empty
                    };
                    db.DanhGiaNCC_SPDMH.Add(danhGiaNCC_SPDMH);
                }
            }
            db.SaveChanges();
        }

        public List<DTOTieuChiDanhGia> LoadTieuChi()
        {
            List<DTOTieuChiDanhGia> list = new List<DTOTieuChiDanhGia>
            {
                new DTOTieuChiDanhGia { TieuChiDanhGia = "Theo tất cả đơn hàng"},
                new DTOTieuChiDanhGia {TieuChiDanhGia = "Theo đánh giá đơn hàng tùy chọn"},
                new DTOTieuChiDanhGia {TieuChiDanhGia = "Theo ngày tùy chọn"}
            };
            return list;
        }
        public List<DTOTieuChiSearch> TieuChiSearch()
        {
            List<DTOTieuChiSearch> list = new List<DTOTieuChiSearch>
            {
                new DTOTieuChiSearch { TieuChiDanhGia = "Chọn tất cả"},
                new DTOTieuChiSearch { TieuChiDanhGia = "Theo tất cả đơn hàng"},
                new DTOTieuChiSearch {TieuChiDanhGia = "Theo đánh giá đơn hàng tùy chọn"},
                new DTOTieuChiSearch {TieuChiDanhGia = "Theo ngày tùy chọn"}
            };
            return list;
        }
        public List<DTODSDMH> LoadTieuChiDMH(string maNCC)
        {
            try
            {
                var isSupplierExists = db.NHACUNGCAPs.Any(ncc => ncc.MaNCC == maNCC);
                if (!isSupplierExists)
                {
                    throw new Exception("Nhà cung cấp không tồn tại.");
                }
                var result = from dgsp in db.DANHGIASP_TRONGDON
                             join dmh in db.DONMUAHANGs on dgsp.MaDMH equals dmh.MaDMH
                             join sp in db.SANPHAMs on dgsp.MaSP equals sp.MaSP
                             join ncc in db.NHACUNGCAPs on dmh.MaNCC equals ncc.MaNCC
                             join dgncc in db.DANHGIA_NCC on ncc.MaNCC equals dgncc.MaNCC
                             where dmh.MaNCC == maNCC
                             group new { dgsp, sp } by dgsp.MaDGSP into g
                             select new DTODSDMH
                             {
                                 MaDGSP = g.Key,
                                 MaDMH = g.FirstOrDefault().dgsp.MaDMH,
                                 MaSP = g.FirstOrDefault().sp.MaSP,
                                 TenSP = g.FirstOrDefault().sp.TenSP
                             };
                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi tìm đơn mua hàng: {ex.Message}");
            }
        }
        public List<DTODSDMH> LoadDMHChon(string maDGNCC)
        {
            var listDGSP = from dgsp in db.DANHGIASP_TRONGDON
                           join sp in db.SANPHAMs on dgsp.MaSP equals sp.MaSP
                           join dgtg in db.DanhGiaNCC_SPDMH on dgsp.MaDGSP equals dgtg.MaDGSP
                           where dgtg.MaDGNCC == maDGNCC
                           select new DTODSDMH
                           {
                               MaDGSP = dgtg.MaDGSP,
                               MaDMH = dgsp.MaDMH,
                               MaSP = dgsp.MaSP,
                               TenSP = sp.TenSP
                           };
            return listDGSP.ToList();
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
                                MucDoDanhGia = dg.MucDoDanhGia,
                                TieuChiDanhGia = dg.TieuChiDanhGia
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
        public void XoaDGNCC(string maDGNCC, List<string> listDGSP)
        {
            var recordsToDelete = db.DanhGiaNCC_SPDMH
                            .Where(x => x.MaDGNCC == maDGNCC)
                            .ToList();

            if (recordsToDelete.Any())
            {
                db.DanhGiaNCC_SPDMH.RemoveRange(recordsToDelete);
            }

            var dgncc = db.DANHGIA_NCC.Find(maDGNCC);
            if (dgncc != null)
            {
                db.DANHGIA_NCC.Remove(dgncc);
            }

            db.SaveChanges();
        }
        public List<DTODGNCC> LocDGNCC(string tuKhoa, string mucDo, DateTime fromDate, DateTime toDate, List<string> tieuChiDanhGia)
        {
            var query = db.DANHGIA_NCC.AsQueryable();

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(dg => dg.MaDGNCC.Contains(tuKhoa) || dg.MaNV.Contains(tuKhoa) || dg.MaNCC.Contains(tuKhoa));
            }

            if (!string.IsNullOrEmpty(mucDo))
            {
                query = query.Where(dg => dg.MucDoDanhGia == mucDo);
            }
            if (tieuChiDanhGia != null && tieuChiDanhGia.Any())
            {
                query = query.Where(dg => tieuChiDanhGia.Contains(dg.TieuChiDanhGia));
            }

            query = query.Where(dg => dg.NgayDanhGia >= fromDate && dg.NgayDanhGia <= toDate);

            return query.Select(dg => new DTODGNCC
            {
                MaDGNCC = dg.MaDGNCC,
                MaNV = dg.MaNV,
                MaNCC = dg.MaNCC,
                NgayDanhGia = dg.NgayDanhGia,
                DiemChatLuong = dg.DiemChatLuong,
                DiemHieuQua = dg.DiemHieuQua,
                DiemGiaCa = dg.DiemGiaCa,
                MucDoDanhGia = dg.MucDoDanhGia,
                TieuChiDanhGia = dg.TieuChiDanhGia
            }).ToList();

        }
        public List<DTODGDMH> LoadDGDMH(string maDGNCC)
        {
            var listDGSP = from dgsp in db.DANHGIASP_TRONGDON
                           join dgtg in db.DanhGiaNCC_SPDMH on dgsp.MaDGSP equals dgtg.MaDGSP
                           where dgtg.MaDGNCC == maDGNCC
                           select new DTODGDMH
                           {
                               MaDGSP = dgtg.MaDGSP,
                               MaDMH = dgsp.MaDMH,
                               MaSP = dgsp.MaSP,
                               NgayDG = dgsp.NgayDG,
                               MoTaDG = dgsp.MoTaDG,
                               DiemChatLuong = dgsp.DiemChatLuong,
                               DiemGiaCa = dgsp.DiemGiaCa,
                               DiemHieuQua = dgsp.DiemHieuQua,
                               GhiChu = dgsp.GhiChu
                           };
            return listDGSP.ToList();
        }
        public List<DTODGNCCReport> LoadDGNCCReport()
        {
            var listDG = from dg in db.DANHGIA_NCC
                         join ncc in db.NHACUNGCAPs on dg.MaNCC equals ncc.MaNCC
                         where dg.TieuChiDanhGia == "Theo tất cả đơn hàng" && dg.MucDoDanhGia == "Tốt"
                         select new DTODGNCCReport
                         {
                             MaDGNCC = dg.MaDGNCC,
                             MaNCC = dg.MaNCC,
                             TenNCC = ncc.TenNCC,
                             NgayDanhGia = dg.NgayDanhGia,
                             TieuChiDanhGia = dg.TieuChiDanhGia,
                             DiemChatLuong = dg.DiemChatLuong,
                             DiemGiaCa = dg.DiemGiaCa,
                             DiemHieuQua = dg.DiemHieuQua,
                             MucDoDanhGia = dg.MucDoDanhGia
                         };
            return listDG.ToList();
        }
    }
}
