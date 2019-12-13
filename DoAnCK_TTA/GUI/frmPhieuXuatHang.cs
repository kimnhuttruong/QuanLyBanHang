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

namespace DoAnCK_TTA.GUI
{
    public partial class frmPhieuXuatHang : DevExpress.XtraEditors.XtraUserControl
    {
        public frmPhieuXuatHang()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        string coma = "";
        private void GetMessage(string ma)
        {
            if (ma.Length > 0)
            {
                load();
                coma = ma;
                DataTable dt = new DataTable();
                BUS_STOCK_OUTWARD bUS_STOCK_OUTWARD = new BUS_STOCK_OUTWARD();
                dt = bUS_STOCK_OUTWARD.LayThongTinBangKeChiTiet(ma);

                //this.Controls.Remove(barDockControlTop);
                //barDockControlTop.Visible = false;
                //barButton.Visible = false;
                btnTaoMoi.Enabled = false;
                btnSaveAdd.Enabled = false;
                btnNapLai.Enabled = false;
                btnDong.Enabled = false;
                btnSaveClose.Caption = "Lưu";


                txtPhieu.Text = dt.Rows[0]["Barcode"].ToString();
                lookKhachHang.EditValue = dt.Rows[0]["Customer_ID"].ToString();
                lookMaKH.EditValue = dt.Rows[0]["Customer_ID"].ToString();
                lookNgay.EditValue = DateTime.Parse(dt.Rows[0]["RefDate"].ToString());
                lookNhanVien.EditValue = dt.Rows[0]["Employee_ID"].ToString();
                lookKho.EditValue = dt.Rows[0]["Stock_ID"].ToString();
                lookDieuKhoan.EditValue = dt.Rows[0]["TermID"].ToString();
                lookHinhThucThanhToan.EditValue = dt.Rows[0]["PaymentMethod"].ToString();
                lookHan.EditValue = dt.Rows[0]["PaymentDate"].ToString();


                BUS_CUSTOMER busKH = new BUS_CUSTOMER();
                txtDienThoai.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Tel"].ToString();
                txtDiaChi.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
                memoGhiChu.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Description"].ToString();


                DataTable dt1 = new DataTable();
                BUS_STOCK_OUTWARD_DETAIL bUS = new BUS_STOCK_OUTWARD_DETAIL();

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
                           dt1.Rows[i]["UnitPrice"].ToString(), (float.Parse(dt1.Rows[i]["Quantity"].ToString()) *
                                                                        float.Parse(dt1.Rows[i]["UnitPrice"].ToString())).ToString()
                        );

                }

                gridPhieuXuatHang.DataSource = dt2;
            }
        }
        public delegate void SendMessage(string ma);
        public SendMessage Sender;
        DataTable _dtKhachHang = new DataTable();
        DataTable _dtNhanVien = new DataTable();
        DataTable _dtHangHoa = new DataTable();
        public void load()
        {
            BUS_CUSTOMER busKH = new BUS_CUSTOMER();
            _dtKhachHang = busKH.LayDanhSachKhachHang();
            lookKhachHang.Properties.DataSource = _dtKhachHang;
            lookKhachHang.Properties.DisplayMember = "CustomerName";
            lookKhachHang.Properties.ValueMember = "Customer_ID";


            lookMaKH.Properties.DataSource = _dtKhachHang;
            lookMaKH.Properties.DisplayMember = "Customer_ID";
            lookMaKH.Properties.ValueMember = "Customer_ID";

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
            lookKhachHang.EditValue = lookKhachHang.Properties.GetKeyValue(0);
            lookMaKH.EditValue = lookMaKH.Properties.GetKeyValue(0);
            lookDieuKhoan.EditValue = lookDieuKhoan.Properties.GetKeyValue(0);
            lookKho.EditValue = lookKho.Properties.GetKeyValue(0);
            lookNhanVien.EditValue = lookNhanVien.Properties.GetKeyValue(0);
            lookNgay.EditValue = DateTime.Today;
            lookHan.EditValue = DateTime.Today;
            dateNgayGiao.EditValue = DateTime.Today;
            txtDienThoai.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Tel"].ToString();
            txtDiaChi.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
            memoGhiChu.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Description"].ToString();
            calcCK.Text = "0";
            calcTienCK.Text = "0";
            calcVat.Text = "0";
            calcTienVat.Text = "0";
            txtTongTien.Text = "0";
            if (coma == "")
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
            dt.Columns.Add("CK");
            dt.Columns.Add("ChiecKhau");
            dt.Columns.Add("ThanhToan");
            for (int i = 0; i < 20; i++)
            {
                dt.Rows.Add("", "", "")/*,0, 0, 0, 0,0,0)*/;
            }
            gridPhieuXuatHang.DataSource = dt;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuXuatHang_Load(object sender, EventArgs e)
        {
            if (coma.Length == 0)
                load();
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
                gridView5.SetRowCellValue(e.RowHandle, "Ten", dtpd.Rows[0]["Product_ID"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "Ma", dtpd.Rows[0]["Product_ID"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "DonGia", dtpd.Rows[0]["Org_Price"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "SoLuong", 1);
                gridView5.SetRowCellValue(e.RowHandle, "ThanhTien", dtpd.Rows[0]["Org_Price"].ToString());
                gridView5.SetRowCellValue(e.RowHandle, "CK", 0);
                gridView5.SetRowCellValue(e.RowHandle, "ChiecKhau", 0);
                gridView5.SetRowCellValue(e.RowHandle, "ThanhToan", dtpd.Rows[0]["Org_Price"].ToString());

            }



        }

        private void gridView5_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
            float a = 0;
            foreach (int i in gridView5.GetSelectedRows())
            {
                DataRow row = gridView5.GetDataRow(i);
                string sl = row["SoLuong"].ToString();
                string dg = row["DonGia"].ToString();
                string ck = row["CK"].ToString();
                if (sl != "" && dg != "")
                {
                    gridView5.SetRowCellValue(i, "ThanhTien", (float.Parse(sl) * float.Parse(dg)).ToString());
                    gridView5.SetRowCellValue(i, "ThanhToan", (float.Parse(sl) * float.Parse(dg))*(1-float.Parse(ck)*0.01));
                    gridView5.SetRowCellValue(i, "ChiecKhau", (float.Parse(sl) * float.Parse(dg)) * (float.Parse(ck) * 0.01));
                }

            }
            
             //   a = a + float.Parse( row["ThanhTien"].ToString()) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text);
           


            if (txtThanhTien.SummaryText != "")
            {
                txtTongTien.Text = (float.Parse(TongThanhToan.SummaryText) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text)).ToString();
                calcTienCK.Text = (float.Parse(calcCK.Text) / 100 * (float.Parse(TongThanhToan.SummaryText))).ToString();
                calcTienVat.Text = (float.Parse(calcVat.Text) / 100 * (float.Parse(TongThanhToan.SummaryText))).ToString(); ;
            }

        }

        private void barStaticItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
        }

        private void barStaticItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtSoHoaDon.Text = "";
            txtSoPhieu.Text = "";
            gridPhieuXuatHang.Refresh();

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridPhieuXuatHang.ShowPrintPreview();
        }

        private void calcCK_EditValueChanged(object sender, EventArgs e)
        {
            if (txtThanhTien.SummaryText != "")
            {
                calcTienCK.Text = (float.Parse(calcCK.Text) / 100 * float.Parse(TongThanhToan.SummaryText)).ToString(); ;
                txtTongTien.Text = (float.Parse(TongThanhToan.SummaryText) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text)).ToString();
            }
        }

        private void calcVat_EditValueChanged(object sender, EventArgs e)
        {
            if (txtThanhTien.SummaryText != "")
            {
                calcTienVat.Text = (float.Parse(calcVat.Text) / 100 * float.Parse(TongThanhToan.SummaryText)).ToString(); ;
                txtTongTien.Text = (float.Parse(TongThanhToan.SummaryText) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text)).ToString();
            }
        }

        private void gridView5_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (txtThanhTien.SummaryText != "")
            {
                calcTienVat.Text = (float.Parse(calcVat.Text) / 100 * float.Parse(TongThanhToan.SummaryText)).ToString(); ;
                txtTongTien.Text = (float.Parse(TongThanhToan.SummaryText) - float.Parse(calcTienCK.Text) + float.Parse(calcTienVat.Text)).ToString();
            }
        }

        private void lookKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            lookMaKH.EditValue = lookKhachHang.EditValue;
            BUS_CUSTOMER busKH = new BUS_CUSTOMER();
            txtDienThoai.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Tel"].ToString();
            txtDiaChi.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
            memoGhiChu.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Description"].ToString();
        }

        private void lookMaKH_EditValueChanged(object sender, EventArgs e)
        {
            lookKhachHang.EditValue = lookMaKH.EditValue;
            BUS_CUSTOMER busKH = new BUS_CUSTOMER();
            txtDienThoai.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Tel"].ToString();
            txtDiaChi.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["CustomerAddress"].ToString();
            memoGhiChu.Text = busKH.LayThongTinKhachHang(lookMaKH.EditValue.ToString()).Rows[0]["Description"].ToString();
        }

        private void btnSaveAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            DTO_STOCK_OUTWARD phieu = new DTO_STOCK_OUTWARD();
            DTO_STOCK_OUTWARD_DETAIL phieuchitiet = new DTO_STOCK_OUTWARD_DETAIL();

            phieu.DeliveryDate = dateNgayGiao.Text;
            phieu.ID = txtPhieu.Text ;
            phieu.RefDate = lookNgay.Text;
            phieu.PaymentMethod = lookHinhThucThanhToan.EditValue.ToString();
            phieu.TermID = lookDieuKhoan.EditValue.ToString();
            phieu.PaymentDate = lookHan.EditValue.ToString();
            phieu.Barcode = txtPhieu.Text;
            phieu.Employee_ID = lookNhanVien.EditValue.ToString();
            phieu.Stock_ID = lookKho.EditValue.ToString();
            phieu.Customer_ID = lookMaKH.EditValue.ToString();
            phieu.CustomerName = lookKhachHang.Text.ToString();
            phieu.CustomerAddress = txtDiaChi.Text;
            phieu.Payment = txtThanhTien.SummaryText;
            phieu.Vat = calcVat.Text;
            phieu.VatAmount = calcTienVat.Text;
            phieu.Amount = calcCK.Text;
            phieu.FAmount = calcCK.Text;
            phieu.Charge = txtTongTien.Text;
            phieu.Description = memoGhiChu.Text;
            phieu.Ref_OrgNo = txtSoPhieu.Text;
            phieu.RefStatus = txtSoHoaDon.Text;
            BUS_STOCK_OUTWARD inward = new BUS_STOCK_OUTWARD();
            int b = inward.ThemPhieuXuatHang(phieu);
            for (int i = 0; i < gridView5.RowCount; i++)
            {
                DataRow row = gridView5.GetDataRow(i);
                if (row["Ma"].ToString() != "")
                {
                    DTO_INVENTORY_DETAIL _DETAIL = new DTO_INVENTORY_DETAIL();
                    _DETAIL.ID = txtPhieu.Text + i.ToString();
                    _DETAIL.RefNo = txtPhieu.Text;
                    _DETAIL.RefDate = lookNgay.EditValue.ToString();
                    _DETAIL.Stock_ID = lookKho.EditValue.ToString();
                    _DETAIL.Product_ID = row["Ma"].ToString();
                    _DETAIL.Product_Name = lookTenHang.ColumnEdit.ToString();
                    _DETAIL.Employee_ID = lookNhanVien.EditValue.ToString();
                    _DETAIL.Unit = row["DonVi"].ToString();
                    _DETAIL.Price = row["DonGia"].ToString();
                    _DETAIL.Quantity = "-"+row["SoLuong"].ToString();
                    _DETAIL.UnitPrice = row["DonGia"].ToString();
                    _DETAIL.Amount = txtTongTien.Text;
                    _DETAIL.E_Qty = calcCK.Text;
                    _DETAIL.E_Amt = calcVat.Text;

                    phieuchitiet.ID = txtPhieu.Text + i.ToString();
                    phieuchitiet.Outward_ID = txtPhieu.Text;
                    phieuchitiet.Stock_ID = lookKho.EditValue.ToString();
                    phieuchitiet.Product_ID = row["Ma"].ToString();
                    phieuchitiet.ProductName = row["Ten"].ToString();
                    phieuchitiet.Unit = row["DonVi"].ToString();
                    phieuchitiet.UnitPrice = row["DonGia"].ToString();
                    phieuchitiet.Quantity = row["SoLuong"].ToString();
                    phieuchitiet.UnitPrice = row["DonGia"].ToString();
                    phieuchitiet.Discount = row["CK"].ToString();
                    phieuchitiet.DiscountRate = row["ChiecKhau"].ToString();
                    phieuchitiet.Amount = row["ThanhToan"].ToString();
                    phieuchitiet.Description = memoGhiChu.Text;


                    BUS_INVENTORY_DETAIL bus = new BUS_INVENTORY_DETAIL();
                    int a = bus.ThemPhieuNhapHang(_DETAIL);
                    BUS_STOCK_OUTWARD_DETAIL inwarddetal = new BUS_STOCK_OUTWARD_DETAIL();
                   
                    int c = inwarddetal.ThemPhieuXuatHang(phieuchitiet);
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma");
            dt.Columns.Add("Ten");
            dt.Columns.Add("DonVi");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            dt.Columns.Add("CK");
            dt.Columns.Add("ChiecKhau");
            for (int i = 0; i < 20; i++)
            {
                dt.Rows.Add("", "", "");
            }
            gridPhieuXuatHang.DataSource = dt;
            gridPhieuXuatHang.Refresh();
        }

        private void btnSaveClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DTO_STOCK_OUTWARD phieu = new DTO_STOCK_OUTWARD();
            DTO_STOCK_OUTWARD_DETAIL phieuchitiet = new DTO_STOCK_OUTWARD_DETAIL();

            phieu.DeliveryDate = dateNgayGiao.Text;
            phieu.ID = txtPhieu.Text ;
            phieu.RefDate = lookNgay.Text;
            phieu.PaymentMethod = lookHinhThucThanhToan.EditValue.ToString();
            phieu.TermID = lookDieuKhoan.EditValue.ToString();
            phieu.PaymentDate = lookHan.EditValue.ToString();
            phieu.Barcode = txtPhieu.Text;
            phieu.Employee_ID = lookNhanVien.EditValue.ToString();
            phieu.Stock_ID = lookKho.EditValue.ToString();
            phieu.Customer_ID = lookMaKH.EditValue.ToString();
            phieu.CustomerName = lookKhachHang.Text.ToString();
            phieu.CustomerAddress = txtDiaChi.Text;
            phieu.Payment = txtThanhTien.SummaryText;
            phieu.Vat = calcVat.Text;
            phieu.VatAmount = calcTienVat.Text;
            phieu.Amount = calcCK.Text;
            phieu.FAmount = calcCK.Text;
            phieu.Charge = txtTongTien.Text;
            phieu.Description = memoGhiChu.Text;
            phieu.Ref_OrgNo = txtSoPhieu.Text;
            phieu.RefStatus = txtSoHoaDon.Text;
            BUS_STOCK_OUTWARD inward = new BUS_STOCK_OUTWARD();
            int b = inward.ThemPhieuXuatHang(phieu);
            for (int i = 0; i < gridView5.RowCount; i++)
            {
                DataRow row = gridView5.GetDataRow(i);
                if (row["Ma"].ToString() != "")
                {

                  


                    phieuchitiet.ID = txtPhieu.Text + i.ToString();
                    phieuchitiet.Outward_ID = txtPhieu.Text;
                    phieuchitiet.Stock_ID = lookKho.EditValue.ToString();
                    phieuchitiet.Product_ID = row["Ma"].ToString();
                    phieuchitiet.ProductName = row["Ten"].ToString();
                    phieuchitiet.Unit = row["DonVi"].ToString();
                    phieuchitiet.UnitPrice = row["DonGia"].ToString();
                    phieuchitiet.Quantity = row["SoLuong"].ToString();
                    phieuchitiet.UnitPrice = row["DonGia"].ToString();
                    phieuchitiet.Discount = row["CK"].ToString();
                    phieuchitiet.DiscountRate = row["ChiecKhau"].ToString();
                    phieuchitiet.Amount = row["ThanhToan"].ToString();
                    phieuchitiet.Description = memoGhiChu.Text;


                    
                    BUS_STOCK_OUTWARD_DETAIL inwarddetal = new BUS_STOCK_OUTWARD_DETAIL();
                 
                    int c = inwarddetal.ThemPhieuXuatHang(phieuchitiet);
                }
            }
          
            this.Visible = false;
        }
    }
}
