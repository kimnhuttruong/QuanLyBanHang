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
    public partial class frmBangKeChiTiet_ChuyenKho : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBangKeChiTiet_ChuyenKho()
        {
            InitializeComponent();
        }

        private void frmBangKeChiTiet_ChuyenKho_Load(object sender, EventArgs e)
        {
            load();
        }
        DataTable _dt = new DataTable();
        public void load()
        {
            BUS_STOCK_TRANSFER_DETAIL bus1 = new BUS_STOCK_TRANSFER_DETAIL();
            _dt = bus1.LayThongTinBangKe();

            gridChiTiet.DataSource = _dt;
        }
    }
}
