namespace DoAnCK_TTA.GUI
{
    partial class frmPhucHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhucHoi));
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrown = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenTapTin = new DevExpress.XtraEditors.TextEdit();
            this.proTienTrinh = new DevExpress.XtraEditors.ProgressBarControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proTienTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(324, 126);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 20);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(233, 126);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(80, 20);
            this.btnThucHien.TabIndex = 16;
            this.btnThucHien.Text = "Thực Hiện";
            // 
            // btnBrown
            // 
            this.btnBrown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrown.ImageOptions.Image")));
            this.btnBrown.Location = new System.Drawing.Point(370, 59);
            this.btnBrown.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnBrown.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(19, 18);
            this.btnBrown.TabIndex = 13;
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Location = new System.Drawing.Point(91, 58);
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Size = new System.Drawing.Size(303, 20);
            this.txtTenTapTin.TabIndex = 11;
            // 
            // proTienTrinh
            // 
            this.proTienTrinh.Location = new System.Drawing.Point(91, 28);
            this.proTienTrinh.Name = "proTienTrinh";
            this.proTienTrinh.Size = new System.Drawing.Size(303, 18);
            this.proTienTrinh.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cơ sở dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên tập tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tiến trình";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(91, 89);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(303, 20);
            this.txtDuongDan.TabIndex = 12;
            // 
            // frmPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 162);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.txtTenTapTin);
            this.Controls.Add(this.proTienTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuongDan);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhucHoi";
            this.Tag = "bbiRestore";
            this.Text = "Phục Hồi Dữ Liệu";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proTienTrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnBrown;
        private DevExpress.XtraEditors.TextEdit txtTenTapTin;
        private DevExpress.XtraEditors.ProgressBarControl proTienTrinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
    }
}