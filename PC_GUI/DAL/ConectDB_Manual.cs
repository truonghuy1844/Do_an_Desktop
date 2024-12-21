using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class ConectDB_Manual
    {
        protected SqlConnection conn = new SqlConnection("Data Source=LAPTOP-H76O771H\\MSSQLSERVER1;Initial Catalog=QLMH;Integrated Security=True;Encrypt=False");
    }
}
