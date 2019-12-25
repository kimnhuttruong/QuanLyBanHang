namespace DoAnCK_TTA.GUI
{
    partial class frmSuaChua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaChua));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.procBaoTri = new DevExpress.XtraEditors.ProgressBarControl();
            this.listBaoTri = new DevExpress.XtraEditors.ListBoxControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnTroGiup = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.procKiemLoi = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.procBaoTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procKiemLoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(439, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chú ý:  Tùy vào độ lớn dữ liệu mà thời gian sửa chữa khác nhau";
            // 
            // procBaoTri
            // 
            this.procBaoTri.Location = new System.Drawing.Point(10, 58);
            this.procBaoTri.Name = "procBaoTri";
            this.procBaoTri.Size = new System.Drawing.Size(505, 18);
            this.procBaoTri.TabIndex = 2;
            // 
            // listBaoTri
            // 
            this.listBaoTri.Location = new System.Drawing.Point(10, 84);
            this.listBaoTri.Name = "listBaoTri";
            this.listBaoTri.Size = new System.Drawing.Size(505, 127);
            this.listBaoTri.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(435, 222);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 20);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(344, 222);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(80, 20);
            this.btnThucHien.TabIndex = 18;
            this.btnThucHien.Text = "Thực Hiện";
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroGiup.ImageOptions.Image")));
            this.btnTroGiup.Location = new System.Drawing.Point(10, 222);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(80, 20);
            this.btnTroGiup.TabIndex = 18;
            this.btnTroGiup.Text = "Trợ Giúp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kểm lỗi dữ liệu";
            // 
            // procKiemLoi
            // 
            this.procKiemLoi.Location = new System.Drawing.Point(9, 271);
            this.procKiemLoi.Name = "procKiemLoi";
            this.procKiemLoi.Size = new System.Drawing.Size(508, 18);
            this.procKiemLoi.TabIndex = 2;
            // 
            // frmSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTroGiup);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.listBaoTri);
            this.Controls.Add(this.procKiemLoi);
            this.Controls.Add(this.procBaoTri);
            this.Controls.Add(this.labelControl1);
  //          this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaChua";
            this.Tag = "bbiFix";
            this.Text = "Bảo Trì Dữ Liệu";
            ((System.ComponentModel.ISupportInitialize)(this.procBaoTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procKiemLoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ProgressBarControl procBaoTri;
        private DevExpress.XtraEditors.ListBoxControl listBaoTri;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnTroGiup;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ProgressBarControl procKiemLoi;
    }
}