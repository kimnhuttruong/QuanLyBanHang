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
using DevExpress.XtraEditors.Repository;
using DoAnCK_TTA.DTO;
using System.IO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmPhieuChuyenKho : DevExpress.XtraEditors.XtraUserControl
    {
        public frmPhieuChuyenKho()
        {
            InitializeComponent();
        }

        private void frmPhieuChuyenKho_Load(object sender, EventArgs e)
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
                        {
                            btnSaveAdd.Enabled = false;
                        }
                        //if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                        //    btnXoa.Enabled = false;
                        //if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                        //    btnSuaChua.Enabled = false;
                        //if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                        //    btnXem.Enabled = false;
                        if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                            btnIn.Enabled = false;
                        //if (dt.Rows[i]["AllowExport"].ToString() == "False")
                        //    btnXuat.Enabled = false;
                        //if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //    btnNhap.Enabled = false;
                    }

                }
            }
            load();
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
        public string coma = "";
        public void load()
        {
           
            DataTable  _dtNhanVien = new DataTable();
            BUS_EMPLOYEE busNV = new BUS_EMPLOYEE();
            _dtNhanVien = busNV.LayDanhSachNhanVien();
            lookNguoiChuyen.Properties.DataSource = _dtNhanVien;
            lookNguoiChuyen.Properties.DisplayMember = "Employee_Name";
            lookNguoiChuyen.Properties.ValueMember = "Employee_ID";
            lookNguoiNhan.Properties.DataSource = _dtNhanVien;
            lookNguoiNhan.Properties.DisplayMember = "Employee_Name";
            lookNguoiNhan.Properties.ValueMember = "Employee_ID";

            DataTable _dtKho = new DataTable();
            BUS_STOCK busKho = new BUS_STOCK();
            _dtKho = busKho.LayThongTinKhoHang();
            lookKhoNhan.Properties.DataSource = _dtKho;
            lookKhoNhan.Properties.DisplayMember = "Stock_Name";
            lookKhoNhan.Properties.ValueMember = "Stock_ID";
            lookKhoXuat.Properties.DataSource = _dtKho;
            lookKhoXuat.Properties.DisplayMember = "Stock_Name";
            lookKhoXuat.Properties.ValueMember = "Stock_ID";

            DataTable _dtHangHoa = new DataTable();
            BUS_PRODUCT busHangHoa = new BUS_PRODUCT();
            _dtHangHoa = busHangHoa.LayDanhSachHangHoa();

            RepositoryItemLookUpEdit riLookup_MA = new RepositoryItemLookUpEdit();
            riLookup_MA.DataSource = _dtHangHoa;
            riLookup_MA.ValueMember = "Product_ID";
            riLookup_MA.DisplayMember = "Product_ID";
            RepositoryItemLookUpEdit riLookup_TEN = new RepositoryItemLookUpEdit();
            riLookup_TEN.DataSource = _dtHangHoa;
            riLookup_TEN.ValueMember = "Product_ID";
            riLookup_TEN.DisplayMember = "Product_Name";

            riLookup_MA.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Product_ID", "Mã Hàng", 100));
            riLookup_MA.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Product_Name", "Tên Hàng", 100));

            riLookup_TEN.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Product_Name", "Tên Hàng", 100));
            riLookup_TEN.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Product_ID", "Mã Hàng", 100));


            lookKhoNhan.EditValue = lookKhoNhan.Properties.GetKeyValue(0);
            lookKhoXuat.EditValue = lookKhoXuat.Properties.GetKeyValue(0);

            lookNguoiNhan.EditValue = lookNguoiNhan.Properties.GetKeyValue(0);
            lookNguoiChuyen.EditValue = lookNguoiChuyen.Properties.GetKeyValue(0);
            lookNgay.EditValue = DateTime.Today;
            
           
            if (coma == "")
                txtPhieuCK.Text = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "");


            lookMa.ColumnEdit = riLookup_MA;
            lookTenHang.ColumnEdit = riLookup_TEN;

            DataTable dt = new DataTable();
            dt.Columns.Add("Ma");
            dt.Columns.Add("Ten");
            dt.Columns.Add("DonVi");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            dt.Columns.Add("GhiChu");
            for (int i = 0; i < 20; i++)
            {
                dt.Rows.Add("", "", "")/*,0, 0, 0, 0,0,0)*/;
            }
            gridChuyenKho.DataSource = dt;
        }

        private void gridView5_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            BUS_PRODUCT pd = new BUS_PRODUCT();
            DataTable dtpd = new DataTable();
            dtpd = pd.LayThongTinHangHoa(e.Value.ToString());

            if (dtpd.Rows.Count > 0)
            {
                
                DataTable dtDonViTinh = new DataTable();
                BUS_UNIT busDonVi = new BUS_UNIT();
                dtDonViTinh = busDonVi.LayThongTinDonViTinh(dtpd.Rows[0]["Unit"].ToString());
               
                gridView5.SetRowCellValue(e.RowHandle, "DonVi", dtDonViTinh.Rows[0]["Unit_Name"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "Ten", e.Value);
                gridView5.SetRowCellValue(e.RowHandle, "Ma", e.Value.ToString());
                gridView5.SetRowCellValue(e.RowHandle, "DonGia", dtpd.Rows[0]["Org_Price"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "SoLuong", 1);
            }

        }

        private void btnSaveAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            for (int i = 0; i < gridView5.RowCount; i++)
            {
                DataRow row = gridView5.GetDataRow(i);
                if (row["Ma"].ToString() != "")
                {
                    
                    DTO_STOCK_TRANSFER_DETAIL dTO_STOCK_TRANSFER_DETAIL = new DTO_STOCK_TRANSFER_DETAIL();
                    dTO_STOCK_TRANSFER_DETAIL.ID = txtPhieuCK.Text + i.ToString();
                    dTO_STOCK_TRANSFER_DETAIL.Transfer_ID = txtPhieuCK.Text;
                    dTO_STOCK_TRANSFER_DETAIL.Product_ID = row["Ma"].ToString();
                    dTO_STOCK_TRANSFER_DETAIL.Product_Name = row["Ten"].ToString();
                    dTO_STOCK_TRANSFER_DETAIL.OutStock = lookKhoXuat.EditValue.ToString();
                    dTO_STOCK_TRANSFER_DETAIL.OutStockName = lookKhoXuat.Text.ToString();
                    dTO_STOCK_TRANSFER_DETAIL.InStock = lookKhoNhan.EditValue.ToString();
                    dTO_STOCK_TRANSFER_DETAIL.InStockName = lookKhoNhan.Text.ToString();
                    dTO_STOCK_TRANSFER_DETAIL.Unit = row["DonVi"].ToString();
                    dTO_STOCK_TRANSFER_DETAIL.UnitPrice = row["DonGia"].ToString();
                    dTO_STOCK_TRANSFER_DETAIL.Quantity = row["SoLuong"].ToString();
                    dTO_STOCK_TRANSFER_DETAIL.RefType = txtChuyenTay.Text;
                    dTO_STOCK_TRANSFER_DETAIL.QtyConvert = lookNgay.Text.ToString();


                    BUS_STOCK_TRANSFER_DETAIL TRANSFERdetal = new BUS_STOCK_TRANSFER_DETAIL();
                    int c = TRANSFERdetal.ThemPhieuXuatHang(dTO_STOCK_TRANSFER_DETAIL);
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma");
            dt.Columns.Add("Ten");
            dt.Columns.Add("DonVi");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            dt.Columns.Add("GhiChu");
            for (int i = 0; i < 20; i++)
            {
                dt.Rows.Add("", "", "");
            }
            gridChuyenKho.DataSource = dt;
            gridChuyenKho.Refresh();

            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Lưu";
            busLog.ThemLichSu(log);

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                            gridChuyenKho.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridChuyenKho.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridChuyenKho.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridChuyenKho.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridChuyenKho.ExportToHtml(exportFilePath);
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

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }
    }
}
