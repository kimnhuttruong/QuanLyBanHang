﻿namespace DoAnCK_TTA.GUI
{
    partial class frmBaoCaoLoiNhuanTheoChungTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoLoiNhuanTheoChungTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridBaoCaoLoiNhuan = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.calcDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCaoLoiNhuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
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
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4,
            this.barStaticItem5});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4)});
            this.bar1.Text = "Tools";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Xem";
            this.barStaticItem2.Id = 1;
            this.barStaticItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.ImageOptions.Image")));
            this.barStaticItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.ImageOptions.LargeImage")));
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Caption = "Xuất";
            this.barStaticItem5.Id = 4;
            this.barStaticItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem5.ImageOptions.Image")));
            this.barStaticItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem5.ImageOptions.LargeImage")));
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "In";
            this.barStaticItem3.Id = 2;
            this.barStaticItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem3.ImageOptions.Image")));
            this.barStaticItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem3.ImageOptions.LargeImage")));
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Đóng";
            this.barStaticItem4.Id = 3;
            this.barStaticItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem4.ImageOptions.Image")));
            this.barStaticItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem4.ImageOptions.LargeImage")));
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // gridBaoCaoLoiNhuan
            // 
            this.gridBaoCaoLoiNhuan.Location = new System.Drawing.Point(6, 60);
            this.gridBaoCaoLoiNhuan.MainView = this.gridView5;
            this.gridBaoCaoLoiNhuan.MenuManager = this.barManager1;
            this.gridBaoCaoLoiNhuan.Name = "gridBaoCaoLoiNhuan";
            this.gridBaoCaoLoiNhuan.Size = new System.Drawing.Size(1101, 454);
            this.gridBaoCaoLoiNhuan.TabIndex = 45;
            this.gridBaoCaoLoiNhuan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.lookMa,
            this.lookTenHang,
            this.gridColumn5,
            this.calc,
            this.calcDonGia,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.gridView5.GridControl = this.gridBaoCaoLoiNhuan;
            this.gridView5.GroupCount = 1;
            this.gridView5.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.lookMa, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // lookMa
            // 
            this.lookMa.Caption = "Khách Hàng";
            this.lookMa.FieldName = "CustomerName";
            this.lookMa.Name = "lookMa";
            this.lookMa.OptionsFilter.AllowFilter = false;
            this.lookMa.Visible = true;
            this.lookMa.VisibleIndex = 0;
            // 
            // lookTenHang
            // 
            this.lookTenHang.Caption = "Chứng Từ";
            this.lookTenHang.FieldName = "Outward_ID";
            this.lookTenHang.Name = "lookTenHang";
            this.lookTenHang.Visible = true;
            this.lookTenHang.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày";
            this.gridColumn5.FieldName = "RefDate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // calc
            // 
            this.calc.Caption = "Mã Hàng";
            this.calc.FieldName = "Product_ID";
            this.calc.Name = "calc";
            this.calc.Visible = true;
            this.calc.VisibleIndex = 2;
            // 
            // calcDonGia
            // 
            this.calcDonGia.Caption = "Đơn Vị";
            this.calcDonGia.FieldName = "Unit";
            this.calcDonGia.Name = "calcDonGia";
            this.calcDonGia.Visible = true;
            this.calcDonGia.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Số Lượng";
            this.gridColumn8.FieldName = "Quantity";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Giá Nhập";
            this.gridColumn9.FieldName = "AverageCost";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "T.Tiền Nhập";
            this.gridColumn1.FieldName = "TTienNhap";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Giá Xuất";
            this.gridColumn2.FieldName = "UnitPrice";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "T.Tiền Xuất";
            this.gridColumn3.FieldName = "TTienXuat";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chênh Lệch";
            this.gridColumn4.FieldName = "ChenhLech";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Chiếc Khấu";
            this.gridColumn6.FieldName = "FAmount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 11;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Thuế VAT";
            this.gridColumn7.FieldName = "VatAmount";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 12;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Doanh Số";
            this.gridColumn10.FieldName = "ChenhLech";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 13;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Lợi Nhuận";
            this.gridColumn11.FieldName = "gridColumn11";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn11", "{0:0.##}")});
            this.gridColumn11.UnboundExpression = "[ChenhLech] - [VatAmount] - [FAmount]";
            this.gridColumn11.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 14;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ghi Chú";
            this.gridColumn12.FieldName = "Description";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 15;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Tên Hàng";
            this.gridColumn13.FieldName = "Product_Name";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(6, 34);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(207, 20);
            this.gridLookUpEdit1.TabIndex = 44;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmBaoCaoLoiNhuanTheoChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBaoCaoLoiNhuan);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmBaoCaoLoiNhuanTheoChungTu";
            this.Size = new System.Drawing.Size(1112, 517);
            this.Load += new System.EventHandler(this.frmBaoCaoLoiNhuanTheoChungTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCaoLoiNhuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem5;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridBaoCaoLoiNhuan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn lookMa;
        private DevExpress.XtraGrid.Columns.GridColumn lookTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn calc;
        private DevExpress.XtraGrid.Columns.GridColumn calcDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
    }
}
