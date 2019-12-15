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
    public partial class frmBangKeChiTiet_ChuyenKho : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBangKeChiTiet_ChuyenKho()
        {
            InitializeComponent();
        }

        private void frmBangKeChiTiet_ChuyenKho_Load(object sender, EventArgs e)
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
                            btnTaoMoi.Enabled = false;
                        if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                            btnXoa.Enabled = false;
                        if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                            btnSuaChua.Enabled = false;
                        if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                            btnXem.Enabled = false;
                        if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                            btnIn.Enabled = false;
                        if (dt.Rows[i]["AllowExport"].ToString() == "False")
                            btnXuat.Enabled = false;
                        //}
                        //if (this.Controls[j].Name.ToString().IndexOf("Nhap") != -1)
                        //{
                        //    if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //        btnXuat.Enabled = false;
                        //}
                        //     }
                        //}
                    }
                }
            }
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