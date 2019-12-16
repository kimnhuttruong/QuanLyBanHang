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
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmThongTinCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinCongTy()
        {
            InitializeComponent();


        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinCongTy_Load(object sender, EventArgs e)
        {
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

            BUS_COMPANY ct = new BUS_COMPANY();
            DataTable dt = new DataTable();
            dt = ct.LayThongTinCongTy();
            if (dt.Rows.Count > 0)
            {
                string[] arrListStr = dt.Rows[0][0].ToString().Split('_');
                txtLinhVuc.Text = arrListStr[0];
                txtGPKD.Text = arrListStr[1];
                txtDiaChi.Text = dt.Rows[0]["CompanyAddress"].ToString();
                txtDienThoai.Text = dt.Rows[0]["Tel"].ToString();
                txtFax.Text = dt.Rows[0]["Fax"].ToString();
                txtMaSoThue.Text = dt.Rows[0]["CompanyTax"].ToString();
                txtWebsite.Text = dt.Rows[0]["CompanyTax"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                logo.Image = Image.FromFile(dt.Rows[0]["Logo"].ToString());
                txtTenDonVi.Text = txtDiaChi.Text = dt.Rows[0]["CompamyName"].ToString();
            }

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            
            BUS_COMPANY bUS_COMPANY = new BUS_COMPANY();
            DTO_COMPANY ct = new DTO_COMPANY();
            ct.CompanyID = txtLinhVuc.Text + "_" + txtGPKD.Text;
            ct.CompamyName = txtTenDonVi.Text;
            ct.Tel = txtDienThoai.Text;
            ct.Fax = txtFax.Text;
            ct.CompanyTax = txtMaSoThue.Text;
            ct.WebSite = txtWebsite.Text;
            ct.Email = txtEmail.Text;
            if (logo.Tag.ToString() == "DoAnCK_TTA")
                ct.Logo = "DoAnCK_TTA";
            else
                 ct.Logo = logo.Tag.ToString();

            ct.CompanyAddress = txtDiaChi.Text;
           int kt= bUS_COMPANY.ThemCôngTy(ct);
            if(kt==1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm Tra Lại Thông Tin");
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Title = "Please select an image file to encrypt.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                logo.Load(dialog.FileName);
                logo.Tag = dialog.FileName;
            }
        }
    }
}