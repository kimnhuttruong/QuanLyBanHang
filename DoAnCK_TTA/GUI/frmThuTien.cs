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

namespace DoAnCK_TTA.GUI
{
    public partial class frmThuTien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmThuTien()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
            //accordionControl.SelectedElement = employeesAccordionControlElement;
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
         //   tabbedView.AddDocument(userControl);
        //    tabbedView.ActivateDocument(userControl);
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
           // int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
          //  accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
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
               // if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
              //  else accordionControl.SelectedElement = employeesAccordionControlElement;
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

        private void accordionControl_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachPhieuThu_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmDanhSachPhieuThu f = new frmDanhSachPhieuThu();
            f.Text = "Danh Sách Phiếu Thu";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnDanhSachPhieuCongNo_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmDanhSachCongNoChiTiet f = new frmDanhSachCongNoChiTiet();
            f.Text = "Danh Sách Phiếu Công Nợ Chi Tiết";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void DanhSachPhieuTraNgay_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBangKePhieuThanhToanNgay f = new frmBangKePhieuThanhToanNgay();
            f.Text = "Bãng Kê Phiếu Thanh Toán Ngay";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnTheoDoiCongNo_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmTheoDoiCongNo f = new frmTheoDoiCongNo();
            f.Text = "Theo Dõi Công Nợ";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnTongHopCongNo_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmDanhSachCongNoTongHop f = new frmDanhSachCongNoTongHop();
            f.Text = "Danh Sách Công Nợ Tổng Hợp";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }
    }
}