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
    public partial class frmThongTinKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinKhuVuc()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(string ma,string ten,string mota,bool quanly)
        {
            txtMa.Text = ma;
            txtTen.Text = ten;
            txtGhiChu.Text = mota;
            checkQuanLy.Checked = quanly;
            if (ten == "")
                isAdd = true;
        }
        bool isAdd=false;
        public delegate void SendMessage(string ma, string ten, string mota, bool quanly);
        public SendMessage Sender;
        
       
        private void frmThongTinKhuVuc_Load(object sender, EventArgs e)
        {
           

        }

        private void frmThongTinKhuVuc_Load_1(object sender, EventArgs e)
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

            DTO_CUSTOMER_GROUP kv = new DTO_CUSTOMER_GROUP();
            kv.Customer_Group_ID = txtMa.Text;
            kv.Customer_Group_Name = txtTen.Text;
            kv.Description = txtGhiChu.Text;
            kv.Active = checkQuanLy.Checked;

            BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            if (isAdd == true)
            {
                int kt = bus.ThemKhuVuc(kv);
               
            }
            else
            {
                int kt = bus.CapNhatKhuVuc(kv);
                
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