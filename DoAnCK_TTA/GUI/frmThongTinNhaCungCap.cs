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
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.BUS;

namespace DoAnCK_TTA.GUI
{
    public partial class frmThongTinNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNhaCungCap()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        string id_group = "KV1";
        private void frmThongTinNhaCungCap_Load(object sender, EventArgs e)
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

        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            var mainWindow = new frmThongTinKhuVuc();


            _id = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            _id = _id.Remove(0, 2);

            _id = (int.Parse(_id) + 1).ToString("00000");
            _id = "KV" + _id.ToString();

            mainWindow.Sender(_id, "", "", true);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }
        private void GetMessage(DTO_PROVIDER c)
        {
            txtMa.Text = c.Customer_ID;
            txtTen.Text = c.CustomerName;
            txtDiaChi.Text = c.CustomerAddress;
            txtMaSoThue.Text = c.Tax;
            txtDienThoai.Text = c.Tel;
            txtEmail.Text = c.Email;
            txtTaiKhoan.Text = c.BankAccount;
            calcGioiHanNo.Text = c.CreditLimit;
            calcChiecKhau.Text = c.Discount;
            txtNguoiLienHe.Text = c.Contact;
            txtFax.Text = c.Fax;
            txtMobile.Text = c.Mobile;
            txtWebsite.Text = c.Website;
            txtNganHang.Text = c.BankName;
            calcNoHienTai.Text = c.Contry;
            txtChucVu.Text = c.Position;
            id_group = c.Customer_Group_ID;
            //id_group = c.Customer_Group_ID;
            //radioDaiLyBanLe.Properties.Items[1].Value = c.Customer_Type_ID;

            checkQuanLy.Checked = c.Active;

            if (c.Customer_ID == "")
                isAdd = true;
        }
        bool isAdd = false;
        public delegate void SendMessage(DTO_PROVIDER c);
        public SendMessage Sender;
        DataTable _dt = new DataTable();
        void formLoad()
        {
            BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            _dt = bus.LayDanhSachKhuVuc();

            lookKhuVuc.Properties.DataSource = _dt;
            lookKhuVuc.Properties.DisplayMember = "Customer_Group_Name";
            lookKhuVuc.Properties.ValueMember = "Customer_Group_ID";

            if (id_group != null)
                lookKhuVuc.EditValue = lookKhuVuc.Properties.GetKeyValue(int.Parse(id_group.Remove(0, 2)) - 1);

        }
        string _id;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_PROVIDER bus = new BUS_PROVIDER();
            DTO_PROVIDER c = new DTO_PROVIDER();
            c.Customer_ID = txtMa.Text;
            c.CustomerName = txtTen.Text;
            c.CustomerAddress = txtDiaChi.Text;
            c.Tax = txtMaSoThue.Text;
            c.Tel = txtDienThoai.Text;
            c.Email = txtEmail.Text;
            c.BankAccount = txtTaiKhoan.Text;
            c.CreditLimit = calcGioiHanNo.Text;
            c.Discount = calcChiecKhau.Text;
            c.Contact = txtNguoiLienHe.Text;
            c.Fax = txtFax.Text;
            c.Mobile = txtMobile.Text;
            c.Website = txtWebsite.Text;
            c.BankName = txtNganHang.Text;
            c.Contry = calcNoHienTai.Text;
            c.Position = txtChucVu.Text;
            //c.Customer_Type_ID = radioDaiLyBanLe.Properties.Items[1].Value("");

            c.Active = checkQuanLy.Checked;
            if (isAdd == true)
            {
                int kt = bus.ThemNhaCungCap(c);

            }
            else
            {
                int kt = bus.CapNhatNhaCungCap(c);

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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}