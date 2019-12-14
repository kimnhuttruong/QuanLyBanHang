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
    public partial class frmBaoCaoLoiNhuanTheoChungTu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBaoCaoLoiNhuanTheoChungTu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoLoiNhuanTheoChungTu_Load(object sender, EventArgs e)
        {
            BUS_STOCK_OUTWARD_DETAIL bus = new BUS_STOCK_OUTWARD_DETAIL();
            gridBaoCaoLoiNhuan.DataSource = bus.LayThongTinLoiNhuan();
        }
    }
}
