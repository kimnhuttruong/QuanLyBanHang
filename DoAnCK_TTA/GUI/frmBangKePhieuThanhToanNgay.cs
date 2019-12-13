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
    public partial class frmBangKePhieuThanhToanNgay : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBangKePhieuThanhToanNgay()
        {
            InitializeComponent();
        }

        private void frmBangKePhieuThanhToanNgay_Load(object sender, EventArgs e)
        {
            load();
        }
        DataTable _dt = new DataTable();
        public void load()
        {
            BUS_STOCK_OUTWARD_DETAIL bus1 = new BUS_STOCK_OUTWARD_DETAIL();
            _dt = bus1.LayThongTinThanhToanNgayChiTiet();

            gridBangKeThanhToanNgay.DataSource = _dt;
        }
    
        private void btnLapPhieuThu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = "";
            var form = new frmPhieuThu();
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                ma = row[0].ToString();
            }
            form.Sender(ma,"Phiếu Thu");
            form.ShowDialog();
        }
    }
}
