using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.SqlServer;


namespace PC_DAL
{
    public class DALNhanVien
    {

        public List<NHANVIEN> DangNhap()
        {

                using (QLMHEntities data = new QLMHEntities())
            {
                return data.NHANVIENs.ToList();
            }    
        }

    }
}
