namespace DoAnCK_TTA.GUI
{
    partial class frmMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuaHang));
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPhieuNhapHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTheoChungTu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTheoHangHoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnThemHangHoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnThemKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnThemKhoHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
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
            this.dockPanel.TabsPosition = DevExpress.XtraBars.Docking.TabsPosition.Right;
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
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(237, 498);
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
            this.accordionControlElement1.Appearance.Normal.Options.UseTextOptions = true;
            this.accordionControlElement1.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnPhieuNhapHang});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Nhập Hàng";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // btnPhieuNhapHang
            // 
            this.btnPhieuNhapHang.Expanded = true;
            this.btnPhieuNhapHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuNhapHang.ImageOptions.Image")));
            this.btnPhieuNhapHang.Name = "btnPhieuNhapHang";
            this.btnPhieuNhapHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPhieuNhapHang.Text = "Phiếu Nhập Hàng";
            this.btnPhieuNhapHang.Click += new System.EventHandler(this.btnPhieuNhapHang_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnTheoChungTu,
            this.btnTheoHangHoa});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Bảng Kê";
            // 
            // btnTheoChungTu
            // 
            this.btnTheoChungTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTheoChungTu.ImageOptions.Image")));
            this.btnTheoChungTu.Name = "btnTheoChungTu";
            this.btnTheoChungTu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTheoChungTu.Text = "Theo Chứng Từ";
            this.btnTheoChungTu.Click += new System.EventHandler(this.btnTheoChungTu_Click);
            // 
            // btnTheoHangHoa
            // 
            this.btnTheoHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTheoHangHoa.ImageOptions.Image")));
            this.btnTheoHangHoa.Name = "btnTheoHangHoa";
            this.btnTheoHangHoa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTheoHangHoa.Text = "Theo Hàng Hóa";
            this.btnTheoHangHoa.Click += new System.EventHandler(this.btnTheoHangHoa_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnThemHangHoa,
            this.btnThemKhachHang,
            this.btnThemKhoHang});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Thêm Danh Mục";
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHangHoa.ImageOptions.Image")));
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnThemHangHoa.Text = "Hàng Hóa";
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhachHang.ImageOptions.Image")));
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnThemKhachHang.Text = "Khách Hàng";
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // btnThemKhoHang
            // 
            this.btnThemKhoHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhoHang.ImageOptions.Image")));
            this.btnThemKhoHang.Name = "btnThemKhoHang";
            this.btnThemKhoHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnThemKhoHang.Text = "Kho Hàng";
            this.btnThemKhoHang.Click += new System.EventHandler(this.btnThemKhoHang_Click);
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
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // frmMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 520);
            this.Controls.Add(this.dockPanel);
            this.Name = "frmMuaHang";
            this.Load += new System.EventHandler(this.frmMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPhieuNhapHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTheoChungTu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTheoHangHoa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnThemHangHoa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnThemKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnThemKhoHang;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
    }
}