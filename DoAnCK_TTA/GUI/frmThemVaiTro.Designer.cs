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
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.treeVaiTro = new DevExpress.XtraTreeList.TreeList();
            this.col_chucnang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_tatca = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_truycap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_them = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_xoa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_sua = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_print = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_nhap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_xuat = new DevExpress.XtraTreeList.Columns.TreeListColumn();
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
            this.txtDienGiai.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(67, 54);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(235, 20);
            this.txtTen.TabIndex = 0;
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
            this.groupControl2.Controls.Add(this.btnDong);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.treeVaiTro);
            this.groupControl2.Location = new System.Drawing.Point(3, 94);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(639, 467);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Quyền Hạn";
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
            // treeVaiTro
            // 
            this.treeVaiTro.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.col_chucnang,
            this.col_tatca,
            this.col_truycap,
            this.col_them,
            this.col_xoa,
            this.col_sua,
            this.col_print,
            this.col_nhap,
            this.col_xuat});
            this.treeVaiTro.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeVaiTro.KeyFieldName = "_ma";
            this.treeVaiTro.Location = new System.Drawing.Point(0, 20);
            this.treeVaiTro.Name = "treeVaiTro";
            this.treeVaiTro.ParentFieldName = "_cha";
            this.treeVaiTro.Size = new System.Drawing.Size(639, 407);
            this.treeVaiTro.TabIndex = 0;
            // 
            // col_chucnang
            // 
            this.col_chucnang.Caption = "Chức Năng";
            this.col_chucnang.FieldName = "Object_Name";
            this.col_chucnang.Name = "col_chucnang";
            this.col_chucnang.Visible = true;
            this.col_chucnang.VisibleIndex = 0;
            this.col_chucnang.Width = 208;
            // 
            // col_tatca
            // 
            this.col_tatca.AppearanceHeader.Options.UseTextOptions = true;
            this.col_tatca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_tatca.Caption = "Tất Cả";
            this.col_tatca.FieldName = "AllowAll";
            this.col_tatca.Name = "col_tatca";
            this.col_tatca.Visible = true;
            this.col_tatca.VisibleIndex = 1;
            this.col_tatca.Width = 51;
            // 
            // col_truycap
            // 
            this.col_truycap.AppearanceHeader.Options.UseTextOptions = true;
            this.col_truycap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_truycap.Caption = "Truy Cập";
            this.col_truycap.FieldName = "AllowAccess";
            this.col_truycap.Name = "col_truycap";
            this.col_truycap.Visible = true;
            this.col_truycap.VisibleIndex = 2;
            this.col_truycap.Width = 51;
            // 
            // col_them
            // 
            this.col_them.AppearanceHeader.Options.UseTextOptions = true;
            this.col_them.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_them.Caption = "Thêm";
            this.col_them.FieldName = "AllowAdd";
            this.col_them.Name = "col_them";
            this.col_them.Visible = true;
            this.col_them.VisibleIndex = 3;
            this.col_them.Width = 51;
            // 
            // col_xoa
            // 
            this.col_xoa.AppearanceHeader.Options.UseTextOptions = true;
            this.col_xoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_xoa.Caption = "Xóa ";
            this.col_xoa.FieldName = "AllowDelete";
            this.col_xoa.Name = "col_xoa";
            this.col_xoa.Visible = true;
            this.col_xoa.VisibleIndex = 4;
            this.col_xoa.Width = 52;
            // 
            // col_sua
            // 
            this.col_sua.AppearanceHeader.Options.UseTextOptions = true;
            this.col_sua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_sua.Caption = "Sửa";
            this.col_sua.FieldName = "AllowEdit";
            this.col_sua.Name = "col_sua";
            this.col_sua.Visible = true;
            this.col_sua.VisibleIndex = 5;
            this.col_sua.Width = 52;
            // 
            // col_print
            // 
            this.col_print.AppearanceHeader.Options.UseTextOptions = true;
            this.col_print.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_print.Caption = "In";
            this.col_print.FieldName = "AllowPrint";
            this.col_print.Name = "col_print";
            this.col_print.Visible = true;
            this.col_print.VisibleIndex = 6;
            this.col_print.Width = 52;
            // 
            // col_nhap
            // 
            this.col_nhap.AppearanceHeader.Options.UseTextOptions = true;
            this.col_nhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_nhap.Caption = "Nhập";
            this.col_nhap.FieldName = "AllowImport";
            this.col_nhap.Name = "col_nhap";
            this.col_nhap.Visible = true;
            this.col_nhap.VisibleIndex = 7;
            this.col_nhap.Width = 52;
            // 
            // col_xuat
            // 
            this.col_xuat.AppearanceHeader.Options.UseTextOptions = true;
            this.col_xuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_xuat.Caption = "Xuất";
            this.col_xuat.FieldName = "AllowExport";
            this.col_xuat.Name = "col_xuat";
            this.col_xuat.Visible = true;
            this.col_xuat.VisibleIndex = 8;
            this.col_xuat.Width = 52;
            // 
            // frmThemVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 565);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
   //         this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmThemVaiTro.IconOptions.LargeImage")));
            this.Name = "frmThemVaiTro";
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
        private DevExpress.XtraTreeList.TreeList treeVaiTro;
      
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_chucnang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_tatca;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_truycap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_them;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_xoa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_sua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_print;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_nhap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_xuat;
       
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CheckEdit check;
        private System.Windows.Forms.Label label4;
    }
}