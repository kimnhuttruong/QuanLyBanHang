namespace DoAnCK_TTA.GUI
{
    partial class frmKetChuyen
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.btnSaoLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.cbThoiDiemKetChuyen = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbDauKySau = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhieuNhap = new DevExpress.XtraEditors.TextEdit();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbDonGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbKhoNhap = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbThoiDiemKetChuyen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThoiDiemKetChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDauKySau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDauKySau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKhoNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelText = "Hủy Bỏ";
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "Tiếp Theo";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.PreviousText = "Quay Lại";
            this.wizardControl1.Size = new System.Drawing.Size(677, 432);
            this.wizardControl1.Text = "Thiết Lập Tùy Chọn";
            this.wizardControl1.Click += new System.EventHandler(this.wizardControl1_Click);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.btnSaoLuu);
            this.welcomeWizardPage1.Controls.Add(this.labelControl1);
            this.welcomeWizardPage1.IntroductionText = "Phần này sẽ giúp các bạn kết chuyển số dư cuối kỳ sang kỳ sau, đồng thời xóa hết " +
    "chứng từ hiện tại ";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "Sau khi sao lưu. Nhấn [Tiếp Theo] để tiếp tục";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(460, 299);
            this.welcomeWizardPage1.Text = "Kết chuyển số dư cuối kỳ";
            this.welcomeWizardPage1.Click += new System.EventHandler(this.welcomeWizardPage1_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Location = new System.Drawing.Point(339, 82);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(75, 23);
            this.btnSaoLuu.TabIndex = 1;
            this.btnSaoLuu.Text = "Sao Lưu";
            this.btnSaoLuu.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(392, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "- Các bạn nên tiến hành sao lưu dữ liệu trước khi thực hiện kết chuyển!";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.listBoxControl1);
            this.wizardPage1.Controls.Add(this.txtPhieuNhap);
            this.wizardPage1.Controls.Add(this.labelControl4);
            this.wizardPage1.Controls.Add(this.labelControl6);
            this.wizardPage1.Controls.Add(this.labelControl5);
            this.wizardPage1.Controls.Add(this.cbDauKySau);
            this.wizardPage1.Controls.Add(this.labelControl3);
            this.wizardPage1.Controls.Add(this.cbThoiDiemKetChuyen);
            this.wizardPage1.Controls.Add(this.labelControl2);
            this.wizardPage1.Controls.Add(this.cbDonGia);
            this.wizardPage1.Controls.Add(this.cbKhoNhap);
            this.wizardPage1.DescriptionText = "";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(645, 287);
            this.wizardPage1.Text = "Thiết Lập Tùy Chọn";
            this.wizardPage1.Click += new System.EventHandler(this.wizardPage1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Thời điểm kết chuyển";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(460, 299);
            this.completionWizardPage1.Click += new System.EventHandler(this.completionWizardPage1_Click);
            // 
            // cbThoiDiemKetChuyen
            // 
            this.cbThoiDiemKetChuyen.EditValue = null;
            this.cbThoiDiemKetChuyen.Location = new System.Drawing.Point(24, 48);
            this.cbThoiDiemKetChuyen.Name = "cbThoiDiemKetChuyen";
            this.cbThoiDiemKetChuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbThoiDiemKetChuyen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbThoiDiemKetChuyen.Properties.ReadOnly = true;
            this.cbThoiDiemKetChuyen.Size = new System.Drawing.Size(148, 20);
            this.cbThoiDiemKetChuyen.TabIndex = 1;
            this.cbThoiDiemKetChuyen.EditValueChanged += new System.EventHandler(this.cbThoiDiemKetChuyen_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(188, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Nhập vào đầu kỳ sau";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // cbDauKySau
            // 
            this.cbDauKySau.EditValue = null;
            this.cbDauKySau.Location = new System.Drawing.Point(188, 48);
            this.cbDauKySau.Name = "cbDauKySau";
            this.cbDauKySau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDauKySau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDauKySau.Size = new System.Drawing.Size(148, 20);
            this.cbDauKySau.TabIndex = 1;
            this.cbDauKySau.EditValueChanged += new System.EventHandler(this.cbDauKySau_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(352, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Phiếu nhập kì đầu";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // txtPhieuNhap
            // 
            this.txtPhieuNhap.Location = new System.Drawing.Point(352, 49);
            this.txtPhieuNhap.Name = "txtPhieuNhap";
            this.txtPhieuNhap.Size = new System.Drawing.Size(148, 20);
            this.txtPhieuNhap.TabIndex = 2;
            this.txtPhieuNhap.EditValueChanged += new System.EventHandler(this.txtPhieuNhap_EditValueChanged);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(24, 74);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(312, 116);
            this.listBoxControl1.TabIndex = 3;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(352, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Đơn giá nhập đầu kỳ";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // cbDonGia
            // 
            this.cbDonGia.Location = new System.Drawing.Point(352, 109);
            this.cbDonGia.Name = "cbDonGia";
            this.cbDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDonGia.Properties.DisplayFormat.FormatString = "d";
            this.cbDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbDonGia.Properties.EditFormat.FormatString = "d";
            this.cbDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbDonGia.Size = new System.Drawing.Size(148, 20);
            this.cbDonGia.TabIndex = 1;
            this.cbDonGia.SelectedIndexChanged += new System.EventHandler(this.cbDonGia_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(352, 151);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Kho nhập";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // cbKhoNhap
            // 
            this.cbKhoNhap.Location = new System.Drawing.Point(352, 170);
            this.cbKhoNhap.Name = "cbKhoNhap";
            this.cbKhoNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbKhoNhap.Properties.DisplayFormat.FormatString = "d";
            this.cbKhoNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbKhoNhap.Properties.EditFormat.FormatString = "d";
            this.cbKhoNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbKhoNhap.Properties.NullText = "";
            this.cbKhoNhap.Properties.PopupSizeable = false;
            this.cbKhoNhap.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbKhoNhap.Size = new System.Drawing.Size(268, 20);
            this.cbKhoNhap.TabIndex = 1;
            this.cbKhoNhap.EditValueChanged += new System.EventHandler(this.cbKhoNhap_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmKetChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetChuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Chuyển";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            this.welcomeWizardPage1.PerformLayout();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbThoiDiemKetChuyen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThoiDiemKetChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDauKySau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDauKySau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKhoNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.SimpleButton btnSaoLuu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.TextEdit txtPhieuNhap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit cbDauKySau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit cbThoiDiemKetChuyen;
        private DevExpress.XtraEditors.ComboBoxEdit cbDonGia;
        private DevExpress.XtraEditors.GridLookUpEdit cbKhoNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}