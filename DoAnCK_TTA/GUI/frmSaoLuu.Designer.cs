namespace DoAnCK_TTA.GUI
{
    partial class frmSaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaoLuu));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proTienTrinh = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtTenTapTin = new DevExpress.XtraEditors.TextEdit();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.btnBrown = new DevExpress.XtraEditors.SimpleButton();
            this.checkGhiDe = new DevExpress.XtraEditors.CheckEdit();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.proTienTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGhiDe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(125, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sao lưu dự phòng dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiến trình";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tập tin";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đường dẫn";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // proTienTrinh
            // 
            this.proTienTrinh.Location = new System.Drawing.Point(95, 43);
            this.proTienTrinh.Name = "proTienTrinh";
            this.proTienTrinh.Size = new System.Drawing.Size(322, 18);
            this.proTienTrinh.TabIndex = 2;
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Location = new System.Drawing.Point(95, 68);
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Size = new System.Drawing.Size(322, 20);
            this.txtTenTapTin.TabIndex = 3;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(95, 94);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(322, 20);
            this.txtDuongDan.TabIndex = 3;
            // 
            // btnBrown
            // 
            this.btnBrown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrown.ImageOptions.Image")));
            this.btnBrown.Location = new System.Drawing.Point(388, 95);
            this.btnBrown.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnBrown.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(19, 18);
            this.btnBrown.TabIndex = 4;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // checkGhiDe
            // 
            this.checkGhiDe.Location = new System.Drawing.Point(95, 130);
            this.checkGhiDe.Name = "checkGhiDe";
            this.checkGhiDe.Properties.Caption = "Ghi đè tập tin cũ";
            this.checkGhiDe.Size = new System.Drawing.Size(112, 19);
            this.checkGhiDe.TabIndex = 5;
            this.checkGhiDe.Visible = false;
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(251, 120);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(80, 20);
            this.btnThucHien.TabIndex = 6;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(337, 120);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 20);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 160);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.checkGhiDe);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.txtTenTapTin);
            this.Controls.Add(this.proTienTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDuongDan);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaoLuu";
            this.Tag = "bbiBackup";
            this.Text = "Sao Lưu Dữ Liệu";
            this.Load += new System.EventHandler(this.frmSaoLuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proTienTrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkGhiDe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ProgressBarControl proTienTrinh;
        private DevExpress.XtraEditors.TextEdit txtTenTapTin;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton btnBrown;
        private DevExpress.XtraEditors.CheckEdit checkGhiDe;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}