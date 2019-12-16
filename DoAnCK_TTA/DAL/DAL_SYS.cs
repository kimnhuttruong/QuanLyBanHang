using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DAL
{
    class DAL_SYS:DB_Connect
    {
        public string SaoLuu(string u)
        {

            u = u + "\\backupdate_" + DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "") + ".bak";
            u=u.Replace(@"\\",@"\");
            using (FileStream fs = File.Create(u))
            {
            }
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"declare @ten nvarchar(30) set @ten=DB_NAME()   BACKUP DATABASE  @ten TO DISK='" + u + "'";
                try
                {
                    OpenConnection();
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    return "1";
                }
                catch
                {
                  
                    return u;
                }
           
        }
        public DataTable LayDanhTenDatabase()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " declare @ten nvarchar(30) set @ten=DB_NAME()    select @ten as Ten";
            try
            {
                OpenConnection();
                da.SelectCommand = cmd;
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public string PhucHoi(string u)
        {
            DAL_SYS dAL_SYS = new DAL_SYS();
            DataTable dt = new DataTable();
            dt = dAL_SYS.LayDanhTenDatabase();
            string ten = dt.Rows[0][0].ToString();


            u = u.Replace(@"\\", @"\");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"use master RESTORE DATABASE "+ten+" FROM  DISK = N'" + u+"' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10 ";
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return "1";
            }
            catch
            {

                return u;
            }

        }
    }
}
