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
    public partial class frmDanhSachPhieuChi : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDanhSachPhieuChi()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhieuChi_Load(object sender, EventArgs e)
        {
            BUS_PROVIDER_PAYMENT bus = new BUS_PROVIDER_PAYMENT();
            gridPhieuThu.DataSource = bus.LayDanhSachHoaDon();

        }
    }
}
