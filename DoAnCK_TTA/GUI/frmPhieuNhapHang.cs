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
using DevExpress.XtraPrinting.Caching;
using DoAnCK_TTA.DTO;
using DevExpress.XtraReports.UI;

namespace DoAnCK_TTA.GUI
{
    public partial class frmPhieuNhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        public frmPhieuNhapHang()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        string coma = "";
        private void GetMessage(string  ma)
        {
            if (ma.Length > 0)
            {
                 load();
                coma = ma;
                DataTable dt = new DataTable();
                BUS_STOCK_INWARD bUS_STOCK_INWARD = new BUS_STOCK_INWARD();
                dt = bUS_STOCK_INWARD.LayThongTinBangKeChiTiet(ma);

                //this.Controls.Remove(barDockControlTop);
                //barDockControlTop.Visible = false;
                //barButton.Visible = false;
                btnTaoMoi.Enabled = false;
                btnSaveAdd.Enabled = false;
                btnNapLai.Enabled = false;
                btnDong.Enabled = false;
                btnSaveClose.Caption = "Lưu";


                txtPhieu.Text = dt.Rows[0]["Barcode"].ToString();
                lookNhaCungCap.EditValue = dt.Rows[0]["Customer_ID"].ToString();
                lookMaNCC.EditValue = dt.Rows[0]["Customer_ID"].ToString();
                lookNgay.EditValue = DateTime.Parse(dt.Rows[0]["RefDate"].ToString());
                lookNhanVien.EditValue = dt.Rows[0]["Employee_ID"].ToString();
                lookKho.EditValue = dt.Rows[0]["Stock_ID"].ToString();
                lookDieuKhoan.EditValue = dt.Rows[0]["TermID"].ToString();
                lookHinhThucThanhToan.EditValue = dt.Rows[0]["PaymentMethod"].ToString();
                lookHan.EditValue = dt.Rows[0]["PaymentDate"].ToString();
             

                BUS_PROVIDER busNCC = new BUS_PROVIDER();
                txtDienThoai.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Tel"].ToString();
                txtDiaChi.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
                menoGhiChu.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Description"].ToString();


                DataTable dt1 = new DataTable();
                BUS_STOCK_INWARD_DETAIL bUS = new BUS_STOCK_INWARD_DETAIL();
                
                dt1 = bUS.LayThongTinBangKeChiTietDataTable(ma);
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("Ma");
                dt2.Columns.Add("Ten");
                dt2.Columns.Add("DonVi");
                dt2.Columns.Add("SoLuong");
                dt2.Columns.Add("DonGia");
                dt2.Columns.Add("ThanhTien");
                dt2.Columns.Add("GhiChu");
              
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    dt2.Rows.Add(dt1.Rows[i]["Product_ID"].ToString(), dt1.Rows[i]["Product_ID"].ToString(),
                         dt1.Rows[i]["Unit"].ToString(), dt1.Rows[i]["Quantity"].ToString(),
                           dt1.Rows[i]["UnitPrice"].ToString(), (float.Parse(dt1.Rows[i]["Quantity"].ToString())* 
                                                                        float.Parse(dt1.Rows[i]["UnitPrice"].ToString())).ToString()
                        );
                
                }
                if (dt1.Rows.Count > 0)
                {
                    calcCK.Text = dt1.Rows[0]["Amount"].ToString();
                    calcVat.Text = dt1.Rows[0]["Vat"].ToString();
                    txtTongTien.Text = dt1.Rows[0]["Tong"].ToString();
                    calcTienCK.Text = dt1.Rows[0]["FAmount"].ToString();
                    calcTienVat.Text = dt1.Rows[0]["VatAmount"].ToString();
                }
                gridPhieuNhapHang.DataSource = dt2;
            }
        }
        public delegate void SendMessage(string ma);
        public SendMessage Sender;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        DataTable _dtNhaCungCap = new DataTable();
        DataTable _dtNhanVien = new DataTable();
        DataTable _dtHangHoa = new DataTable();
       
        public void load()
        {
            BUS_PROVIDER busNCC = new BUS_PROVIDER();
            _dtNhaCungCap = busNCC.LayDanhSachNhaCungCap();
            lookNhaCungCap.Properties.DataSource = _dtNhaCungCap;
            lookNhaCungCap.Properties.DisplayMember = "CustomerName";
            lookNhaCungCap.Properties.ValueMember = "Customer_ID";
           

            lookMaNCC.Properties.DataSource = _dtNhaCungCap;
            lookMaNCC.Properties.DisplayMember = "Customer_ID";
            lookMaNCC.Properties.ValueMember = "Customer_ID";

            BUS_EMPLOYEE busNV = new BUS_EMPLOYEE();
            _dtNhanVien = busNV.LayDanhSachNhanVien();
            lookNhanVien.Properties.DataSource = _dtNhanVien;
            lookNhanVien.Properties.DisplayMember = "Employee_Name";
            lookNhanVien.Properties.ValueMember = "Employee_ID";

            DataTable _dtKho = new DataTable();
            BUS_STOCK busKho = new BUS_STOCK();
            _dtKho = busKho.LayThongTinKhoHang();
            lookKho.Properties.DataSource = _dtKho;
            lookKho.Properties.DisplayMember = "Stock_Name";
            lookKho.Properties.ValueMember = "Stock_ID";

            DataTable _dtCash = new DataTable();
            BUS_CASH_METHOD busCASH_METHOD = new BUS_CASH_METHOD();
            _dtCash = busCASH_METHOD.LayDanhCachThanhToan();
            lookHinhThucThanhToan.Properties.DataSource = _dtCash;
            lookHinhThucThanhToan.Properties.DisplayMember = "Name";
            lookHinhThucThanhToan.Properties.ValueMember = "ID";

            DataTable _dtCashTerm = new DataTable();
            BUS_CASH_TERM busCashTerm = new BUS_CASH_TERM();
            _dtCashTerm = busCashTerm.LayDanhCachDieuKhoan();
            lookDieuKhoan.Properties.DataSource = _dtCashTerm;
            lookDieuKhoan.Properties.DisplayMember = "Name";
            lookDieuKhoan.Properties.ValueMember = "ID";


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

            lookHinhThucThanhToan.EditValue = lookHinhThucThanhToan.Properties.GetKeyValue(0);
            lookNhaCungCap.EditValue = lookNhaCungCap.Properties.GetKeyValue(0);
            lookMaNCC.EditValue = lookMaNCC.Properties.GetKeyValue(0);
            lookDieuKhoan.EditValue = lookDieuKhoan.Properties.GetKeyValue(0);
            lookKho.EditValue = lookKho.Properties.GetKeyValue(0);
            lookNhanVien.EditValue = lookNhanVien.Properties.GetKeyValue(0);
            lookNgay.EditValue = DateTime.Today;
            lookHan.EditValue = DateTime.Today;
            txtDienThoai.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Tel"].ToString();
            txtDiaChi.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
            menoGhiChu.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Description"].ToString();
            calcCK.Text = "0";
            calcTienCK.Text = "0";
            calcVat.Text = "0";
            calcTienVat.Text = "0";
            txtTongTien.Text = "0";
            if(coma =="" )
                txtPhieu.Text = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "").Replace("AM", "").Replace("PM", "");


            //lookNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
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
                dt.Rows.Add("", "", "", "", "", "", "");
            }
            gridPhieuNhapHang.DataSource = dt;
        }
        
        private void frmPhieuNhapHang_Load(object sender, EventArgs e)
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
                            btnSaveClose.Enabled = false;
                        }
                        if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                            btnTaoMoi.Enabled = false;
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
            if (coma.Length==0)
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

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }





        private void gridView5_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          
        }
        private void gridView5_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            

        }

        private void gridView5_CellValueChanging_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
                gridView5.SetRowCellValue(e.RowHandle, "Ten", dtpd.Rows[0]["Product_ID"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "Ma", dtpd.Rows[0]["Product_ID"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "DonGia", dtpd.Rows[0]["Org_Price"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "SoLuong", 1);
                gridView5.SetRowCellValue(e.RowHandle, "ThanhTien", dtpd.Rows[0]["Org_Price"].ToString());

            }
            


        }

        private void gridPhieuNhapHang_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void gridView5_KeyPress(object sender, KeyPressEventArgs e)
        {

            //foreach (int i in gridView5.GetSelectedRows())
            //{
            //    DataRow row = gridView5.GetDataRow(i);

            //    gridView5.SetRowCellValue(i, "ThanhTien", row["SoLuong"].ToString());
            //    MessageBox.Show(i.ToString());
            //}
        }

        private void gridView5_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            float a=0;
            foreach (int i in gridView5.GetSelectedRows())
            {
                DataRow row = gridView5.GetDataRow(i);
                string sl = row["SoLuong"].ToString();
                string dg = row["DonGia"].ToString();
                if(sl!="" && dg != "")
                    gridView5.SetRowCellValue(i, "ThanhTien", (float.Parse(sl) * float.Parse(dg)).ToString());

                if (row["ThanhTien"].ToString() != "")
                    a = a + float.Parse(row["ThanhTien"].ToString());



               
            }
            if (txtThanhTien.SummaryText != "")
            {
                txtTongTien.Text = (float.Parse(txtThanhTien.SummaryText)+ a - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text) ).ToString();
               
            }

            if (txtThanhTien.SummaryText != "")
                calcTienCK.Text = (float.Parse(calcCK.Text) / 100 * (a+ float.Parse(txtThanhTien.SummaryText))).ToString();

            if (txtThanhTien.SummaryText != "")
                calcTienVat.Text = (float.Parse(calcVat.Text) / 100 * (a+ float.Parse(txtThanhTien.SummaryText))).ToString(); ;

            
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
        }

        private void btnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtSoHoaDon.Text = "";
            txtSoPhieu.Text = "";
            gridPhieuNhapHang.Refresh();


        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
            

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //gridPhieuNhapHang.ShowPrintPreview();
            List<DTO_STOCK_INWARD_DETAIL> list = new List<DTO_STOCK_INWARD_DETAIL>();

            for (int i = 0; i < gridView5.RowCount; i++)
            {
                DataRow row = gridView5.GetDataRow(i);
                if (row["Ma"].ToString() != "")
                {
                    DTO_STOCK_INWARD_DETAIL dTO_STOCK_INWARD_DETAIL = new DTO_STOCK_INWARD_DETAIL();
                    dTO_STOCK_INWARD_DETAIL.ID = txtPhieu.Text + i.ToString();
                    dTO_STOCK_INWARD_DETAIL.Inward_ID = txtPhieu.Text;
                    dTO_STOCK_INWARD_DETAIL.Stock_ID = lookKho.EditValue.ToString();
                    dTO_STOCK_INWARD_DETAIL.Product_ID = row["Ma"].ToString();
                    BUS_PRODUCT bUS_PRODUCT = new BUS_PRODUCT();
                    DataTable dt = bUS_PRODUCT.LayThongTinHangHoa(row["Ma"].ToString());
                    dTO_STOCK_INWARD_DETAIL.ProductName = dt.Rows[0][1].ToString();
                    dTO_STOCK_INWARD_DETAIL.Customer_ID = lookMaNCC.EditValue.ToString();
                    dTO_STOCK_INWARD_DETAIL.Unit = row["DonVi"].ToString();
                    dTO_STOCK_INWARD_DETAIL.UnitPrice = row["DonGia"].ToString();
                    dTO_STOCK_INWARD_DETAIL.Quantity = row["SoLuong"].ToString();
                    dTO_STOCK_INWARD_DETAIL.UnitPrice = row["DonGia"].ToString();
                    dTO_STOCK_INWARD_DETAIL.Amount = txtTongTien.Text;
                    dTO_STOCK_INWARD_DETAIL.Description = menoGhiChu.Text;
                    list.Add(dTO_STOCK_INWARD_DETAIL);
                }
            }
            DataTable congty = new DataTable();
            BUS_COMPANY bUS = new BUS_COMPANY();
            congty = bUS.LayThongTinCongTy();

            reportNhapHang report = new reportNhapHang();
            ReportPrintTool printTool = new ReportPrintTool(report);


           
            report.InitData( congty.Rows[0][1].ToString(), congty.Rows[0][2].ToString(), congty.Rows[0][4].ToString(), congty.Rows[0][8].ToString(), congty.Rows[0][5].ToString(), txtPhieu.Text, lookNhaCungCap.Text,txtDiaChi.Text, menoGhiChu.Text, txtTongTien.Text,calcSoLuong.SummaryText,txtThanhTien.SummaryText,calcVat.Text,calcTienVat.Text,list);

            report.CreateDocument();
            // Show the report's Print Preview in a dialog window.
            printTool.ShowPreviewDialog();
        }

        private void calcCK_EditValueChanged(object sender, EventArgs e)
        {
            if (txtThanhTien.SummaryText != "")
            {
                calcTienCK.Text = (float.Parse(calcCK.Text) / 100 * float.Parse(txtThanhTien.SummaryText)).ToString(); ;
                txtTongTien.Text = (float.Parse(txtThanhTien.SummaryText) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text)).ToString();
            }
        }

        private void calcVat_EditValueChanged(object sender, EventArgs e)
        {
            if (txtThanhTien.SummaryText != "")
            {
                calcTienVat.Text = (float.Parse(calcVat.Text) / 100 * float.Parse(txtThanhTien.SummaryText)).ToString(); ;
                txtTongTien.Text = (float.Parse(txtThanhTien.SummaryText) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text)).ToString();
            }
        }

        private void gridView5_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

           
        }

        private void gridView5_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView5_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
           
        }

        private void gridPhieuNhapHang_Click(object sender, EventArgs e)
        {
          
        }

        private void gridView5_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (txtThanhTien.SummaryText != "")
            {
                calcTienVat.Text = (float.Parse(calcVat.Text) / 100 * float.Parse(txtThanhTien.SummaryText)).ToString(); ;
                txtTongTien.Text = (float.Parse(txtThanhTien.SummaryText) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text)).ToString();
            }
        }

        private void gridView5_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void gridView5_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            var mainWindow = new frmThongTinNhaCungCap();
            DTO_PROVIDER dTO_PROVIDER = new DTO_PROVIDER();
           

            dTO_PROVIDER.Customer_ID = _dtNhaCungCap.Rows[_dtNhaCungCap.Rows.Count - 1][0].ToString();

            dTO_PROVIDER.Customer_ID = dTO_PROVIDER.Customer_ID.Remove(0, 3);

            dTO_PROVIDER.Customer_ID = (int.Parse(dTO_PROVIDER.Customer_ID) + 1).ToString("00000");
            dTO_PROVIDER.Customer_ID = "NCC" + dTO_PROVIDER.Customer_ID.ToString();

            mainWindow.Sender(dTO_PROVIDER);    //Gọi delegate
            mainWindow.ShowDialog();
            
        }

        private void lookNhaCungCap_EditValueChanged(object sender, EventArgs e)
        {
            lookMaNCC.EditValue = lookNhaCungCap.EditValue;
            BUS_PROVIDER busNCC = new BUS_PROVIDER();
            txtDienThoai.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Tel"].ToString();
            txtDiaChi.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
            menoGhiChu.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Description"].ToString();
        }

        private void lookMaNCC_EditValueChanged(object sender, EventArgs e)
        {
            lookNhaCungCap.EditValue = lookMaNCC.EditValue;
            BUS_PROVIDER busNCC = new BUS_PROVIDER();
            txtDienThoai.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Tel"].ToString();
            txtDiaChi.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
            menoGhiChu.Text = busNCC.LayThongTinNhaCungCap(lookMaNCC.EditValue.ToString()).Rows[0]["Description"].ToString();
        }

        private void btnSaveAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DTO_INVENTORY_DETAIL _DETAIL = new DTO_INVENTORY_DETAIL();
            DTO_STOCK_INWARD phieu = new DTO_STOCK_INWARD();
            phieu.ID = txtPhieu.Text;
            phieu.RefDate = lookNgay.Text;
            phieu.PaymentMethod = lookHinhThucThanhToan.EditValue.ToString();
            phieu.TermID = lookDieuKhoan.EditValue.ToString();
            phieu.PaymentDate = lookHan.EditValue.ToString();
            phieu.Barcode = txtPhieu.Text;
            phieu.Employee_ID = lookNhanVien.EditValue.ToString();
            phieu.Stock_ID = lookKho.EditValue.ToString();
            phieu.Customer_ID = lookMaNCC.EditValue.ToString();
            phieu.CustomerName = lookNhaCungCap.Text.ToString();
            phieu.CustomerAddress = txtDiaChi.Text;
            phieu.Payment = txtThanhTien.SummaryText;
            phieu.Vat = calcVat.Text;
            phieu.VatAmount = calcTienVat.Text;
            phieu.Amount = calcCK.Text;
            phieu.FAmount = calcCK.Text;
            phieu.Charge = txtThanhTien.SummaryText;
            phieu.Description = menoGhiChu.Text;
            phieu.Ref_OrgNo = txtSoPhieu.Text;
            phieu.RefStatus = txtSoHoaDon.Text;
            BUS_STOCK_INWARD inward = new BUS_STOCK_INWARD();
            int b = inward.ThemPhieuNhapHang(phieu);
            for (int i = 0; i < gridView5.RowCount; i++)
            {
                DataRow row = gridView5.GetDataRow(i);
                if (row["Ma"].ToString() != "")
                {
                    _DETAIL.ID = txtPhieu.Text + i.ToString();
                    _DETAIL.RefNo = txtPhieu.Text;
                    _DETAIL.RefDate = lookNgay.EditValue.ToString();
                    _DETAIL.Stock_ID = lookKho.EditValue.ToString();
                    _DETAIL.Product_ID = row["Ma"].ToString();
                    _DETAIL.Product_Name = lookTenHang.ColumnEdit.ToString();
                    _DETAIL.Customer_ID = lookMaNCC.EditValue.ToString();
                    _DETAIL.Employee_ID = lookNhanVien.EditValue.ToString();
                    _DETAIL.Unit = row["DonVi"].ToString();
                    _DETAIL.Price = row["DonGia"].ToString();
                    _DETAIL.Quantity = row["SoLuong"].ToString();
                    _DETAIL.UnitPrice = row["DonGia"].ToString();
                    _DETAIL.Amount = txtTongTien.Text;
                    _DETAIL.E_Qty = calcCK.Text;
                    _DETAIL.E_Amt = calcVat.Text;
                    _DETAIL.Description = menoGhiChu.Text;

                   

                    DTO_STOCK_INWARD_DETAIL dTO_STOCK_INWARD_DETAIL = new DTO_STOCK_INWARD_DETAIL();
                   dTO_STOCK_INWARD_DETAIL.ID = txtPhieu.Text + i.ToString();
                   dTO_STOCK_INWARD_DETAIL.Inward_ID = txtPhieu.Text;
                   dTO_STOCK_INWARD_DETAIL.Stock_ID = lookKho.EditValue.ToString();
                   dTO_STOCK_INWARD_DETAIL.Product_ID = row["Ma"].ToString();
                   dTO_STOCK_INWARD_DETAIL.ProductName = row["Ten"].ToString();
                   dTO_STOCK_INWARD_DETAIL.Customer_ID = lookMaNCC.EditValue.ToString();
                   dTO_STOCK_INWARD_DETAIL.Unit = row["DonVi"].ToString();
                   dTO_STOCK_INWARD_DETAIL.UnitPrice = row["DonGia"].ToString();
                   dTO_STOCK_INWARD_DETAIL.Quantity = row["SoLuong"].ToString();
                   dTO_STOCK_INWARD_DETAIL.UnitPrice = row["DonGia"].ToString();
                   dTO_STOCK_INWARD_DETAIL.Amount = txtTongTien.Text;
                   dTO_STOCK_INWARD_DETAIL.Description = menoGhiChu.Text;


                  
                    BUS_STOCK_INWARD_DETAIL inwarddetal = new BUS_STOCK_INWARD_DETAIL();
                    BUS_INVENTORY_DETAIL bus = new BUS_INVENTORY_DETAIL();
                    int a = bus.ThemPhieuNhapHang(_DETAIL);
                   
                    int c = inwarddetal.ThemPhieuNhapHang(dTO_STOCK_INWARD_DETAIL);

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
                dt.Rows.Add("", "", "", "", "", "", "");
            }
            gridPhieuNhapHang.DataSource = dt;
            gridPhieuNhapHang.Refresh();
        }

        private void btnSaveClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DTO_STOCK_INWARD phieu = new DTO_STOCK_INWARD();
            DTO_INVENTORY_DETAIL _DETAIL = new DTO_INVENTORY_DETAIL();
            phieu.ID = txtPhieu.Text;
            phieu.RefDate = lookNgay.Text;
            phieu.PaymentMethod = lookHinhThucThanhToan.EditValue.ToString();
            phieu.TermID = lookDieuKhoan.EditValue.ToString();
            phieu.PaymentDate = lookHan.EditValue.ToString();
            phieu.Barcode = txtPhieu.Text;
            phieu.Employee_ID = lookNhanVien.EditValue.ToString();
            phieu.Stock_ID = lookKho.EditValue.ToString();
            phieu.Customer_ID = lookMaNCC.EditValue.ToString();
            phieu.CustomerName = lookNhaCungCap.Text.ToString();
            phieu.CustomerAddress = txtDiaChi.Text;
            phieu.Payment = txtThanhTien.SummaryText;
            phieu.Vat = calcVat.Text;
            phieu.VatAmount = calcTienVat.Text;
            phieu.Amount = calcCK.Text;
            phieu.FAmount = calcCK.Text;
            phieu.Charge = txtThanhTien.SummaryText;
            phieu.Description = menoGhiChu.Text;
            phieu.Ref_OrgNo = txtSoPhieu.Text;
            phieu.RefStatus = txtSoHoaDon.Text;
            BUS_STOCK_INWARD inward = new BUS_STOCK_INWARD();
            int b = inward.ThemPhieuNhapHang(phieu);

            BUS_STOCK_INWARD_DETAIL inwarddetal = new BUS_STOCK_INWARD_DETAIL();
            inwarddetal.XoaFullPhieuNhapHang(phieu.ID);
            BUS_INVENTORY_DETAIL bus = new BUS_INVENTORY_DETAIL();
            bus.XoaPhieuNhapHang(phieu.ID);
            for (int i = 0; i < gridView5.RowCount; i++)
            {
                DataRow row = gridView5.GetDataRow(i);
              


                if (row["Ma"].ToString() != "")
                {
                    _DETAIL.ID = txtPhieu.Text + i.ToString();
                    _DETAIL.RefNo = txtPhieu.Text;
                    _DETAIL.RefDate = lookNgay.EditValue.ToString();
                    _DETAIL.Stock_ID = lookKho.EditValue.ToString();
                    _DETAIL.Product_ID = row["Ma"].ToString();
                    _DETAIL.Product_Name = row["Ten"].ToString();
                    _DETAIL.Customer_ID = lookMaNCC.EditValue.ToString();
                    _DETAIL.Employee_ID = lookNhanVien.EditValue.ToString();
                    _DETAIL.Unit = row["DonVi"].ToString();
                    _DETAIL.Price = row["DonGia"].ToString();
                    _DETAIL.Quantity = row["SoLuong"].ToString();
                    _DETAIL.UnitPrice = row["DonGia"].ToString();
                    _DETAIL.Amount = txtTongTien.Text;
                    _DETAIL.E_Qty = calcCK.Text;
                    _DETAIL.E_Amt = calcVat.Text;
                    _DETAIL.Description = menoGhiChu.Text;

                 


                    DTO_STOCK_INWARD_DETAIL dTO_STOCK_INWARD_DETAIL = new DTO_STOCK_INWARD_DETAIL();
                    dTO_STOCK_INWARD_DETAIL.ID = txtPhieu.Text + i.ToString();
                    dTO_STOCK_INWARD_DETAIL.Inward_ID = txtPhieu.Text;
                    dTO_STOCK_INWARD_DETAIL.Stock_ID = lookKho.EditValue.ToString();
                    dTO_STOCK_INWARD_DETAIL.Product_ID = row["Ma"].ToString();
                    dTO_STOCK_INWARD_DETAIL.ProductName = row["Ten"].ToString();
                    dTO_STOCK_INWARD_DETAIL.Customer_ID = lookMaNCC.EditValue.ToString();
                    dTO_STOCK_INWARD_DETAIL.Unit = row["DonVi"].ToString();
                    dTO_STOCK_INWARD_DETAIL.UnitPrice = row["DonGia"].ToString();
                    dTO_STOCK_INWARD_DETAIL.Quantity = row["SoLuong"].ToString();
                    dTO_STOCK_INWARD_DETAIL.UnitPrice = row["DonGia"].ToString();
                    dTO_STOCK_INWARD_DETAIL.Amount = txtTongTien.Text;
                    dTO_STOCK_INWARD_DETAIL.Description = menoGhiChu.Text;


                    
                  
                    int a = bus.ThemPhieuNhapHang(_DETAIL);
                   
                    int c = inwarddetal.ThemPhieuNhapHang(dTO_STOCK_INWARD_DETAIL);

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
            }
            this.Visible = false;
        }

        private void lookNgay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPhieu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView5_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            
        }
    }
}
