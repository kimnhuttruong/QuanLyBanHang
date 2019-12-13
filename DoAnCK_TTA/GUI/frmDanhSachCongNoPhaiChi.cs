using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnCK_TTA.BUS;

namespace DoAnCK_TTA.GUI
{
    public partial class frmDanhSachCongNoPhaiChi : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDanhSachCongNoPhaiChi()
        {
            InitializeComponent();
        }

        private void btnLapPhieuThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = "";
            var form = new frmPhieuThu();
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                ma = row[0].ToString();
            }
            form.Sender(ma,"Phiếu Chi");
            form.ShowDialog();
           
        }
        DataTable _dt = new DataTable();
        public void load()
        {
            BUS_STOCK_INWARD_DETAIL bus1 = new BUS_STOCK_INWARD_DETAIL();
            _dt = bus1.LayThongTinBangKeCongNo();

            gridCongNoChiTiet.DataSource = _dt;
        }
        private void frmDanhSachCongNoPhaiChi_Load(object sender, EventArgs e)
        {
            load();
        }

        private void gridCongNoChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
