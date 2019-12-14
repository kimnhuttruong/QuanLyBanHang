﻿namespace DoAnCK_TTA.GUI
{
    partial class frmBaoCaoBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoBanHang));
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnChiPhiMuaHangTheoNgay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnChiPhiMuaHangTheoNCC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDoanhSoBanHangTheoNgay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDoanhSoBanHangTheoKH = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDoanhSoBanHangTheoNV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDoanhSoBanHangTheoHH = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLoiNhuanTheoChungTu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLoiNhuanTheoHangHoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.dockPanel_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel.ID = new System.Guid("a045df26-1503-4d9a-99c1-a531310af22b");
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.OriginalSize = new System.Drawing.Size(244, 200);
            this.dockPanel.Size = new System.Drawing.Size(244, 596);
            this.dockPanel.Text = "Chức Năng";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionControl);
            this.dockPanel_Container.Location = new System.Drawing.Point(3, 19);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(237, 574);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(237, 574);
            this.accordionControl.TabIndex = 0;
            this.accordionControl.Text = "accordionControl";
            this.accordionControl.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.accordionControl_SelectedElementChanged);
            // 
            // mainAccordionGroup
            // 
            this.mainAccordionGroup.Expanded = true;
            this.mainAccordionGroup.HeaderVisible = false;
            this.mainAccordionGroup.Name = "mainAccordionGroup";
            this.mainAccordionGroup.Text = "mainGroup";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnChiPhiMuaHangTheoNgay,
            this.btnChiPhiMuaHangTheoNCC});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Chi Phí Mua Hàng";
            // 
            // btnChiPhiMuaHangTheoNgay
            // 
            this.btnChiPhiMuaHangTheoNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiPhiMuaHangTheoNgay.ImageOptions.Image")));
            this.btnChiPhiMuaHangTheoNgay.Name = "btnChiPhiMuaHangTheoNgay";
            this.btnChiPhiMuaHangTheoNgay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnChiPhiMuaHangTheoNgay.Text = "Theo Ngày";
            this.btnChiPhiMuaHangTheoNgay.Click += new System.EventHandler(this.btnChiPhiMuaHangTheoNgay_Click);
            // 
            // btnChiPhiMuaHangTheoNCC
            // 
            this.btnChiPhiMuaHangTheoNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiPhiMuaHangTheoNCC.ImageOptions.Image")));
            this.btnChiPhiMuaHangTheoNCC.Name = "btnChiPhiMuaHangTheoNCC";
            this.btnChiPhiMuaHangTheoNCC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnChiPhiMuaHangTheoNCC.Text = "Theo Nhà Cung Cấp";
            this.btnChiPhiMuaHangTheoNCC.Click += new System.EventHandler(this.btnChiPhiMuaHangTheoNCC_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnDoanhSoBanHangTheoNgay,
            this.btnDoanhSoBanHangTheoKH,
            this.btnDoanhSoBanHangTheoNV,
            this.btnDoanhSoBanHangTheoHH});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Doanh Số Bán Hàng";
            // 
            // btnDoanhSoBanHangTheoNgay
            // 
            this.btnDoanhSoBanHangTheoNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhSoBanHangTheoNgay.ImageOptions.Image")));
            this.btnDoanhSoBanHangTheoNgay.Name = "btnDoanhSoBanHangTheoNgay";
            this.btnDoanhSoBanHangTheoNgay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDoanhSoBanHangTheoNgay.Text = "Theo Ngày";
            this.btnDoanhSoBanHangTheoNgay.Click += new System.EventHandler(this.btnDoanhSoBanHangTheoNgay_Click);
            // 
            // btnDoanhSoBanHangTheoKH
            // 
            this.btnDoanhSoBanHangTheoKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhSoBanHangTheoKH.ImageOptions.Image")));
            this.btnDoanhSoBanHangTheoKH.Name = "btnDoanhSoBanHangTheoKH";
            this.btnDoanhSoBanHangTheoKH.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDoanhSoBanHangTheoKH.Text = "Theo Khách Hàng";
            this.btnDoanhSoBanHangTheoKH.Click += new System.EventHandler(this.btnDoanhSoBanHangTheoKH_Click);
            // 
            // btnDoanhSoBanHangTheoNV
            // 
            this.btnDoanhSoBanHangTheoNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhSoBanHangTheoNV.ImageOptions.Image")));
            this.btnDoanhSoBanHangTheoNV.Name = "btnDoanhSoBanHangTheoNV";
            this.btnDoanhSoBanHangTheoNV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDoanhSoBanHangTheoNV.Text = "Theo Nhân Viên";
            this.btnDoanhSoBanHangTheoNV.Click += new System.EventHandler(this.btnDoanhSoBanHangTheoNV_Click);
            // 
            // btnDoanhSoBanHangTheoHH
            // 
            this.btnDoanhSoBanHangTheoHH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhSoBanHangTheoHH.ImageOptions.Image")));
            this.btnDoanhSoBanHangTheoHH.Name = "btnDoanhSoBanHangTheoHH";
            this.btnDoanhSoBanHangTheoHH.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDoanhSoBanHangTheoHH.Text = "Theo Hàng Hóa";
            this.btnDoanhSoBanHangTheoHH.Click += new System.EventHandler(this.btnDoanhSoBanHangTheoHH_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnLoiNhuanTheoChungTu,
            this.btnLoiNhuanTheoHangHoa});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Lợi Nhuận";
            // 
            // btnLoiNhuanTheoChungTu
            // 
            this.btnLoiNhuanTheoChungTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoiNhuanTheoChungTu.ImageOptions.Image")));
            this.btnLoiNhuanTheoChungTu.Name = "btnLoiNhuanTheoChungTu";
            this.btnLoiNhuanTheoChungTu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLoiNhuanTheoChungTu.Text = "Theo Chứng Từ";
            this.btnLoiNhuanTheoChungTu.Click += new System.EventHandler(this.btnLoiNhuanTheoChungTu_Click);
            // 
            // btnLoiNhuanTheoHangHoa
            // 
            this.btnLoiNhuanTheoHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoiNhuanTheoHangHoa.ImageOptions.Image")));
            this.btnLoiNhuanTheoHangHoa.Name = "btnLoiNhuanTheoHangHoa";
            this.btnLoiNhuanTheoHangHoa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLoiNhuanTheoHangHoa.Text = "Theo Hàng Hóa";
            this.btnLoiNhuanTheoHangHoa.Click += new System.EventHandler(this.btnLoiNhuanTheoHangHoa_Click);
            // 
            // tabbedView
            // 
            this.tabbedView.DocumentClosed += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.tabbedView_DocumentClosed);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // frmBaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 596);
            this.Controls.Add(this.dockPanel);
            this.Name = "frmBaoCaoBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainAccordionGroup;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnChiPhiMuaHangTheoNgay;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnChiPhiMuaHangTheoNCC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDoanhSoBanHangTheoNgay;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDoanhSoBanHangTheoKH;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDoanhSoBanHangTheoNV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDoanhSoBanHangTheoHH;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLoiNhuanTheoChungTu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLoiNhuanTheoHangHoa;
    }
}