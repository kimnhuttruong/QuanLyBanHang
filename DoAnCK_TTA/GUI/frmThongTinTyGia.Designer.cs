namespace DoAnCK_TTA.GUI
{
    partial class frmThongTinTyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinTyGia));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.txtTyGiaQuyDoi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTyGiaQuyDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkQuanLy);
            this.groupControl1.Controls.Add(this.txtTyGiaQuyDoi);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 147);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin";
            // 
            // checkQuanLy
            // 
            this.checkQuanLy.Location = new System.Drawing.Point(62, 122);
            this.checkQuanLy.Name = "checkQuanLy";
            this.checkQuanLy.Properties.Caption = "Còn quản lý";
            this.checkQuanLy.Size = new System.Drawing.Size(90, 19);
            this.checkQuanLy.TabIndex = 9;
            // 
            // txtTyGiaQuyDoi
            // 
            this.txtTyGiaQuyDoi.Location = new System.Drawing.Point(86, 96);
            this.txtTyGiaQuyDoi.Name = "txtTyGiaQuyDoi";
            this.txtTyGiaQuyDoi.Size = new System.Drawing.Size(174, 20);
            this.txtTyGiaQuyDoi.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(86, 59);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(174, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(86, 24);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(174, 20);
            this.txtMa.TabIndex = 8;
            this.txtMa.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tỷ giá quy đổi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mã";
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Location = new System.Drawing.Point(194, 156);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(113, 156);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThongTinTyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 192);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmThongTinTyGia";
            this.Tag = "bbiExchangeRate";
            this.Text = "Thông Tin Tỷ Giá";
            this.Load += new System.EventHandler(this.frmThongTinTyGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTyGiaQuyDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkQuanLy;
        private DevExpress.XtraEditors.TextEdit txtTyGiaQuyDoi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}