using DoAnCK_TTA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK_TTA.DAL
{
    public class DAL_SYS_USER:DB_Connect
    {
        private string MaHoa(string text)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(text);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
           
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa 
            string pw = sb.ToString();
            return sb.ToString();

        }

        public bool LayDanhSachPhanQuyen(string username,   string password)
        {
            password = MaHoa(password);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SYS_USER where UserName='" + username + "' and Password='" + password + "'";
            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public DataTable LayThongTinPhanQuyen(string Group_ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select UserName, g.Group_Name,u.Description,u.Active,g.Group_Name,g.Group_ID from SYS_USER u join SYS_GROUP g on u.Group_ID = g.Group_ID where g.Group_ID = '" + Group_ID + "'";
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
        public DataTable LayThongTinVaiTro()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT UserName,Group_ID,Password FROM dbo.SYS_USER";
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
        public DataTable LayThongTinUSER()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from FORM";
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
        public int ThemNguoiDung(DTO_SYS_USER u)
        {
            int active;
            if (u.Active)
                active = 1;
            else
                active = 0;
            string ma= DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT [dbo].[SYS_USER] VALUES ('" + ma + "', N'" + u.UserName + "', N'"+MaHoa(u.Password)+"', N'" +u.Group_ID+"',N'',N'',"+ active + ",'"+u.Employee_ID+"')";
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
        public int XoaNguoiDung(string u)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete [dbo].[SYS_GROUP]  where Group_ID='" + u + "' and Group_ID !='admin'  Delete [dbo].[SYS_USER]  where Group_ID='" + u + "' and Group_ID !='admin'  ";
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
        public int CapNhatNhom(string u)
        {
           
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "  declare @nhom nvarchar(30) select @nhom = u.Group_ID from SYS_USER u where u.UserName = N'"+u+ "'  update FOrm set Description = @nhom    update FOrm set ENCaption = N'" + u + "'      update FOrm set Form_Caption = @@SERVERNAME  ";
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
        public int CapNhatMatKhau(string tk,string mkc,string mkm)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE dbo.SYS_USER SET Password ='" + MaHoa(mkm) + "' WHERE UserName = '" + tk + "' AND Password = '" + MaHoa(mkc) + "'";
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
        public int CapNhatLuu(bool isSave,string user,string password)
        {
            int save;
            if (isSave)
                save = 1;
            else
                save = 0;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            if(isSave)
                cmd.CommandText = "Delete SYS_USER_STOCK where UserID='"+ user + "'  Insert into SYS_USER_STOCK values ('"+user+"','"+password+"',1)";
            else
                cmd.CommandText = "Delete SYS_USER_STOCK where UserID='" + user + "'";
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
        public DataTable LayLoginLuu()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SYS_USER_STOCK ";
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
