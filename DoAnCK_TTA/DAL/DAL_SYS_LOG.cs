using DoAnCK_TTA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK_TTA.DAL
{
   public  class DAL_SYS_LOG:DB_Connect
    {
        public int ThemLichSu(DTO_SYS_LOG u)
        {
            int active;
            if (u.Active)
                active = 1;
            else
                active = 0;
            string ma = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT [dbo].[SYS_LOG]  (SYS_ID,UserID,MChine,Created,Module,Action_Name,Reference) VALUES ('" + ma + "', N'" + u.UserID + "', N'" + u.MChine + "', N'" + u.Created + "',N'"+u.Module+"',N'"+u.Action_Name+ "',N'" + u.Reference + "')";
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public DataTable LayThongTinLog()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SYS_LOG";
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
    }
}
