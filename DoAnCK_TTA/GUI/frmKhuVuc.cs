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
using System.IO;
using DoAnCK_TTA.DTO;

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
            var mainWindow = new frmThongTinKhuVuc();
            mainWindow.Sender("", "", "", true);


            mainWindow.ShowDialog();
            formLoad();
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
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Xem";
            busLog.ThemLichSu(log);

        }

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
      
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = "";
            string ten = "";
            string mota = "";
            bool quanly = true;
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                ma=row[0].ToString();
                ten = row[1].ToString();
                mota = row[2].ToString();
                quanly =bool.Parse(row[3].ToString());
            }
           

            var mainWindow = new frmThongTinKhuVuc();
            mainWindow.Sender(ma, ten, mota, quanly);

            mainWindow.ShowDialog();
            formLoad();
        }
    }
}