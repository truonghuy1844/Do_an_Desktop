using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_GUI.DAL
{
    public class ConnectDB_Manual
    {
        protected SqlConnection conn = new SqlConnection("Data Source=HUY-LAPTOP;Initial Catalog=QLMH;Integrated Security=True;Encrypt=False");
    }
}
