
using PC_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class DAL_NhanVien
    {
        public List<NHANVIEN> DangNhap()
        {

            using (QLMHEntities2 data = new QLMHEntities2())
            {
                return data.NHANVIENs.ToList();
            }
        }

        QLMHEntities2 db = new QLMHEntities2();
        public List<DTONV> LoadNV()
        {
            var listNV = from nv in db.NHANVIENs
                         select new DTONV
                         {
                             MaNV = nv.MaNV,
                             TenNV = nv.TenNV,
                             DiaChi = nv.DiaChi,
                             GioiTinh = nv.GioiTinh,
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
                new DTOPhongBan {PhongBan = "Bán hàng"},
                new DTOPhongBan {PhongBan = "Mua hàng"}
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
                using (var db = new QLMHEntities2())
                {
                    var existingNV = db.NHANVIENs.Find(dTONV.MaNV);
                    if (existingNV != null)
                    {
                        throw new Exception("Mã nhân viên đã tồn tại.");
                    }
                    db.NHANVIENs.Add(nv);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thêm nhân viên mới: {ex.Message}");
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
                            GioiTinh = nv.GioiTinh,
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
            db.SaveChanges();
        }
        public void XoaNV(DTONV dTONV)
        {
            var nv = db.NHANVIENs.Find(dTONV.MaNV);
            db.NHANVIENs.Remove(nv);
            db.SaveChanges();
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
                            GioiTinh = nv.GioiTinh,
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
                            GioiTinh = nv.GioiTinh,
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
                            GioiTinh = nv.GioiTinh,
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
                            GioiTinh = nv.GioiTinh,
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
                            GioiTinh = nv.GioiTinh,
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
                            GioiTinh = nv.GioiTinh,
                            SDT = nv.DienThoai,
                            ChucVu = nv.ChucVu,
                            PhongBan = nv.PhongBan
                        };
            return nvTim.ToList();
        }
    }
}
