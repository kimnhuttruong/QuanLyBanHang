using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.BUS;

namespace DoAnCK_TTA.GUI
{
    public partial class frmChuyenKho : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmChuyenKho()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
       //     accordionControl.SelectedElement = employeesAccordionControlElement;
        }
        XtraUserControl CreateUserControl(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            LabelControl label = new LabelControl();
            label.Parent = result;
            label.Appearance.Font = new Font("Tahoma", 25.25F);
            label.Appearance.ForeColor = Color.Gray;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Text = text;
            return result;
        }
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            XtraUserControl userControl = e.Element.Text == "Employees" ? employeesUserControl : customersUserControl;
          //  tabbedView.AddDocument(userControl);
           // tabbedView.ActivateDocument(userControl);
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
         //   int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
           // accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }
        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            if (tabbedView.Documents.Count != 0)
            {
         //       if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
         //       else accordionControl.SelectedElement = employeesAccordionControlElement;
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e)
        {
            if (e.Document.Caption == "Employees") employeesUserControl = CreateUserControl("Employees");
            else customersUserControl = CreateUserControl("Customers");
        }

        private void btnPhieuChuyenKho_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmPhieuChuyenKho f = new frmPhieuChuyenKho();
            f.Text = "Phiếu CHuyển Kho";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnTheoChungTu_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBangKeChiTiet_ChuyenKho f = new frmBangKeChiTiet_ChuyenKho();
            f.Text = "Bảng Kê Tổng Hợp";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnTheoHangHoa_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBangKeChiTiet_ChuyenKho f = new frmBangKeChiTiet_ChuyenKho();
            f.Text = "Bảng Kê Chi Tiết";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            var mainWindow = new frmThongTinHangHoa();
            DTO_PRODUCT dTO_CUSTOMER = new DTO_PRODUCT();
            BUS_PRODUCT bUS_ = new BUS_PRODUCT();

            DataTable _dt = new DataTable();
            _dt = bUS_.LayDanhSachHangHoa();

            dTO_CUSTOMER.Product_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_CUSTOMER.Product_ID = dTO_CUSTOMER.Product_ID.Remove(0, 2);

            dTO_CUSTOMER.Product_ID = (int.Parse(dTO_CUSTOMER.Product_ID) + 1).ToString("000000");
            dTO_CUSTOMER.Product_ID = "HH" + dTO_CUSTOMER.Product_ID.ToString();

            mainWindow.Sender(dTO_CUSTOMER);    //Gọi delegate
            mainWindow.ShowDialog();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            var mainWindow = new frmThongTinKhoHang();
            DTO_STOCK dTO_CUSTOMER = new DTO_STOCK();
            BUS_STOCK bUS_ = new BUS_STOCK();

            DataTable _dt = new DataTable();
            _dt = bUS_.LayThongTinKhoHang();

            dTO_CUSTOMER.Stock_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_CUSTOMER.Stock_ID = dTO_CUSTOMER.Stock_ID.Remove(0, 1);

            dTO_CUSTOMER.Stock_ID = (int.Parse(dTO_CUSTOMER.Stock_ID) + 1).ToString("000000");
            dTO_CUSTOMER.Stock_ID = "K" + dTO_CUSTOMER.Stock_ID.ToString();

            mainWindow.Sender(dTO_CUSTOMER);    //Gọi delegate
            mainWindow.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            var mainWindow = new frmThongTinNhanVien();
            DTO_EMPLOYEE dTO_CUSTOMER = new DTO_EMPLOYEE();
            BUS_EMPLOYEE bUS_ = new BUS_EMPLOYEE();

            DataTable _dt = new DataTable();
            _dt = bUS_.LayDanhSachNhanVien();

            dTO_CUSTOMER.Employee_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_CUSTOMER.Employee_ID = dTO_CUSTOMER.Employee_ID.Remove(0, 2);

            dTO_CUSTOMER.Employee_ID = (int.Parse(dTO_CUSTOMER.Employee_ID) + 1).ToString("000000");
            dTO_CUSTOMER.Employee_ID = "NV" + dTO_CUSTOMER.Employee_ID.ToString();

            mainWindow.Sender(dTO_CUSTOMER);    //Gọi delegate
            mainWindow.ShowDialog();
        }

        private void frmChuyenKho_Load(object sender, EventArgs e)
        {
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

        private void frmChuyenKho_Shown(object sender, EventArgs e)
        {
            this.btnPhieuChuyenKho_Click(null, null);
        }
    }
}