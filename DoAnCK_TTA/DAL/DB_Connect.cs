using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DAL
{
    public class DB_Connect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-93FGSRM\SQLEXPRESS;Initial Catalog=UDQL1_DA;Integrated Security=True");

        public void OpenConnection()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }
}

