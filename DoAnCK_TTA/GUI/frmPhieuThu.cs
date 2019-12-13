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
    public partial class frmPhieuThu : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuThu()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        string coma = "";
        string loaiphieu = "";
        private void GetMessage(string ma,string phieu)
        {
            if (ma.Length > 0)
            {
                DataTable dt = new DataTable();
                loaiphieu = phieu;
                coma = ma;
                if (phieu == "Phiếu Thu")
                {
                   
                    BUS_STOCK_OUTWARD_DETAIL bUS_STOCK_INWARD = new BUS_STOCK_OUTWARD_DETAIL();
                    dt = bUS_STOCK_INWARD.LayThongTinBangKeChiTiet(ma);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        txtPhieu.EditValue = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "");
                        txtChungTu.Text = dt.Rows[0]["Outward_ID"].ToString();
                        txtDateChungTu.Text = dt.Rows[0]["RefDate"].ToString();
                        txtKhachHang.Text = dt.Rows[0]["CustomerName"].ToString();
                        txtNgay.EditValue = DateTime.Now;
                        calcSoTien.EditValue = dt.Rows[0]["Tien"].ToString();
                        calcNo.EditValue = dt.Rows[0]["Tien"].ToString();
                        calcPhaiTra.EditValue = dt.Rows[0]["Tien"].ToString();
                        txtLyDo.EditValue = dt.Rows[0]["Description"].ToString();
                    }

                  
                }
                else
                {
                    BUS_STOCK_INWARD_DETAIL bUS_STOCK_INWARD = new BUS_STOCK_INWARD_DETAIL();
                    dt = bUS_STOCK_INWARD.LayThongTinBangKeChiTiet(ma);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        this.Text = "Phiếu Chi";
                        txtPhieu.EditValue = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "");
                        txtChungTu.Text = dt.Rows[0]["Inward_ID"].ToString();
                        txtDateChungTu.Text = dt.Rows[0]["RefDate"].ToString();
                        txtKhachHang.Text = dt.Rows[0]["CustomerName"].ToString();
                        txtNgay.EditValue = DateTime.Now;
                        calcSoTien.EditValue = dt.Rows[0]["Charge"].ToString();
                        calcNo.EditValue = dt.Rows[0]["Charge"].ToString();
                        calcPhaiTra.EditValue = dt.Rows[0]["Charge"].ToString();
                        txtLyDo.EditValue = dt.Rows[0]["Description"].ToString();
                    }

                }
                BUS_EMPLOYEE busNV = new BUS_EMPLOYEE();
                DataTable dt1 = new DataTable();
                dt1 = busNV.LayDanhSachNhanVien();
                lookNhanVien.Properties.DataSource = dt1;
                lookNhanVien.Properties.ValueMember = "Employee_ID";
                lookNhanVien.Properties.DisplayMember = "Employee_Name";
            }
        }
        public delegate void SendMessage(string ma,string phieu);
        public SendMessage Sender;

        public void load()
        {
           
        }
        private void calcEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPhieuThu_Load(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookNhanVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (loaiphieu == "Phiếu Thu")
            {
                DTO_CUSTOMER_RECEIPT tt = new DTO_CUSTOMER_RECEIPT();
                tt.RefID = txtPhieu.Text;
                tt.RefDate = txtNgay.Text;
                tt.RefOrgNo = txtChungTu.Text;
                tt.CurrencyID = "VND";
                tt.CustomerID = txtKhachHang.EditValue.ToString();
                tt.CustomerName = txtKhachHang.Text;
                tt.Amount = calcPhaiTra.Text;
                tt.CreatedBy = "admin";
                tt.OwnerID = lookNhanVien.EditValue.ToString();
                tt.Description = txtLyDo.Text;
                tt.Active = true;

                BUS_CUSTOMER_RECEIPT bus = new BUS_CUSTOMER_RECEIPT();
                int a = bus.ThemHoaDon(tt);
                this.Close();
            }else
            {
                DTO_PROVIDER_PAYMENT tt = new DTO_PROVIDER_PAYMENT();
                tt.RefID = txtPhieu.Text;
                tt.RefDate = txtNgay.Text;
                tt.RefOrgNo = txtChungTu.Text;
                tt.CurrencyID = "VND";
                tt.CustomerID = txtKhachHang.EditValue.ToString();
                tt.CustomerName = txtKhachHang.Text;
                tt.Amount = calcPhaiTra.Text;
                tt.CreatedBy = "admin";
                tt.OwnerID = lookNhanVien.EditValue.ToString();
                tt.Description = txtLyDo.Text;
                tt.Active = true;

                BUS_PROVIDER_PAYMENT bus = new BUS_PROVIDER_PAYMENT();
                int a = bus.ThemHoaDon(tt);
                this.Close();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}