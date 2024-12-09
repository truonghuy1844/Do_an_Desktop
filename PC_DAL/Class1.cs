using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PC_DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=LAPTOP-P7MATAOO\\DUYMANH;Initial Catalog=QLMH;Integrated Security=True;Encrypt=False");
    }
}
