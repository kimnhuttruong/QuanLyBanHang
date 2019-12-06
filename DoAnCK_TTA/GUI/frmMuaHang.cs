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
using DevExpress.XtraBars.Docking2010.Views.Tabbed;

namespace DoAnCK_TTA.GUI
{
    public partial class frmMuaHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmMuaHang()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");


           
            //    accordionControl.SelectedElement = employeesAccordionControlElement;
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
            //if (e.Element == null) return;
            //XtraUserControl userControl = e.Element.Text == "Employees" ? employeesUserControl : customersUserControl;
          

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
          //      if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
           //     else accordionControl.SelectedElement = employeesAccordionControlElement;
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

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void frmMuaHang_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            //Form form = IsActive(typeof(frmPhieuNhapHang));//kiểm tra có show hay không

            //if (form == null)
            //{
            //    frmPhieuNhapHang f = new frmPhieuNhapHang();
            //    f.MdiParent = this;
            //    f.Text = "Phiếu Nhập Hàng";
            //    f.Show();
            //}
            //else
            //{
            //    form.Activate();
            //}
        }
        private new Document IsActive(string type)
        {
            foreach (Document f in tabbedView.Documents)
            {
                if (f.Caption == type)
                {
                    MessageBox.Show(f.Caption);
                    return f;
                }
                
            }
            return null;
        }

        private void btnPhieuNhapHang_Click(object sender, EventArgs e)
        {

            tabbedView.Controller.CloseAll();
            frmPhieuNhapHang f = new frmPhieuNhapHang();
       
            f.Text = "Phiếu Nhập Hàng";
            f.Tag = "frmPhieuNhapHang";
            tabbedView.AddDocument(f);
           
        }

        private void btnTheoChungTu_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBangKeTongHop f = new frmBangKeTongHop();
            f.Text = "Bảng Kê Tổng Hợp";
            f.Tag = "frmBangKeTongHop";
            tabbedView.AddDocument(f);
            

        }

        private void btnTheoHangHoa_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();
            frmBangKeChiTiet f = new frmBangKeChiTiet();
            f.Text = "Bảng Kê Chi Tiết";
            tabbedView.AddDocument(f);
           
      
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
    }
}