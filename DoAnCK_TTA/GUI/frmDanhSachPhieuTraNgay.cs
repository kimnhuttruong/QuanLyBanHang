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
    public partial class frmDanhSachPhieuTraNgay : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDanhSachPhieuTraNgay()
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
            form.Sender(ma, "Phiếu Chi");
            form.ShowDialog();

        }
        public void load()
        {
            BUS_STOCK_INWARD_DETAIL bus1 = new BUS_STOCK_INWARD_DETAIL();
            _dt = bus1.LayThongTinBangKeThanhToanNgay();

            gridCongNoChiTiet.DataSource = _dt;
        }
        DataTable _dt = new DataTable();
        private void frmDanhSachPhieuTraNgay_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
