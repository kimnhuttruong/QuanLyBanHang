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
    public partial class FrmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        BUS_SYS_USER busform = new BUS_SYS_USER();
        string id = "";
        public FrmDoiMatKhau(string UserName)
        {
            InitializeComponent();
            id = UserName;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            //log.MChine = dtlog.Rows[0][1].ToString();
            //log.UserID = dtlog.Rows[0][2].ToString();
            //log.Module = this.Tag.ToString();
            //log.Action_Name = "Xem";
            //busLog.ThemLichSu(log);

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            BUS_SYS_USER busform = new BUS_SYS_USER();
         
            int result = busform.CapNhatMatKhau(id,txtMatKhauCu.Text,txtMatKhauMoi.Text);
            if (result == 1&&txtMatKhauMoi.Text==txtNhapLai.Text)
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Cập nhật thất bại");
        }
    }
}