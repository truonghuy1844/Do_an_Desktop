using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;

namespace PC_DAL
{
    public class DALKho
    {
        QLMHEntities db = new QLMHEntities();
        public List<DTOKho> LoadKho()
        {
            var listKho = from k in db.KHOHANGs
                         select new DTOKho  
                         {
                            MaKho = k.MaKho,
                            TenKho = k.TenKho,
                            LoaiKho = k.LoaiKho,
                            SucChua = k.Suc_Chua,
                            DiaChi = k.DiaChi,
                         };
            return listKho.ToList();
        }
        public void AddKho(DTOKho dTOKho)
        {
            try
            {
                KHOHANG kh = new KHOHANG()
                {
                   MaKho = dTOKho.MaKho,
                   TenKho= dTOKho.TenKho,
                   DiaChi = dTOKho.DiaChi,
                   Suc_Chua = dTOKho.SucChua,
                   LoaiKho = dTOKho.LoaiKho

                };
                using (var db = new QLMHEntities())
                {
                    var existingKho = db.KHOHANGs.Find(dTOKho.MaKho);
                    if (existingKho != null)
                    {
                        throw new Exception("Mã kho đã tồn tại.");
                    }
                    db.KHOHANGs.Add(kh);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thêm kho mới: {ex.Message}");
            }
        }
        public List<DTOLoaiKho> LoadLoaiKho()
        {
            List<DTOLoaiKho> listLoai = new List<DTOLoaiKho>
            {
                new DTOLoaiKho { LoaiKho = "Nguyên liệu" },
                new DTOLoaiKho { LoaiKho = "Thành phẩm" },
                new DTOLoaiKho { LoaiKho = "Bao bì" }
            };

            return listLoai;
        }
        public List<DTOKho> TimKho(string maKho)
        {
            var khoTim = from kh in db.KHOHANGs
                        where kh.MaKho == maKho
                        select new DTOKho
                        {
                            MaKho = kh.MaKho,
                            TenKho = kh.TenKho,
                            DiaChi = kh.DiaChi,
                            SucChua = kh.Suc_Chua,
                            LoaiKho = kh.LoaiKho
                        };
            return khoTim.ToList();
        }
        public void SuaKho(DTOKho dTOKho)
        {
            var kh = db.KHOHANGs.Find(dTOKho.MaKho);
            kh.MaKho = dTOKho.MaKho;
            kh.TenKho = dTOKho.TenKho;
            kh.LoaiKho = dTOKho.LoaiKho;
            kh.DiaChi = dTOKho.DiaChi;
            kh.Suc_Chua = dTOKho.SucChua;
            db.SaveChanges();
        }
        public void XoaKho(DTOKho dTOKho)
        {
            var kh = db.KHOHANGs.Find(dTOKho.MaKho);
            db.KHOHANGs.Remove(kh);
            db.SaveChanges();
        }
    }

}
