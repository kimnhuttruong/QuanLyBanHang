using System;
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
using DevExpress.XtraGrid.Views.Grid;
using DoAnCK_TTA.DTO;
using System.IO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            BUS_SYS_USER_RULE bus4 = new BUS_SYS_USER_RULE();
            dt1 = bus4.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt1.Rows[i][0].ToString())
                    {


                        //if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                        //    btnTaoMoi.Enabled = false;
                        //if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                        //    btnXoa.Enabled = false;
                        //if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                        //    btnSuaChua.Enabled = false;
                        if (dt1.Rows[i]["AllowAccess"].ToString() == "False")
                            btnXem.Enabled = false;
                        if (dt1.Rows[i]["AllowPrint"].ToString() == "False")
                            btnIn.Enabled = false;
                        if (dt1.Rows[i]["AllowExport"].ToString() == "False")
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



            DataTable dt = new DataTable();
            BUS_STOCK_INWARD_DETAIL bus = new BUS_STOCK_INWARD_DETAIL();
           dt = bus.LayThongTinMuaHangTheoNCC();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                TongMua tm = new TongMua();
                tm.MaNCC = dt.Rows[i]["Customer_ID"].ToString();
                tm.TenNCC = dt.Rows[i]["CustomerName"].ToString();
                tm.TongTien = dt.Rows[i]["TienMua"].ToString();
                tm.KhuVuc = dt.Rows[i]["Customer_Group_Name"].ToString();
                dsGroup.Add(tm);
            }

            gridChiPhiMuaHang.DataSource = dsGroup;

           
            BUS_STOCK_INWARD bus1 = new BUS_STOCK_INWARD();
            DataTable dt2 = new DataTable();
            dt2 = bus1.LayThongTinBangKeChiTiet();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DTO_STOCK_INWARD dTO_STOCK_INWARD = new DTO_STOCK_INWARD();
                dTO_STOCK_INWARD.ID = dt2.Rows[i]["ID"].ToString();
                dTO_STOCK_INWARD.RefDate = dt2.Rows[i]["RefDate"].ToString();
                dTO_STOCK_INWARD.Charge = dt2.Rows[i]["Charge"].ToString();
                dTO_STOCK_INWARD.Customer_ID = dt2.Rows[i]["Customer_ID"].ToString();
                dsDetail.Add(dTO_STOCK_INWARD);
            }
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

        private void gridView5_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.IsEmpty = !dsDetail.Any(x => x.Customer_ID == group.MaNCC);
        }

        private void gridView5_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.ChildList = dsDetail.Where(x => x.Customer_ID == group.MaNCC).ToList();
        }
        class TongMua
        {
            public string MaNCC { get; set; }
            public string TenNCC { get; set; }
            public string TongTien { get; set; }
            public string KhuVuc { get; set; }
        }
        List<TongMua> dsGroup = new List<TongMua>();
        List<DTO_STOCK_INWARD> dsDetail = new List<DTO_STOCK_INWARD>();
        private void gridView5_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView5_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Level1";
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
                            gridChiPhiMuaHang.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridChiPhiMuaHang.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridChiPhiMuaHang.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridChiPhiMuaHang.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridChiPhiMuaHang.ExportToHtml(exportFilePath);
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
