namespace DoAnCK_TTA.GUI
{
    partial class frmBaoCaoDoanhSoTheoNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhSoTheoNgay));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnXem = new DevExpress.XtraBars.BarStaticItem();
            this.btnXuat = new DevExpress.XtraBars.BarStaticItem();
            this.btnIn = new DevExpress.XtraBars.BarStaticItem();
            this.btnDong = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridBaoCaoMuaHangTheoNgay = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCaoMuaHangTheoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXem,
            this.btnIn,
            this.btnDong,
            this.btnXuat});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar1.Text = "Tools";
            // 
            // btnXem
            // 
            this.btnXem.Caption = "Xem";
            this.btnXem.Id = 1;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.LargeImage")));
            this.btnXem.Name = "btnXem";
            this.btnXem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất";
            this.btnXuat.Id = 4;
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.LargeImage")));
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 2;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.LargeImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 3;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1112, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 517);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1112, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1112, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
            // 
            // gridBaoCaoMuaHangTheoNgay
            // 
            this.gridBaoCaoMuaHangTheoNgay.Location = new System.Drawing.Point(0, 36);
            this.gridBaoCaoMuaHangTheoNgay.MainView = this.gridView5;
            this.gridBaoCaoMuaHangTheoNgay.MenuManager = this.barManager1;
            this.gridBaoCaoMuaHangTheoNgay.Name = "gridBaoCaoMuaHangTheoNgay";
            this.gridBaoCaoMuaHangTheoNgay.Size = new System.Drawing.Size(1101, 454);
            this.gridBaoCaoMuaHangTheoNgay.TabIndex = 42;
            this.gridBaoCaoMuaHangTheoNgay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gridBaoCaoMuaHangTheoNgay.Click += new System.EventHandler(this.gridBaoCaoMuaHangTheoNgay_Click);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.lookMa,
            this.lookTenHang,
            this.gridColumn5});
            this.gridView5.GridControl = this.gridBaoCaoMuaHangTheoNgay;
            this.gridView5.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowFooter = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // lookMa
            // 
            this.lookMa.Caption = "Ngày";
            this.lookMa.FieldName = "RefDate";
            this.lookMa.Name = "lookMa";
            this.lookMa.OptionsFilter.AllowFilter = false;
            this.lookMa.Visible = true;
            this.lookMa.VisibleIndex = 0;
            // 
            // lookTenHang
            // 
            this.lookTenHang.Caption = "Doanh Số Bán Hàng";
            this.lookTenHang.FieldName = "TienBan";
            this.lookTenHang.Name = "lookTenHang";
            this.lookTenHang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienMua", "{0:0.##}")});
            this.lookTenHang.Visible = true;
            this.lookTenHang.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Chi Phí Mua Hàng";
            this.gridColumn5.FieldName = "TienMua";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienBan", "{0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // frmBaoCaoDoanhSoTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBaoCaoMuaHangTheoNgay);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmBaoCaoDoanhSoTheoNgay";
            this.Size = new System.Drawing.Size(1112, 517);
            this.Tag = "bbiReportSale";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhSoTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCaoMuaHangTheoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem btnXem;
        private DevExpress.XtraBars.BarStaticItem btnXuat;
        private DevExpress.XtraBars.BarStaticItem btnIn;
        private DevExpress.XtraBars.BarStaticItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridBaoCaoMuaHangTheoNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn lookMa;
        private DevExpress.XtraGrid.Columns.GridColumn lookTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
