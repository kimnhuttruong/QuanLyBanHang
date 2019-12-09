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
    public partial class frmThongTinNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNhomHang()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(DTO_PRODUCT_GROUP c)
        {
            txtMa.Text = c.ProductGroup_ID;
            txtTen.Text = c.ProductGroup_Name;
            txtGhiChu.Text = c.Description;

            checkQuanLy.Checked = c.Active;
            if (c.ProductGroup_Name == null)
                isAdd = true;
        }
        bool isAdd = false;
        public delegate void SendMessage(DTO_PRODUCT_GROUP c);
        public SendMessage Sender;
        private void txtMa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmThongTinNhomHang_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_PRODUCT_GROUP bus = new BUS_PRODUCT_GROUP();
            DTO_PRODUCT_GROUP c = new DTO_PRODUCT_GROUP();
            c.ProductGroup_ID = txtMa.Text;
            c.ProductGroup_Name = txtTen.Text;
            c.Description = txtGhiChu.Text;


            c.Active = checkQuanLy.Checked;
            if (isAdd == true)
            {
                int kt = bus.ThemNhomHang(c);

            }
            else
            {
                int kt = bus.CapNhatNhomHang(c);

            }
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}