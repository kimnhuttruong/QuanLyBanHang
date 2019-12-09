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
using DoAnCK_TTA.DTO;
using System.IO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {

        public frmKhoHang()
        {
            InitializeComponent();
        }



        private void treeKhoHang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            c.Stock_ID = e.Node.GetValue("Stock_ID").ToString();
            c.Stock_Name = e.Node.GetValue("Stock_Name").ToString();
            c.Contact = e.Node.GetValue("Contact").ToString();
            c.Address = e.Node.GetValue("Address").ToString();
            c.Telephone = e.Node.GetValue("Telephone").ToString();
            c.Description = e.Node.GetValue("Description").ToString();
            c.Mobi = e.Node.GetValue("Mobi").ToString();
            c.Active = bool.Parse(e.Node.GetValue("Active").ToString());
        }
        DataTable _dt = new DataTable();
        public void Init()
        {
         

            BUS_STOCK bUS_ = new BUS_STOCK();
            _dt = bUS_.LayThongTinKhoHang();
 
            treeKhoHang.DataSource = _dt;
        }
        string _id = "";
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainwindow = new frmThongTinKhoHang();

            dTO_STOCK.Stock_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_STOCK.Stock_ID = dTO_STOCK.Stock_ID.Remove(0, 1);

            dTO_STOCK.Stock_ID = (int.Parse(dTO_STOCK.Stock_ID) + 1).ToString("000000");
            dTO_STOCK.Stock_ID = "K" + dTO_STOCK.Stock_ID.ToString();

            mainwindow.Sender(dTO_STOCK);    //Gọi delegate
            mainwindow.ShowDialog();
            Init();
        }
        DTO_STOCK c = new DTO_STOCK();
        DTO_STOCK dTO_STOCK = new DTO_STOCK();
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinKhoHang();
            
            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUS_STOCK bus = new BUS_STOCK();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaKhoHang(c.Stock_ID);
                Init();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Init();
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
                            treeKhoHang.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeKhoHang.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeKhoHang.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeKhoHang.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeKhoHang.ExportToHtml(exportFilePath);
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
    }
}