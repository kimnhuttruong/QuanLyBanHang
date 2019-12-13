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
    public partial class frmDanhSachPhieuThu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDanhSachPhieuThu()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhSachPhieuThu_Load(object sender, EventArgs e)
        {
            BUS_CUSTOMER_RECEIPT bus = new BUS_CUSTOMER_RECEIPT();
            gridPhieuThu.DataSource = bus.LayDanhSachHoaDon();

            
        }
    }
}
