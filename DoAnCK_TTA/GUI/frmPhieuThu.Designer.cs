namespace DoAnCK_TTA.GUI
{
    partial class frmPhieuThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChungTu = new DevExpress.XtraEditors.TextEdit();
            this.txtPhieu = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtDateChungTu = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calcPhaiTra = new DevExpress.XtraEditors.CalcEdit();
            this.calcNo = new DevExpress.XtraEditors.CalcEdit();
            this.calcSoTien = new DevExpress.XtraEditors.CalcEdit();
            this.txtLyDo = new DevExpress.XtraEditors.MemoEdit();
            this.lookNhanVien = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChungTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateChungTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateChungTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcPhaiTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(78, 29);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(337, 20);
            this.txtKhachHang.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtChungTu);
            this.groupControl1.Controls.Add(this.txtPhieu);
            this.groupControl1.Controls.Add(this.txtKhachHang);
            this.groupControl1.Controls.Add(this.txtNgay);
            this.groupControl1.Controls.Add(this.txtDateChungTu);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(628, 91);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chứng Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phiếu";
            // 
            // txtChungTu
            // 
            this.txtChungTu.Location = new System.Drawing.Point(78, 55);
            this.txtChungTu.Name = "txtChungTu";
            this.txtChungTu.Size = new System.Drawing.Size(161, 20);
            this.txtChungTu.TabIndex = 1;
            // 
            // txtPhieu
            // 
            this.txtPhieu.Location = new System.Drawing.Point(462, 29);
            this.txtPhieu.Name = "txtPhieu";
            this.txtPhieu.Size = new System.Drawing.Size(161, 20);
            this.txtPhieu.TabIndex = 1;
            // 
            // txtNgay
            // 
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(462, 55);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.DisplayFormat.FormatString = "";
            this.txtNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.EditFormat.FormatString = "";
            this.txtNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.Mask.EditMask = "";
            this.txtNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNgay.Size = new System.Drawing.Size(161, 20);
            this.txtNgay.TabIndex = 1;
            // 
            // txtDateChungTu
            // 
            this.txtDateChungTu.EditValue = null;
            this.txtDateChungTu.Location = new System.Drawing.Point(253, 55);
            this.txtDateChungTu.Name = "txtDateChungTu";
            this.txtDateChungTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateChungTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateChungTu.Properties.DisplayFormat.FormatString = "";
            this.txtDateChungTu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateChungTu.Properties.EditFormat.FormatString = "";
            this.txtDateChungTu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateChungTu.Properties.Mask.EditMask = "";
            this.txtDateChungTu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDateChungTu.Size = new System.Drawing.Size(161, 20);
            this.txtDateChungTu.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.calcPhaiTra);
            this.groupControl2.Controls.Add(this.calcNo);
            this.groupControl2.Controls.Add(this.calcSoTien);
            this.groupControl2.Controls.Add(this.txtLyDo);
            this.groupControl2.Controls.Add(this.lookNhanVien);
            this.groupControl2.Location = new System.Drawing.Point(3, 111);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(628, 156);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chi Tiết";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Tiền Phải Trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Còn Nợ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lý do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Tiền";
            // 
            // calcPhaiTra
            // 
            this.calcPhaiTra.Location = new System.Drawing.Point(106, 91);
            this.calcPhaiTra.Name = "calcPhaiTra";
            this.calcPhaiTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcPhaiTra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.calcPhaiTra.Size = new System.Drawing.Size(211, 20);
            this.calcPhaiTra.TabIndex = 1;
            this.calcPhaiTra.EditValueChanged += new System.EventHandler(this.calcEdit1_EditValueChanged);
            // 
            // calcNo
            // 
            this.calcNo.Location = new System.Drawing.Point(106, 60);
            this.calcNo.Name = "calcNo";
            this.calcNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.calcNo.Size = new System.Drawing.Size(211, 20);
            this.calcNo.TabIndex = 1;
            this.calcNo.EditValueChanged += new System.EventHandler(this.calcEdit1_EditValueChanged);
            // 
            // calcSoTien
            // 
            this.calcSoTien.Location = new System.Drawing.Point(106, 29);
            this.calcSoTien.Name = "calcSoTien";
            this.calcSoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcSoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.calcSoTien.Size = new System.Drawing.Size(211, 20);
            this.calcSoTien.TabIndex = 1;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(389, 29);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(228, 81);
            this.txtLyDo.TabIndex = 1;
            // 
            // lookNhanVien
            // 
            this.lookNhanVien.Location = new System.Drawing.Point(106, 123);
            this.lookNhanVien.Name = "lookNhanVien";
            this.lookNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookNhanVien.Properties.NullText = "";
            this.lookNhanVien.Properties.PopupView = this.gridLookUpEdit1View;
            this.lookNhanVien.Size = new System.Drawing.Size(511, 20);
            this.lookNhanVien.TabIndex = 97;
            this.lookNhanVien.EditValueChanged += new System.EventHandler(this.lookNhanVien_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ten,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Ten
            // 
            this.Ten.Caption = "Ten";
            this.Ten.FieldName = "Employee_Name";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã";
            this.gridColumn2.FieldName = "Employee_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(345, 287);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(446, 287);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(545, 287);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 319);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPhieuThu";
            this.Tag = "rpgInvoice";
            this.Text = "Phiếu Thu";
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChungTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateChungTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateChungTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcPhaiTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKhachHang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtChungTu;
        private DevExpress.XtraEditors.TextEdit txtPhieu;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.DateEdit txtDateChungTu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.CalcEdit calcNo;
        private DevExpress.XtraEditors.CalcEdit calcSoTien;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.CalcEdit calcPhaiTra;
        private DevExpress.XtraEditors.MemoEdit txtLyDo;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private DevExpress.XtraEditors.GridLookUpEdit lookNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}