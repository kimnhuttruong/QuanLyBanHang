using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }


        private void btnAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // do something else
            var mainWindow = new frmThemVaiTro();
            mainWindow.Show();
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BUS_EMPLOYEE bus = new BUS_EMPLOYEE();
            dt = bus.LayThongTinNhanVien();

            cbNhanVien.Properties.DataSource = dt;
            cbNhanVien.Properties.DisplayMember = "Employee_Name";
            cbNhanVien.Properties.ValueMember = "Employee_ID";

            DataTable dt1 = new DataTable();
            BUS_GROUP bus1 = new BUS_GROUP();
            dt1 = bus1.LayThongTinGroup();

            cbVaiTro.Properties.DataSource = dt1;
            cbVaiTro.Properties.DisplayMember = "Group_Name";
            cbVaiTro.Properties.ValueMember = "Group_ID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            DTO_SYS_USER u = new DTO_SYS_USER();

            DataRowView selectedDataRow = (DataRowView)cbNhanVien.GetSelectedDataRow();
            DataRowView selectedDataRow1 = (DataRowView)cbVaiTro.GetSelectedDataRow();
            u.Employee_ID = selectedDataRow.Row["Employee_ID"].ToString();

            u.UserName = txtUserName.Text;
            u.Password = txtPassword.Text;
            u.Group_ID= selectedDataRow1.Row["Group_ID"].ToString();
            u.PartID = "";
            u.Description = txtDienGiai.Text;
            u.Active = true;



            BUS_SYS_USER bUS = new BUS_SYS_USER();
            int a = bUS.ThemNguoiDung(u);
            if(a==0)
            {
                MessageBox.Show("Thêm không thành công");
            }
            else
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}