﻿using System;
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
    public partial class frmSoChiTietHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        public frmSoChiTietHangHoa()
        {
            InitializeComponent();
        }

        private void frmSoChiTietHangHoa_Load(object sender, EventArgs e)
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


                        //if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                        //{
                        //    btnSaveAdd.Enabled = false;
                        //    btnSaveClose.Enabled = false;
                        //}
                        //if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                        //    btnXoa.Enabled = false;
                        //if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                        //    btnSuaChua.Enabled = false;
                        if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                            btnXem.Enabled = false;
                        if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                            btnIn.Enabled = false;
                        if (dt.Rows[i]["AllowExport"].ToString() == "False")
                            btnXuat.Enabled = false;
                        //if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //    btnNhap.Enabled = false;
                    }

                }
            }
        }
    }
}
