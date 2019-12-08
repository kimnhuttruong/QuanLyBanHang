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


                txtPhieu.Text = dt.Rows[0]["Barcode"].ToString();
                lookNhaCungCap.EditValue = dt.Rows[0]["Customer_ID"].ToString();
                lookMaNCC.EditValue = dt.Rows[0]["Customer_ID"].ToString();
                lookNgay.EditValue = DateTime.Parse(dt.Rows[0]["RefDate"].ToString());
                lookNhanVien.EditValue = dt.Rows[0]["Employee_ID"].ToString();
                lookKho.EditValue = dt.Rows[0]["Stock_ID"].ToString();
                lookDieuKhoan.EditValue = dt.Rows[0]["TermID"].ToString();
                lookHinhThucThanhToan.EditValue = dt.Rows[0]["PaymentMethod"].ToString();
                lookHan.EditValue = dt.Rows[0]["PaymentDate"].ToString();

                DataTable dt1 = new DataTable();
                BUS_STOCK_INWARD_DETAIL bUS = new BUS_STOCK_INWARD_DETAIL();
                dt1 = bUS.LayThongTinBangKeChiTiet(ma);


                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    //gridView5.SetRowCellValue(i, "Ma", dt1.Rows[i]["Product_ID"].ToString());
                    //  gridView5.SetRowCellValue(i, lookMa, dt1.Rows[i]["Product_ID"].ToString());

                    //    gridView5.SetRowCellValue(i, "GhiChu", dt1.Rows[i]["Product_ID"].ToString());
                    gridView5.SetRowCellValue(i, "SoLuong", "xin chào");
                }
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
            lookDieuKhoan.EditValue = lookDieuKhoan.Properties.GetKeyValue(0);
            lookKho.EditValue = lookKho.Properties.GetKeyValue(0);
            lookNhanVien.EditValue = lookNhanVien.Properties.GetKeyValue(0);
            lookNgay.EditValue = DateTime.Today;
            lookHan.EditValue = DateTime.Today;
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

            load();
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

                if(row["ThanhTien"].ToString() != "")
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
            gridPhieuNhapHang.ShowPrintPreview();
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
        }

        private void lookMaNCC_EditValueChanged(object sender, EventArgs e)
        {
            lookNhaCungCap.EditValue = lookMaNCC.EditValue;
        }

        private void btnSaveAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DTO_INVENTORY_DETAIL _DETAIL = new DTO_INVENTORY_DETAIL();
            DTO_STOCK_INWARD phieu = new DTO_STOCK_INWARD();
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

                    phieu.ID = txtPhieu.Text + i.ToString();
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
                    phieu.Description = menoGhiChu.Text ;
                    phieu.Ref_OrgNo = txtSoPhieu.Text;
                    phieu.RefStatus = txtSoHoaDon.Text;

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


                    BUS_STOCK_INWARD inward = new BUS_STOCK_INWARD();
                    BUS_STOCK_INWARD_DETAIL inwarddetal = new BUS_STOCK_INWARD_DETAIL();
                    BUS_INVENTORY_DETAIL bus = new BUS_INVENTORY_DETAIL();
                    int a = bus.ThemPhieuNhapHang(_DETAIL);
                    int b = inward.ThemPhieuNhapHang(phieu);
                    int c = inwarddetal.ThemPhieuNhapHang(dTO_STOCK_INWARD_DETAIL);
                }
            }
            gridPhieuNhapHang.Refresh();
        }

        private void btnSaveClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DTO_STOCK_INWARD phieu = new DTO_STOCK_INWARD();
            DTO_INVENTORY_DETAIL _DETAIL = new DTO_INVENTORY_DETAIL();
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

                    phieu.ID = txtPhieu.Text + i.ToString();
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


                    BUS_STOCK_INWARD inward = new BUS_STOCK_INWARD();
                    BUS_STOCK_INWARD_DETAIL inwarddetal = new BUS_STOCK_INWARD_DETAIL();
                    BUS_INVENTORY_DETAIL bus = new BUS_INVENTORY_DETAIL();
                    int a = bus.ThemPhieuNhapHang(_DETAIL);
                    int b = inward.ThemPhieuNhapHang(phieu);
                    int c = inwarddetal.ThemPhieuNhapHang(dTO_STOCK_INWARD_DETAIL);


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
            DataTable dt1 = new DataTable();
            BUS_STOCK_INWARD_DETAIL bUS = new BUS_STOCK_INWARD_DETAIL();
            dt1 = bUS.LayThongTinBangKeChiTiet(coma);


            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                //gridView5.SetRowCellValue(i, "Ma", dt1.Rows[i]["Product_ID"].ToString());
                //  gridView5.SetRowCellValue(i, lookMa, dt1.Rows[i]["Product_ID"].ToString());

                //    gridView5.SetRowCellValue(i, "GhiChu", dt1.Rows[i]["Product_ID"].ToString());
                gridView5.SetRowCellValue(i, "SoLuong", "xin chào");
            }
        }
    }
}
