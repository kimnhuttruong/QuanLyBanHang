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
    public partial class frmNhapXuatTon : DevExpress.XtraEditors.XtraUserControl
    {
        public frmNhapXuatTon()
        {
            InitializeComponent();
        }

        private void frmNhapXuatTon_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            BUS_INVENTORY bus = new BUS_INVENTORY();
            gridTonKho.DataSource = bus.LayDanhCachPhieuNhapHang();
        }

        private void gridTonKho_Click(object sender, EventArgs e)
        {

        }
    }
}
