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
    public partial class frmLichSuHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        public frmLichSuHangHoa()
        {
            InitializeComponent();
        }

        private void frmLichSuHangHoa_Load(object sender, EventArgs e)
        {
            List<ChungTu> listCT = new List<ChungTu>();
            DataTable dt = new DataTable();
            BUS_STOCK_INWARD bus = new BUS_STOCK_INWARD();
            dt = bus.LayThongTinBangKe();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChungTu ct = new ChungTu();
                ct.STT = (i + 1).ToString();
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
