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
    public partial class frmThongTinKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinKhachHang()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(DTO_CUSTOMER c)
        {
            txtMa.Text = c.Customer_ID;
            txtTen.Text = c.CustomerName;
            txtDiaChi.Text = c.CustomerAddress;
            txtMaSoThue.Text = c.Tax;
            txtSoDienThoai.Text = c.Tel;
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
            txtFacebook.Text = c.NickYM;
            txtZalo.Text = c.NickSky;
            radioDaiLyBanLe.Properties.Items[1].Value = c.Customer_Type_ID;
           
            checkQuanLy.Checked = c.Active;

            if (c.Customer_ID == "")
                isAdd = true;
        }
        bool isAdd = false;
        public delegate void SendMessage(DTO_CUSTOMER c);
        public SendMessage Sender;
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void txtNganHang_EditValueChanged(object sender, EventArgs e)
        {

        }
        DataTable _dt = new DataTable();
        void formLoad()
        {
            BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            _dt = bus.LayDanhSachKhuVuc();

            lookKhuVuc.Properties.DataSource = _dt;
            lookKhuVuc.Properties.DisplayMember = "Customer_Group_Name";
            lookKhuVuc.Properties.ValueMember = "Customer_Group_ID";

        }
        private void frmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void lookKhuVuc_EditValueChanged(object sender, EventArgs e)
        {

        }
        string _id;
        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            var mainWindow = new frmThongTinKhuVuc();


            _id = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            _id = _id.Remove(0, 2);

            _id = (int.Parse(_id) + 1).ToString("000000");
            _id = "KV" + _id.ToString();

            mainWindow.Sender(_id, "", "", true);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_CUSTOMER bus = new BUS_CUSTOMER();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}