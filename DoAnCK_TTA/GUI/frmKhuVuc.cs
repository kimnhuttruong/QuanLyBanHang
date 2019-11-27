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

namespace DoAnCK_TTA.GUI
{
    public partial class frmKhuVuc : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinKhuVuc();
            mainWindow.Message = true;
            mainWindow.ShowDialog();

        }

        private void gridKhuVuc_Click(object sender, EventArgs e)
        {

        }
    }
}