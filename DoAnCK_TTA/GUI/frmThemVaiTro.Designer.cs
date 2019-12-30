namespace DoAnCK_TTA.GUI
{
    partial class frmThemVaiTro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemVaiTro));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.check = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDienGiai = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treeVaiTro = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn11 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienGiai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeVaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.check);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtDienGiai);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(639, 85);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Vai Trò";
            // 
            // check
            // 
            this.check.EditValue = true;
            this.check.Location = new System.Drawing.Point(379, 53);
            this.check.Name = "check";
            this.check.Properties.Caption = "";
            this.check.Size = new System.Drawing.Size(22, 19);
            this.check.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kích Hoạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Diễn Giải";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(379, 25);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(253, 20);
            this.txtDienGiai.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(67, 54);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(235, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(67, 25);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(235, 20);
            this.txtMa.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.treeVaiTro);
            this.groupControl2.Controls.Add(this.btnDong);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Location = new System.Drawing.Point(3, 94);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(639, 467);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Quyền Hạn";
            // 
            // treeVaiTro
            // 
            this.treeVaiTro.Appearance.FixedLine.BackColor = System.Drawing.Color.Black;
            this.treeVaiTro.Appearance.FixedLine.Options.UseBackColor = true;
            this.treeVaiTro.Appearance.TreeLine.BackColor = System.Drawing.Color.Silver;
            this.treeVaiTro.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeVaiTro.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9,
            this.treeListColumn10,
            this.treeListColumn11});
            this.treeVaiTro.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeVaiTro.KeyFieldName = "_ma";
            this.treeVaiTro.Location = new System.Drawing.Point(0, 25);
            this.treeVaiTro.Name = "treeVaiTro";
            this.treeVaiTro.ParentFieldName = "";
            this.treeVaiTro.Size = new System.Drawing.Size(639, 403);
            this.treeVaiTro.TabIndex = 0;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Chức Năng";
            this.treeListColumn3.FieldName = "Object_Name";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            this.treeListColumn3.Width = 247;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Tất Cả";
            this.treeListColumn4.FieldName = "TatCa";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.UnboundExpression = "[AllowPrint] And [AllowExport] And [AllowEdit] And [AllowAccess] And [AllowDelete" +
    "] And [AllowImport]";
            this.treeListColumn4.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 1;
            this.treeListColumn4.Width = 47;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Truy Cập";
            this.treeListColumn5.FieldName = "AllowAccess";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.UnboundExpression = "[TatCa] And [AllowAccess]";
            this.treeListColumn5.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 2;
            this.treeListColumn5.Width = 61;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Thêm";
            this.treeListColumn6.FieldName = "AllowAdd";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.UnboundExpression = "[TatCa] And [AllowAdd]";
            this.treeListColumn6.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 3;
            this.treeListColumn6.Width = 56;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Sửa";
            this.treeListColumn7.FieldName = "AllowEdit";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.UnboundExpression = "[TatCa] And [AllowEdit]";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 4;
            this.treeListColumn7.Width = 51;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Xóa";
            this.treeListColumn8.FieldName = "AllowDelete";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.UnboundExpression = "[TatCa] And [AllowDelete]";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 5;
            this.treeListColumn8.Width = 48;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "In";
            this.treeListColumn9.FieldName = "AllowPrint";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.UnboundExpression = "[TatCa] And [AllowPrint]";
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 6;
            this.treeListColumn9.Width = 36;
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.Caption = "Nhập";
            this.treeListColumn10.FieldName = "AllowImport";
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.UnboundExpression = "[TatCa] And [AllowImport]";
            this.treeListColumn10.Visible = true;
            this.treeListColumn10.VisibleIndex = 7;
            this.treeListColumn10.Width = 37;
            // 
            // treeListColumn11
            // 
            this.treeListColumn11.Caption = "Xuất";
            this.treeListColumn11.FieldName = "AllowExport";
            this.treeListColumn11.Name = "treeListColumn11";
            this.treeListColumn11.UnboundExpression = "[TatCa] And [AllowExport]";
            this.treeListColumn11.Visible = true;
            this.treeListColumn11.VisibleIndex = 8;
            this.treeListColumn11.Width = 37;
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Location = new System.Drawing.Point(428, 434);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(158, 28);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(264, 434);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(158, 28);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThemVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 565);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThemVaiTro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "bbiUserRule";
            this.Text = "Thông Tin  Vai Trò";
            this.Load += new System.EventHandler(this.frmThemVaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienGiai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeVaiTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDienGiai;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
       
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CheckEdit check;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraTreeList.TreeList treeVaiTro;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn11;
    }
}