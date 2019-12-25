namespace DoAnCK_TTA.GUI
{
    partial class frmNhapFile
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
            this.wizardControl = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rbHangHoa = new System.Windows.Forms.RadioButton();
            this.rbNhaCungCap = new System.Windows.Forms.RadioButton();
            this.rbKhachHang = new System.Windows.Forms.RadioButton();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.listSheet = new DevExpress.XtraEditors.ListBoxControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuongDan = new DevExpress.XtraEditors.ButtonEdit();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.gridNoiDung = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl.Controls.Add(this.wizardPage1);
            this.wizardControl.Controls.Add(this.wizardPage2);
            this.wizardControl.Controls.Add(this.completionWizardPage1);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.completionWizardPage1});
            this.wizardControl.Size = new System.Drawing.Size(677, 432);
            this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            this.wizardControl.CustomizeCommandButtons += new DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(this.wizardControl_CustomizeCommandButtons);
            this.wizardControl.Click += new System.EventHandler(this.wizardControl_Click);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.groupControl1);
            this.welcomeWizardPage1.IntroductionText = "";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(460, 299);
            this.welcomeWizardPage1.Text = "Nhập Dữ Liệu Từ File";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rbHangHoa);
            this.groupControl1.Controls.Add(this.rbNhaCungCap);
            this.groupControl1.Controls.Add(this.rbKhachHang);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(460, 299);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn loại dữ liệu được nhập";
            // 
            // rbHangHoa
            // 
            this.rbHangHoa.AutoSize = true;
            this.rbHangHoa.Location = new System.Drawing.Point(53, 172);
            this.rbHangHoa.Name = "rbHangHoa";
            this.rbHangHoa.Size = new System.Drawing.Size(77, 17);
            this.rbHangHoa.TabIndex = 0;
            this.rbHangHoa.TabStop = true;
            this.rbHangHoa.Text = "Hàng Hóa";
            this.rbHangHoa.UseVisualStyleBackColor = true;
            this.rbHangHoa.CheckedChanged += new System.EventHandler(this.rbHangHoa_CheckedChanged);
            // 
            // rbNhaCungCap
            // 
            this.rbNhaCungCap.AutoSize = true;
            this.rbNhaCungCap.Location = new System.Drawing.Point(53, 126);
            this.rbNhaCungCap.Name = "rbNhaCungCap";
            this.rbNhaCungCap.Size = new System.Drawing.Size(100, 17);
            this.rbNhaCungCap.TabIndex = 0;
            this.rbNhaCungCap.TabStop = true;
            this.rbNhaCungCap.Text = "Nhà Cung Cấp";
            this.rbNhaCungCap.UseVisualStyleBackColor = true;
            this.rbNhaCungCap.CheckedChanged += new System.EventHandler(this.rbNhaCungCap_CheckedChanged);
            // 
            // rbKhachHang
            // 
            this.rbKhachHang.AutoSize = true;
            this.rbKhachHang.Location = new System.Drawing.Point(53, 81);
            this.rbKhachHang.Name = "rbKhachHang";
            this.rbKhachHang.Size = new System.Drawing.Size(87, 17);
            this.rbKhachHang.TabIndex = 0;
            this.rbKhachHang.TabStop = true;
            this.rbKhachHang.Text = "Khách Hàng";
            this.rbKhachHang.UseVisualStyleBackColor = true;
            this.rbKhachHang.CheckedChanged += new System.EventHandler(this.rbKhachHang_CheckedChanged);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.listSheet);
            this.wizardPage1.Controls.Add(this.label1);
            this.wizardPage1.Controls.Add(this.txtDuongDan);
            this.wizardPage1.DescriptionText = "Chỉ Hỗ Trợ Tập Tin Excel 2007 Trở Lên";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(645, 287);
            this.wizardPage1.Text = "Chọn Tập Tin Nguồn";
            // 
            // listSheet
            // 
            this.listSheet.Location = new System.Drawing.Point(0, 3);
            this.listSheet.Name = "listSheet";
            this.listSheet.Size = new System.Drawing.Size(642, 239);
            this.listSheet.TabIndex = 3;
            this.listSheet.SelectedIndexChanged += new System.EventHandler(this.listSheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn đường dẫn";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(3, 264);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDuongDan.Size = new System.Drawing.Size(639, 20);
            this.txtDuongDan.TabIndex = 0;
            this.txtDuongDan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDuongDan_ButtonClick);
            this.txtDuongDan.EditValueChanged += new System.EventHandler(this.txtDuongDan_EditValueChanged);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.gridNoiDung);
            this.wizardPage2.DescriptionText = "Chọn Next Để Cập Nhật Vào Dữ Liệu";
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(645, 287);
            this.wizardPage2.Text = "Nội Dung File Đã Chọn";
            // 
            // gridNoiDung
            // 
            this.gridNoiDung.Location = new System.Drawing.Point(3, 3);
            this.gridNoiDung.MainView = this.gridView1;
            this.gridNoiDung.Name = "gridNoiDung";
            this.gridNoiDung.Size = new System.Drawing.Size(639, 281);
            this.gridNoiDung.TabIndex = 0;
            this.gridNoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridNoiDung.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridNoiDung_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridNoiDung;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.gridView1_CustomDrawColumnHeader);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.FinishText = "You have successfully completed the database";
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(460, 299);
            this.completionWizardPage1.Text = "Đã Hoàn Thành Cập Nhật";
            this.completionWizardPage1.Click += new System.EventHandler(this.completionWizardPage1_Click);
            // 
            // frmNhapFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Dữ Liệu Từ File";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rbKhachHang;
        private System.Windows.Forms.RadioButton rbHangHoa;
        private System.Windows.Forms.RadioButton rbNhaCungCap;
        private DevExpress.XtraEditors.ListBoxControl listSheet;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit txtDuongDan;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private DevExpress.XtraGrid.GridControl gridNoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
    }
}