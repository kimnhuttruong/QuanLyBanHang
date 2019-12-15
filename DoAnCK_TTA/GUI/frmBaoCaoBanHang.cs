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
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmBaoCaoBanHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmBaoCaoBanHang()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
          //  accordionControl.SelectedElement = employeesAccordionControlElement;
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
        //
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
      //      int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
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
       //         if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
       //         else accordionControl.SelectedElement = employeesAccordionControlElement;
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

        private void btnChiPhiMuaHangTheoNgay_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBaoCaoChiPhiMuaHangTheoNgay f = new frmBaoCaoChiPhiMuaHangTheoNgay();
            f.Text = "Báo Cáo Chi Phí Mua Hàng Theo Ngày";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);

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

        private void btnChiPhiMuaHangTheoNCC_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap f = new frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap();
            f.Text = "Báo Cáo Chi Phí Mua Hàng Theo Nhà Cung Cấp";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);

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

        private void btnDoanhSoBanHangTheoNgay_Click(object sender, EventArgs e)
        {

            tabbedView.Controller.CloseAll();

            frmBaoCaoDoanhSoTheoNgay f = new frmBaoCaoDoanhSoTheoNgay();
            f.Text = "Báo Cáo Doanh Số Theo Ngày";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);

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

        private void btnDoanhSoBanHangTheoKH_Click(object sender, EventArgs e)
        {

            tabbedView.Controller.CloseAll();

            frmBaoCaoDoanhSoTheoKhachHang f = new frmBaoCaoDoanhSoTheoKhachHang();
            f.Text = "Báo Cáo Doanh Số Theo Khách Hàng";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);

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

        private void btnDoanhSoBanHangTheoNV_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBaoCaoDoanhSoTheoNhanVien f = new frmBaoCaoDoanhSoTheoNhanVien();
            f.Text = "Báo Cáo Doanh Số Theo Nhân Viên";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);

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

        private void btnLoiNhuanTheoChungTu_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBaoCaoLoiNhuanTheoChungTu f = new frmBaoCaoLoiNhuanTheoChungTu();
            f.Text = "Báo Cáo Lợi Nhuận Theo Chứng Từ";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);

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

        private void btnLoiNhuanTheoHangHoa_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBaoCaoLoiNhuanTheoHangHoa f = new frmBaoCaoLoiNhuanTheoHangHoa();
            f.Text = "Báo Cáo Lợi Nhuận Theo Chứng Từ";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);

            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Truy cập";
            busLog.ThemLichSu(log);

        }

        private void btnDoanhSoBanHangTheoHH_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmBaoCaoDoanhSoTheoHangHoa f = new frmBaoCaoDoanhSoTheoHangHoa();
            f.Text = "Báo Cáo Doanh Số Bán Hàng Theo Hàng Hóa";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
            
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "truy cập";
            busLog.ThemLichSu(log);

        }

        private void frmBaoCaoBanHang_Load(object sender, EventArgs e)
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
    }
}