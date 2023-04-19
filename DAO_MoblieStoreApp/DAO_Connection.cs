using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_MoblieStoreApp
{
    public class DAO_Connection
    {
        public SqlConnection Connect()
        {
            string cnstr = "Data Source=Climax;Initial Catalog=IMPROOKV1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cnstr);
            return conn;
        }
    }
}
