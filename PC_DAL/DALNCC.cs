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


    }
}
