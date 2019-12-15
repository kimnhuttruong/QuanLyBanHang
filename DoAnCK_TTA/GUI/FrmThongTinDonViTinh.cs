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
    public partial class FrmThongTinDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public FrmThongTinDonViTinh()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(DTO_UNIT c)
        {
            txtMa.Text = c.Unit_ID;
            txtTen.Text = c.Unit_Name;
            txtGhiChu.Text = c.Description;

            checkQuanLy.Checked = c.Active;
            if (c.Unit_Name==null)
                isAdd = true;
        }
        bool isAdd = false;
        public delegate void SendMessage(DTO_UNIT c);
        public SendMessage Sender;
        private void FrmThongTinDonViTinh_Load(object sender, EventArgs e)
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
            BUS_UNIT bus = new BUS_UNIT();
            DTO_UNIT c = new DTO_UNIT();
            c.Unit_ID = txtMa.Text;
            c.Unit_Name = txtTen.Text;
            c.Description = txtGhiChu.Text;
           

            c.Active = checkQuanLy.Checked;
            if (isAdd == true)
            {
                int kt = bus.ThemDonViTinh(c);

            }
            else
            {
                int kt = bus.CapNhatDonViTinh(c);

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