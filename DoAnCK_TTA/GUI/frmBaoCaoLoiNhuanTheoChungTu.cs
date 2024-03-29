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
using DoAnCK_TTA.DTO;
using System.IO;

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
            DataTable dt = new DataTable();
            BUS_SYS_USER_RULE bus4 = new BUS_SYS_USER_RULE();
            dt = bus4.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt.Rows[i][0].ToString())
                    {


                        //if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                        //    btnTaoMoi.Enabled = false;
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


            BUS_STOCK_OUTWARD_DETAIL bus = new BUS_STOCK_OUTWARD_DETAIL();
            gridBaoCaoLoiNhuan.DataSource = bus.LayThongTinLoiNhuan();

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

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridBaoCaoLoiNhuan.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridBaoCaoLoiNhuan.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridBaoCaoLoiNhuan.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridBaoCaoLoiNhuan.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridBaoCaoLoiNhuan.ExportToHtml(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }
    }
}
