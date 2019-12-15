namespace DoAnCK_TTA.GUI
{
    partial class frmThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuTien));
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDanhSachPhieuThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDanhSachPhieuCongNo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DanhSachPhieuTraNgay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTheoDoiCongNo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTongHopCongNo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.dockPanel.Size = new System.Drawing.Size(244, 520);
            this.dockPanel.Text = "Chức Năng";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionControl);
            this.dockPanel_Container.Location = new System.Drawing.Point(3, 19);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(237, 498);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup,
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(237, 498);
            this.accordionControl.TabIndex = 0;
            this.accordionControl.Text = "accordionControl";
            this.accordionControl.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.accordionControl_SelectedElementChanged);
            this.accordionControl.Click += new System.EventHandler(this.accordionControl_Click);
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
            this.btnDanhSachPhieuThu});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Phiếu Thu";
            // 
            // btnDanhSachPhieuThu
            // 
            this.btnDanhSachPhieuThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachPhieuThu.ImageOptions.Image")));
            this.btnDanhSachPhieuThu.Name = "btnDanhSachPhieuThu";
            this.btnDanhSachPhieuThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDanhSachPhieuThu.Text = "Danh Sách Phiếu Thu";
            this.btnDanhSachPhieuThu.Click += new System.EventHandler(this.btnDanhSachPhieuThu_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnDanhSachPhieuCongNo,
            this.DanhSachPhieuTraNgay,
            this.btnTheoDoiCongNo,
            this.btnTongHopCongNo});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Bảng Kê";
            // 
            // btnDanhSachPhieuCongNo
            // 
            this.btnDanhSachPhieuCongNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachPhieuCongNo.ImageOptions.Image")));
            this.btnDanhSachPhieuCongNo.Name = "btnDanhSachPhieuCongNo";
            this.btnDanhSachPhieuCongNo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDanhSachPhieuCongNo.Text = "Danh Sách Phiếu Công Nợ";
            this.btnDanhSachPhieuCongNo.Click += new System.EventHandler(this.btnDanhSachPhieuCongNo_Click);
            // 
            // DanhSachPhieuTraNgay
            // 
            this.DanhSachPhieuTraNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DanhSachPhieuTraNgay.ImageOptions.Image")));
            this.DanhSachPhieuTraNgay.Name = "DanhSachPhieuTraNgay";
            this.DanhSachPhieuTraNgay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.DanhSachPhieuTraNgay.Text = "Danh Sách Phiếu Trả Ngay";
            this.DanhSachPhieuTraNgay.Click += new System.EventHandler(this.DanhSachPhieuTraNgay_Click);
            // 
            // btnTheoDoiCongNo
            // 
            this.btnTheoDoiCongNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTheoDoiCongNo.ImageOptions.Image")));
            this.btnTheoDoiCongNo.Name = "btnTheoDoiCongNo";
            this.btnTheoDoiCongNo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTheoDoiCongNo.Text = "Theo Dõi Công Nợ";
            this.btnTheoDoiCongNo.Click += new System.EventHandler(this.btnTheoDoiCongNo_Click);
            // 
            // btnTongHopCongNo
            // 
            this.btnTongHopCongNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTongHopCongNo.ImageOptions.Image")));
            this.btnTongHopCongNo.Name = "btnTongHopCongNo";
            this.btnTongHopCongNo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTongHopCongNo.Text = "Tổng Hợp Công Nợ";
            this.btnTongHopCongNo.Click += new System.EventHandler(this.btnTongHopCongNo_Click);
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
            // frmThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 520);
            this.Controls.Add(this.dockPanel);
            this.Name = "frmThuTien";
            this.Tag = "bbiReciept";
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDanhSachPhieuThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDanhSachPhieuCongNo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement DanhSachPhieuTraNgay;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTheoDoiCongNo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTongHopCongNo;
    }
}