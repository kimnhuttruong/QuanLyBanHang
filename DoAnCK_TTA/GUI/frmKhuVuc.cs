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
using System.IO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmKhuVuc : DevExpress.XtraBars.ToolbarForm.ToolbarForm 
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        void formLoad()
        {
            BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            _dt = bus.LayDanhSachKhuVuc();

            gridKhuVuc.DataSource = _dt;
        }
        string _id = "";
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridKhuVuc_Click(object sender, EventArgs e)
        {
          
        }
        DataTable _dt = new DataTable();
        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BUS_SYS_USER_RULE bus = new BUS_SYS_USER_RULE();
            dt = bus.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt.Rows[i][0].ToString())
                    {


                        if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                            btnThem.Enabled = false;
                        if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                            btnXoa.Enabled = false;
                        if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                            btnSuaChua.Enabled = false;
                        //if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                        //    btnXem.Enabled = false;
                        //if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                        //    btnIn.Enabled = false;
                        if (dt.Rows[i]["AllowExport"].ToString() == "False")
                            btnXuat.Enabled = false;
                        //    if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //        btnNhap.Enabled = false;
                    }
                    //     }
                    //}
                }
            }
            formLoad();
        }
        string ten, mota;
        bool check;

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formLoad();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}