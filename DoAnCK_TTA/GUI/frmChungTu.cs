﻿using System;
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
    public partial class frmChungTu : DevExpress.XtraEditors.XtraForm
    {
        public frmChungTu()
        {
            InitializeComponent();
        }

        private void frmChungTu_Load(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            BUS_SYS_USER_RULE bus4 = new BUS_SYS_USER_RULE();
            dt4 = bus4.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt4.Rows[i][0].ToString())
                    {


                        //if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                        //    btnTaoMoi.Enabled = false;
                        //if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                        //    btnXoa.Enabled = false;
                        //if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                        //    btnSuaChua.Enabled = false;
                        if (dt4.Rows[i]["AllowAccess"].ToString() == "False")
                            btnXem.Enabled = false;
                        if (dt4.Rows[i]["AllowPrint"].ToString() == "False")
                            btnIn.Enabled = false;
                        if (dt4.Rows[i]["AllowExport"].ToString() == "False")
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


            List<ChungTu> listCT = new List<ChungTu>();
            DataTable dt = new DataTable();
            BUS_STOCK_INWARD bus = new BUS_STOCK_INWARD();
            dt = bus.LayThongTinBangKe();
          
            for(int i=0;i<dt.Rows.Count;i++)
            {
                ChungTu ct = new ChungTu();
                ct.STT = (i+1).ToString();
                ct.MaChungTu = dt.Rows[i]["ID"].ToString();
                ct.Ngay = dt.Rows[i]["RefDate"].ToString();
                ct.Loai = dt.Rows[i]["LoaiPhieu"].ToString();
                ct.ThanhTien = dt.Rows[i]["Charge"].ToString();
                ct.DienGiai = dt.Rows[i]["Description"].ToString();
                listCT.Add(ct);
            }
            gridChungTu.DataSource = listCT;
        }
        class ChungTu
        {
            public string STT { get; set; }
            public string MaChungTu { get; set; }
            public string Ngay { get; set; }
            public string Loai { get; set; }
            public string ThanhTien { get; set; }
            public string DienGiai { get; set; }
        }
    }
}