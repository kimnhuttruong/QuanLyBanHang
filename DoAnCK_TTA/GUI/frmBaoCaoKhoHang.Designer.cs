namespace DoAnCK_TTA.GUI
{
    partial class frmBaoCaoKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoKhoHang));
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTonKhoTongHop = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNhapXuatTon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLichSuHangHoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.dockPanel.Text = "Danh Sách Báo Cáo";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionControl);
            this.dockPanel_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(237, 564);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup,
            this.accordionControlElement1});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(237, 564);
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
            this.btnTonKhoTongHop,
            this.btnNhapXuatTon,
            this.btnLichSuHangHoa});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Tồn Kho";
            // 
            // btnTonKhoTongHop
            // 
            this.btnTonKhoTongHop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTonKhoTongHop.ImageOptions.Image")));
            this.btnTonKhoTongHop.Name = "btnTonKhoTongHop";
            this.btnTonKhoTongHop.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTonKhoTongHop.Text = "Tồn Kho Tổng Hợp";
            this.btnTonKhoTongHop.Click += new System.EventHandler(this.btnTonKhoTongHop_Click);
            // 
            // btnNhapXuatTon
            // 
            this.btnNhapXuatTon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapXuatTon.ImageOptions.Image")));
            this.btnNhapXuatTon.Name = "btnNhapXuatTon";
            this.btnNhapXuatTon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNhapXuatTon.Text = "Nhập-Xuất-Tồn";
            this.btnNhapXuatTon.Click += new System.EventHandler(this.btnNhapXuatTon_Click);
            // 
            // btnLichSuHangHoa
            // 
            this.btnLichSuHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLichSuHangHoa.ImageOptions.Image")));
            this.btnLichSuHangHoa.Name = "btnLichSuHangHoa";
            this.btnLichSuHangHoa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLichSuHangHoa.Text = "Lịch Sử Hàng Hóa";
            this.btnLichSuHangHoa.Click += new System.EventHandler(this.btnLichSuHangHoa_Click);
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
            // frmBaoCaoKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 596);
            this.Controls.Add(this.dockPanel);
            this.Name = "frmBaoCaoKhoHang";
            this.Tag = "bbiReport";
            this.Load += new System.EventHandler(this.frmBaoCaoKhoHang_Load);
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTonKhoTongHop;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhapXuatTon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLichSuHangHoa;
    }
}