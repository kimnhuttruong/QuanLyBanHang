using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK_TTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("Tùy CHọn");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BUS_SYS_USER bus = new BUS_SYS_USER();
            bool isKiemTra=bus.CheckLogin(cbUsername.Text, txtPassword.Text);

            if (isKiemTra == true)
            {
                var mainWindow = new formMain();
                mainWindow.Sender(cbUsername.Text);
                BUS_SYS_USER bus1 = new BUS_SYS_USER();
                bus1.CapNhatNhom(cbUsername.Text);
              
                mainWindow.Show();
                mainWindow.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                this.Hide();

            }
            else
                MessageBox.Show("Username hoặc Password không đúng");

            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Đăng Nhập";
            busLog.ThemLichSu(log);

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
