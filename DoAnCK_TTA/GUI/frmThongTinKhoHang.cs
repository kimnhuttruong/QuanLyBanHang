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
    public partial class frmThongTinKhoHang : DevExpress.XtraEditors.XtraForm
    {

        public frmThongTinKhoHang()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        string id_group = "KV1";
        private void GetMessage(DTO_STOCK c)
        {
             txtMa.Text = c.Stock_ID;
             txtTen.Text= c.Stock_Name;
             txtDiaChi.Text= c.Address;
             txtDienThoai.Text= c.Telephone;
             txtEmail.Text= c.Email;
             txtNguoiLienHe.Text= c.Contact;
             lookNguoiQuanLy.Text = c.Manager;
             txtNguoiLienHe.Text = c.Contact;
             txtFax.Text= c.Fax;
             txtDienGiai.Text= c.Description;
            //id_group = c.Customer_Group_ID;
            //radioDaiLyBanLe.Properties.Items[1].Value = c.Customer_Type_ID;

            checkQuanLy.Checked = c.Active;

            if (c.Stock_Name == "")
                isAdd = true;
        }
        bool isAdd = false;
        public delegate void SendMessage(DTO_STOCK c);
        public SendMessage Sender;
        DataTable _dt = new DataTable();
        void formLoad()
        {
            BUS_EMPLOYEE bus = new BUS_EMPLOYEE();
            _dt = bus.LayDanhSachNhanVien();

            lookNguoiQuanLy.Properties.DataSource = _dt;
            lookNguoiQuanLy.Properties.DisplayMember = "Employee_Name";
            lookNguoiQuanLy.Properties.ValueMember = "Employee_ID";

            if (id_group != null)
                lookNguoiQuanLy.EditValue = lookNguoiQuanLy.Properties.GetKeyValue(int.Parse(id_group.Remove(0, 2)) - 1);

        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_STOCK bus = new BUS_STOCK();
            DTO_STOCK c = new DTO_STOCK();
            c.Stock_ID = txtMa.Text;
            c.Stock_Name = txtTen.Text;
            c.Address = txtDiaChi.Text;
            c.Telephone = txtDienThoai.Text;
            c.Email = txtEmail.Text;
            c.Contact = txtNguoiLienHe.Text;
            c.Manager = lookNguoiQuanLy.Text;
            c.Contact = txtNguoiLienHe.Text;
            c.Fax = txtFax.Text;
            c.Description = txtDienGiai.Text;
            //c.Customer_Type_ID = radioDaiLyBanLe.Properties.Items[1].Value("");

            c.Active = checkQuanLy.Checked;
            if (isAdd == true)
            {
                int kt = bus.ThemKhoHang(c);

            }
            else
            {
                int kt = bus.CapNhatKhoHang(c);

            }
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Lưu";
            busLog.ThemLichSu(log);
            this.Close();
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinKhoHang_Load(object sender, EventArgs e)
        {
            formLoad();
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Xem";
            busLog.ThemLichSu(log);
        }

        private void lookNguoiQuanLy_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}