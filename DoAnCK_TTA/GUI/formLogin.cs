using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            
            List<DTO_SYS_USER> ds = new List<DTO_SYS_USER>();
            DataTable dt = new DataTable();
            BUS_SYS_USER bus = new BUS_SYS_USER();
            dt = bus.LayLoginLuu();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                DTO_SYS_USER dTO = new DTO_SYS_USER();
                dTO.UserName = dt.Rows[i]["UserID"].ToString();
                //dTO.Password = (dt.Rows[i]["Password"].ToString());
                cbUsername.Properties.Items.Add(dt.Rows[i]["UserID"].ToString());
            }
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

                BUS_COMPANY ct = new BUS_COMPANY();
                DataTable dt = new DataTable();
                dt = ct.LayThongTinCongTy();
                if (dt.Rows.Count > 0)
                {
                    mainWindow.Show();
                    mainWindow.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                }
                else
                {
                    frmThongTinCongTy frmCongTy = new frmThongTinCongTy();
                    frmCongTy.ShowDialog();
                  
                }
                BUS_COMPANY ct2 = new BUS_COMPANY();
                DataTable dt2 = new DataTable();
                dt2 = ct2.LayThongTinCongTy();


                bus1.CapNhatLuu(checkSave.Checked, cbUsername.Text, txtPassword.Text);
               

                if (dt.Rows.Count > 0)
                {
                    mainWindow.Show();
                    mainWindow.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                    this.Hide();
                }
               else
                {
                    this.Close();
                }

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
            if(this.Tag!=null)
            log.Module = this.Tag.ToString();
            log.Action_Name = "Đăng Nhập";
            log.Created = DateTime.Now.ToString(); ;
            busLog.ThemLichSu(log);

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUsername_EditValueChanged(object sender, EventArgs e)
        {
            
        }
       
        private void cbUsername_EditValueChanged_1(object sender, EventArgs e)
        {
        }

        private void cbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BUS_SYS_USER bus = new BUS_SYS_USER();
            dt = bus.LayLoginLuu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               if(dt.Rows[i]["UserID"].ToString()==cbUsername.Text)
                {
                    txtPassword.Text = dt.Rows[i]["StockID"].ToString();
                }
            }
        }
    }
}
