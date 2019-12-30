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
using DevExpress.XtraGrid.Views.Grid;
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.BUS;
using System.IO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmBangKeTongHop : DevExpress.XtraEditors.XtraUserControl 
    {
        public frmBangKeTongHop()
        {
            InitializeComponent();
        }

        private void frmBangKeTongHop_Load(object sender, EventArgs e)
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
                        //if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                        //    btnXem.Enabled = false;
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
            gridBangKeTongHop.DataSource = dsGroup;
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
        public void load ()
        {
            DataTable dt1 = new DataTable();
            BUS_STOCK_INWARD busnhom = new BUS_STOCK_INWARD();
            dt1 = busnhom.LayThongTinBangKeChiTiet();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                DTO_STOCK_INWARD group = new DTO_STOCK_INWARD();
                group.RefDate = dt1.Rows[i]["RefDate"].ToString();
                group.Ref_OrgNo = dt1.Rows[i]["Ref_OrgNo"].ToString();
                group.RefStatus = dt1.Rows[i]["RefStatus"].ToString();
                group.CustomerName = (dt1.Rows[i]["CustomerName"].ToString());
                group.Amount = dt1.Rows[i]["Amount"].ToString();
                group.Vat = dt1.Rows[i]["Vat"].ToString();
                group.Amount = dt1.Rows[i]["Amount"].ToString();
                group.ID = dt1.Rows[i]["ID"].ToString();
                group.Charge = dt1.Rows[i]["Charge"].ToString();
                group.Description = (dt1.Rows[i]["Description"].ToString());

                dsGroup.Add(group);
            }

            DataTable dt2 = new DataTable();
            BUS_STOCK_INWARD_DETAIL bus = new BUS_STOCK_INWARD_DETAIL();
            dt2 = bus.LayThongTinBangKe();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {

                DTO_STOCK_INWARD_DETAIL Detail = new DTO_STOCK_INWARD_DETAIL();
                Detail.Inward_ID = dt2.Rows[i]["Inward_ID"].ToString();
                Detail.Product_ID = dt2.Rows[i]["Product_ID"].ToString();
                Detail.ProductName = dt2.Rows[i]["Product_Name"].ToString();
                Detail.Stock_ID = dt2.Rows[i]["Stock_ID"].ToString();
                Detail.Unit = dt2.Rows[i]["Unit"].ToString();
                Detail.Quantity = (dt2.Rows[i]["Quantity"].ToString());
                Detail.UnitPrice = dt2.Rows[i]["UnitPrice"].ToString();
                Detail.Amount = dt2.Rows[i]["Amount"].ToString();
                
                dsDetail.Add(Detail);
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_STOCK_INWARD group = view.GetRow(e.RowHandle) as DTO_STOCK_INWARD;
            if (group != null)
                e.IsEmpty = !dsDetail.Any(x => x.Inward_ID == group.ID);
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_STOCK_INWARD group = view.GetRow(e.RowHandle) as DTO_STOCK_INWARD;
            if (group != null)
                e.ChildList = dsDetail.Where(x => x.Inward_ID == group.ID).ToList();

        }
        List<DTO_STOCK_INWARD> dsGroup = new List<DTO_STOCK_INWARD>();
        List<DTO_STOCK_INWARD_DETAIL> dsDetail = new List<DTO_STOCK_INWARD_DETAIL>();
        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Level1";
        }

        private void gridBangKeTongHop_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = "";

            foreach (int i in gridView1.GetSelectedRows())
            {
                ma = (i).ToString();
            }
            ma = dsGroup[int.Parse(ma)].ID;

            var phieumuahang = new frmPhieuNhapHang();

            phieumuahang.Sender(ma);
            Form window1 = new Form()
            {
                Text = "Sửa Phiếu Mua Hàng",
                Width = 1130,
                Height = 550,
                AutoSize = false

            };
            window1.Controls.Add(phieumuahang);
            window1.ShowDialog();


            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Sửa";
            busLog.ThemLichSu(log);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
                            gridBangKeTongHop.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridBangKeTongHop.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridBangKeTongHop.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridBangKeTongHop.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridBangKeTongHop.ExportToHtml(exportFilePath);
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
