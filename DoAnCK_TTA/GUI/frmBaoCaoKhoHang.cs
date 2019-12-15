﻿using System;
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
    public partial class frmBaoCaoKhoHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmBaoCaoKhoHang()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
           // accordionControl.SelectedElement = employeesAccordionControlElement;
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
       //     int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
       //     accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
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

        private void frmBaoCaoKhoHang_Load(object sender, EventArgs e)
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

        private void btnTonKhoTongHop_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

          frmTonKhoTongHop f = new frmTonKhoTongHop();
            f.Text = "Tồn Kho Tổng Hợp";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnNhapXuatTon_Click(object sender, EventArgs e)
        {
            tabbedView.Controller.CloseAll();

            frmNhapXuatTon f = new frmNhapXuatTon();
            f.Text = "Tồn Kho Tổng Hợp";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }

        private void btnLichSuHangHoa_Click(object sender, EventArgs e)
        {

            tabbedView.Controller.CloseAll();

            frmLichSuHangHoa f = new frmLichSuHangHoa();
            f.Text = "Lịch Sử Hàng Hóa";
            tabbedView.AddDocument(f);
            tabbedView.ActivateDocument(f);
        }
    }
}