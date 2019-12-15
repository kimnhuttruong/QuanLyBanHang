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
    public partial class frmBanHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmBanHang()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
          
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
            //tabbedView.AddDocument(userControl);
            //tabbedView.ActivateDocument(userControl);
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            //int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            //accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
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
                //    if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
                //    else accordionControl.SelectedElement = employeesAccordionControlElement;
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        private new Form IsActive(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    return f;
                }

            }
            return null;
        }
        private void btnPhieuBanHang_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmPhieuXuatHang f = new frmPhieuXuatHang();
            f.Text = "Phiếu Xuất Hàng";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }
   
        
        void RecreateUserControls(DocumentEventArgs e)
        {
            if (e.Document.Caption == "Employees") employeesUserControl = CreateUserControl("Employees");
            else customersUserControl = CreateUserControl("Customers");
        }

        private void btnBangKeTongHop_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            BangKeTongHop_BanHang f = new BangKeTongHop_BanHang();
            f.Text = "Bảng Kê Tổng Hợp";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnBangKeChiTiet_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBangKeChiTiet_BanHang f = new frmBangKeChiTiet_BanHang();
            f.Text = "Bảng Kê Chi Tiết";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            Form hang = new frmThongTinHangHoa();
            hang.ShowDialog();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            var mainWindow = new frmThongTinKhachHang();
            DTO_CUSTOMER dTO_CUSTOMER = new DTO_CUSTOMER();
            BUS_CUSTOMER bUS_ = new BUS_CUSTOMER();

            DataTable _dt = new DataTable();
            _dt = bUS_.LayDanhSachKhachHang();

            dTO_CUSTOMER.Customer_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_CUSTOMER.Customer_ID = dTO_CUSTOMER.Customer_ID.Remove(0, 2);

            dTO_CUSTOMER.Customer_ID = (int.Parse(dTO_CUSTOMER.Customer_ID) + 1).ToString("000000");
            dTO_CUSTOMER.Customer_ID = "KH" + dTO_CUSTOMER.Customer_ID.ToString();

            mainWindow.Sender(dTO_CUSTOMER);    //Gọi delegate
            mainWindow.ShowDialog();
        }

        private void btnThemKhoHang_Click(object sender, EventArgs e)
        {
            Form khohang = new frmThongTinKhoHang();
            khohang.ShowDialog();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            
        }
    }
}