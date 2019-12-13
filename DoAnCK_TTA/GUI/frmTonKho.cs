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

namespace DoAnCK_TTA.GUI
{
    public partial class frmTonKho : DevExpress.XtraEditors.XtraForm
    {
        public frmTonKho()
        {
            InitializeComponent();
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            BUS_INVENTORY_DETAIL bus = new BUS_INVENTORY_DETAIL();
            gridTonKho.DataSource = bus.LayDanhCachPhieuNhapHang();
        }
        private void gridTonKho_Click(object sender, EventArgs e)
        {
           
        }
    }
}