using DoAnCK_TTA.BUS;
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
                mainWindow.Show();
                BUS_SYS_USER bus1 = new BUS_SYS_USER();
                bus1.CapNhatNhom(cbUsername.Text);
            }
            else
                MessageBox.Show("Username hoặc Password không đúng");
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
