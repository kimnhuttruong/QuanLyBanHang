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
    public partial class frmThemBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemBoPhan()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(DTO_DEPARTMENT c)
        {
            txtMa.Text = c.Department_ID;
            txtTen.Text = c.Department_Name;
            txtGhiChu.Text = c.Description;

            checkQuanLy.Checked = c.Active;
            if (c.Department_Name == null || c.Department_Name == "")
                isAdd = true;
            else
                isAdd = false;
        }
        bool isAdd = true;
        public delegate void SendMessage(DTO_DEPARTMENT c);
        public SendMessage Sender;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_DEPARTMENT bus = new BUS_DEPARTMENT();
            DTO_DEPARTMENT c = new DTO_DEPARTMENT();
            c.Department_ID = txtMa.Text;
            c.Department_Name = txtTen.Text;
            c.Description = txtGhiChu.Text;


            c.Active = checkQuanLy.Checked;
            if (isAdd == true)
            {
                int kt = bus.ThemBoPhan(c);

            }
            else
            {
                int kt = bus.CapNhatBoPhan(c);

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

        private void frmThemBoPhan_Load(object sender, EventArgs e)
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
    }
}