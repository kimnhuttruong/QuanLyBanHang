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
    public partial class frmBaoCaoDoanhSoTheoNgay : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBaoCaoDoanhSoTheoNgay()
        {
            InitializeComponent();
        }

        private void gridBaoCaoMuaHangTheoNgay_Click(object sender, EventArgs e)
        {

        }

        private void frmBaoCaoDoanhSoTheoNgay_Load(object sender, EventArgs e)
        {
            BUS_STOCK_INWARD_DETAIL bus = new BUS_STOCK_INWARD_DETAIL();
            gridBaoCaoMuaHangTheoNgay.DataSource = bus.LayThongTinMuaHangTheoNgay();
        }
    }
}
