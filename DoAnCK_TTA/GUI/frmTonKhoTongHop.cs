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
    public partial class frmTonKhoTongHop : DevExpress.XtraEditors.XtraUserControl
    {
        public frmTonKhoTongHop()
        {
            InitializeComponent();
        }

        private void frmTonKhoTongHop_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            BUS_INVENTORY_DETAIL bus = new BUS_INVENTORY_DETAIL();
            gridTonKho.DataSource = bus.LayDanhCachPhieuNhapHang();
        }
    }
}
