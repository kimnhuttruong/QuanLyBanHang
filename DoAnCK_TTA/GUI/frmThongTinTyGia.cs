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
    public partial class frmThongTinTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinTyGia()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(DTO_CURRENCY c)
        {
            txtMa.Text = c.Currency_ID;
            txtTen.Text = c.CurrencyName;
            txtTyGiaQuyDoi.Text = c.Exchange;

            checkQuanLy.Checked = c.Active;
            if (c.CurrencyName == null)
                isAdd = true;
        }
        bool isAdd = false;
        public delegate void SendMessage(DTO_CURRENCY c);
        public SendMessage Sender;
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmThongTinTyGia_Load(object sender, EventArgs e)
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_CURRENCY bus = new BUS_CURRENCY();
            DTO_CURRENCY c = new DTO_CURRENCY();
            c.Currency_ID = txtMa.Text;
            c.CurrencyName = txtTen.Text;
            c.Exchange = txtTyGiaQuyDoi.Text;


            c.Active = checkQuanLy.Checked;
            if (isAdd == true)
            {
                int kt = bus.ThemTyGia(c);

            }
            else
            {
                int kt = bus.CapNhatTyGia(c);

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