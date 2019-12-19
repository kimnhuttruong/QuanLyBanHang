using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using DoAnCK_TTA.BUS;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Localization;

namespace DoAnCK_TTA.GUI
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Bitmap ApplicationIcon { get; set; }
        public formMain()
        {
           
            InitializeComponent();
            Sender = new SendMessage(GetMessage);

          
        }
        public class MyBarLocalizer : BarLocalizer
        {
            public override string GetLocalizedString(BarString id)
            {
                if (id == BarString.SkinCaptions)
                {
                    //Default value for BarString.SkinCaptions:
                    //"|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|"
                    string defaultSkinCaptions = base.GetLocalizedString(id);
                    string newSkinCaptions = defaultSkinCaptions.Replace("|DevExpress Style|", "|My Favorite Skin|");
                    return newSkinCaptions;
                }
                return base.GetLocalizedString(id);
            }


        }

        private void GetMessage(string ma)
        {
            
            lbUser.Caption = ma;
            BUS_SYS_USER bususer = new BUS_SYS_USER();
            DataTable dtbususer = new DataTable();
            dtbususer = bususer.LayThongTinUSER();
            lbServer.Caption = dtbususer.Rows[0]["Form_Caption"].ToString();

            DataTable dt = new DataTable();
            BUS_SYS_USER_RULE bus = new BUS_SYS_USER_RULE();
            dt = bus.LayDanhSachPhanQuyen();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (RibbonPage item in ribbon.Pages)
                {
                    foreach (RibbonPageGroup group in item.Groups)
                    {
                        if (group.Tag != null)
                        {
                            if (group.Tag.ToString() == dt.Rows[i][0].ToString() && dt.Rows[i][2].ToString() == "False")
                            {

                                group.Visible = false;
                            }
                        }

                    }
                }


            }

            this.bntKetThuc.Enabled = kiemtrachopheptruycap(bntKetThuc.Tag.ToString());
            this.btnThongTin.Enabled = kiemtrachopheptruycap(btnThongTin.Tag.ToString());
            this.btnPhanQuyen.Enabled = kiemtrachopheptruycap(btnPhanQuyen.Tag.ToString());
            this.btnDoiMatKhau.Enabled = kiemtrachopheptruycap(btnDoiMatKhau.Tag.ToString());
            this.btnNhatKyHeThong.Enabled = kiemtrachopheptruycap(btnNhatKyHeThong.Tag.ToString());
            this.btnSaoLuu.Enabled = kiemtrachopheptruycap(btnSaoLuu.Tag.ToString());
            this.btnPhucHoi.Enabled = kiemtrachopheptruycap(btnPhucHoi.Tag.ToString());
            this.btnSuaChua.Enabled = kiemtrachopheptruycap(btnSuaChua.Tag.ToString());
            this.btnKetChuyen.Enabled = kiemtrachopheptruycap(btnKetChuyen.Tag.ToString());
            this.btnNhapDanhMucTuExcel.Enabled = kiemtrachopheptruycap(btnNhapDanhMucTuExcel.Tag.ToString());
            this.btnKhuVuc.Enabled = kiemtrachopheptruycap(btnKhuVuc.Tag.ToString());
            this.btnKhachHang.Enabled = kiemtrachopheptruycap(btnKhachHang.Tag.ToString());
            this.btnNhaCungCap.Enabled = kiemtrachopheptruycap(btnNhaCungCap.Tag.ToString());
            this.btnKhoHang.Enabled = kiemtrachopheptruycap(btnKhoHang.Tag.ToString());
            this.btnDonViTinh.Enabled = kiemtrachopheptruycap(btnDonViTinh.Tag.ToString());
            this.btnNhomHang.Enabled = kiemtrachopheptruycap(btnNhomHang.Tag.ToString());
            this.btnHangHoa.Enabled = kiemtrachopheptruycap(btnHangHoa.Tag.ToString());
            this.btnInMaVach.Enabled = kiemtrachopheptruycap(btnInMaVach.Tag.ToString());
            this.btnTyGia.Enabled = kiemtrachopheptruycap(btnTyGia.Tag.ToString());
            this.btnNhanVien.Enabled = kiemtrachopheptruycap(btnNhanVien.Tag.ToString());
            this.btnMuaHang.Enabled = kiemtrachopheptruycap(btnMuaHang.Tag.ToString());
            this.btnBanHang.Enabled = kiemtrachopheptruycap(btnBanHang.Tag.ToString());
            this.btnTonKho.Enabled = kiemtrachopheptruycap(btnTonKho.Tag.ToString());
            this.btnChuyenKho.Enabled = kiemtrachopheptruycap(btnChuyenKho.Tag.ToString());
            this.btnNhapSoDuDauKy.Enabled = kiemtrachopheptruycap(btnNhapSoDuDauKy.Tag.ToString());
            this.btnThuTien.Enabled = kiemtrachopheptruycap(btnThuTien.Tag.ToString());
            this.btnTraTien.Enabled = kiemtrachopheptruycap(btnTraTien.Tag.ToString());
            this.btnBaoCaoKhoHang.Enabled = kiemtrachopheptruycap(btnBaoCaoKhoHang.Tag.ToString());
            this.btnBaoCaoBanHang.Enabled = kiemtrachopheptruycap(btnBaoCaoBanHang.Tag.ToString());
            this.btnBoPhan.Enabled = kiemtrachopheptruycap(btnBoPhan.Tag.ToString());
            this.btnChungTu.Enabled = kiemtrachopheptruycap(btnChungTu.Tag.ToString());


        }
        public delegate void SendMessage(string ma);
        public SendMessage Sender;
        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Width = 30;
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinCongTy();
            mainWindow.ShowDialog();
        }
        private new Form IsActive(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    return f;
                }

            }
            return null;
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmPhanQuyen));//kiểm tra có show hay không

            if(form ==null)
            {
                frmPhanQuyen f = new frmPhanQuyen();
                f.MdiParent = this;
                f.Text = "Phân Quyền";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

      
        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {

            var mainWindow = new FrmDoiMatKhau();
            mainWindow.ShowDialog();
        }
        bool kiemtrachopheptruycap(string mh)
        {
            BUS_SYS_USER_RULE bus = new BUS_SYS_USER_RULE();
            DataTable dt = new DataTable();
            dt = bus.LayDanhSachPhanQuyenButton(mh);
            if (dt.Rows.Count > 0)
                return bool.Parse(dt.Rows[0][0].ToString());
            else
                return true;

        }
       
        private void formMain_Load(object sender, EventArgs e)
        {
            BarLocalizer.Active = new MyBarLocalizer();

            SkinHelper.InitSkinGallery(ribbonGalleryBarItem2, true);
            SkinHelper.InitSkinPopupMenu(popupMenu1);


            DataTable dt = new DataTable();
            BUS_SYS_USER_RULE bus = new BUS_SYS_USER_RULE();
            dt = bus.LayDanhSachPhanQuyen();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (RibbonPage item in ribbon.Pages)
                {
                    foreach (RibbonPageGroup group in item.Groups)
                    {
                        if (group.Tag != null)
                        {
                            if (group.Tag.ToString() == dt.Rows[i][0].ToString() && dt.Rows[i][2].ToString() == "False")
                            {
                                
                                group.Visible = false;
                            }
                        }

                    }
                }


            }

            this.bntKetThuc.Enabled = kiemtrachopheptruycap(bntKetThuc.Tag.ToString());
            this.btnThongTin.Enabled = kiemtrachopheptruycap(btnThongTin.Tag.ToString());
            this.btnPhanQuyen.Enabled = kiemtrachopheptruycap(btnPhanQuyen.Tag.ToString());
            this.btnDoiMatKhau.Enabled = kiemtrachopheptruycap(btnDoiMatKhau.Tag.ToString());
            this.btnNhatKyHeThong.Enabled = kiemtrachopheptruycap(btnNhatKyHeThong.Tag.ToString());
            this.btnSaoLuu.Enabled = kiemtrachopheptruycap(btnSaoLuu.Tag.ToString());
            this.btnPhucHoi.Enabled = kiemtrachopheptruycap(btnPhucHoi.Tag.ToString());
            this.btnSuaChua.Enabled = kiemtrachopheptruycap(btnSuaChua.Tag.ToString());
            this.btnKetChuyen.Enabled = kiemtrachopheptruycap(btnKetChuyen.Tag.ToString());
            this.btnNhapDanhMucTuExcel.Enabled = kiemtrachopheptruycap(btnNhapDanhMucTuExcel.Tag.ToString());
            this.btnKhuVuc.Enabled = kiemtrachopheptruycap(btnKhuVuc.Tag.ToString());
            this.btnKhachHang.Enabled = kiemtrachopheptruycap(btnKhachHang.Tag.ToString());
            this.btnNhaCungCap.Enabled = kiemtrachopheptruycap(btnNhaCungCap.Tag.ToString());
            this.btnKhoHang.Enabled = kiemtrachopheptruycap(btnKhoHang.Tag.ToString());
            this.btnDonViTinh.Enabled = kiemtrachopheptruycap(btnDonViTinh.Tag.ToString());
            this.btnNhomHang.Enabled = kiemtrachopheptruycap(btnNhomHang.Tag.ToString());
            this.btnHangHoa.Enabled = kiemtrachopheptruycap(btnHangHoa.Tag.ToString());
            this.btnInMaVach.Enabled = kiemtrachopheptruycap(btnInMaVach.Tag.ToString());
            this.btnTyGia.Enabled = kiemtrachopheptruycap(btnTyGia.Tag.ToString());
            this.btnNhanVien.Enabled = kiemtrachopheptruycap(btnNhanVien.Tag.ToString());
            this.btnMuaHang.Enabled = kiemtrachopheptruycap(btnMuaHang.Tag.ToString());
            this.btnBanHang.Enabled = kiemtrachopheptruycap(btnBanHang.Tag.ToString());
            this.btnTonKho.Enabled = kiemtrachopheptruycap(btnTonKho.Tag.ToString());
            this.btnChuyenKho.Enabled = kiemtrachopheptruycap(btnChuyenKho.Tag.ToString());
            this.btnNhapSoDuDauKy.Enabled = kiemtrachopheptruycap(btnNhapSoDuDauKy.Tag.ToString());
            this.btnThuTien.Enabled = kiemtrachopheptruycap(btnThuTien.Tag.ToString());
            this.btnTraTien.Enabled = kiemtrachopheptruycap(btnTraTien.Tag.ToString());
            this.btnBaoCaoKhoHang.Enabled = kiemtrachopheptruycap(btnBaoCaoKhoHang.Tag.ToString());
            this.btnBaoCaoBanHang.Enabled = kiemtrachopheptruycap(btnBaoCaoBanHang.Tag.ToString());
            this.btnBoPhan.Enabled = kiemtrachopheptruycap(btnBoPhan.Tag.ToString());
            this.btnChungTu.Enabled = kiemtrachopheptruycap(btnChungTu.Tag.ToString());



           


        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmKhuVuc));//kiểm tra có show hay không

            if (form == null)
            {
                frmKhuVuc f = new frmKhuVuc();
                f.MdiParent = this;
                f.Text = "Khu Vực";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmKhachHang));//kiểm tra có show hay không

            if (form == null)
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Text = "Khách Hàng";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmKhoHang));//kiểm tra có show hay không

            if (form == null)
            {
                frmKhoHang f = new frmKhoHang();
                f.MdiParent = this;
                f.Text = "Kho Hàng";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmDonViTinh));//kiểm tra có show hay không

            if (form == null)
            {
                frmDonViTinh f = new frmDonViTinh();
                f.MdiParent = this;
                f.Text = "Đơn Vị Tính";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmNhomHang));//kiểm tra có show hay không

            if (form == null)
            {
                frmNhomHang f = new frmNhomHang();
                f.MdiParent = this;
                f.Text = "Nhóm Hàng";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmHangHoa));//kiểm tra có show hay không

            if (form == null)
            {
                frmHangHoa f = new frmHangHoa();
                f.MdiParent = this;
                f.Text = "Hàng Hóa";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmNhanVien));//kiểm tra có show hay không

            if (form == null)
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Text = "Nhân Viên";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmNhaCungCap));//kiểm tra có show hay không

            if (form == null)
            {
                frmNhaCungCap f = new frmNhaCungCap();
                f.MdiParent = this;
                f.Text = "Nhà Cung Cấp";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnTyGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmTyGia));//kiểm tra có show hay không

            if (form == null)
            {
                frmTyGia f = new frmTyGia();
                f.MdiParent = this;
                f.Text = "Tỷ Giá";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmBoPhan));//kiểm tra có show hay không

            if (form == null)
            {
                frmBoPhan f = new frmBoPhan();
                f.MdiParent = this;
                f.Text = "Bộ Phận";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnMuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmMuaHang));//kiểm tra có show hay không

            if (form == null)
            {
                frmMuaHang f = new frmMuaHang();
                f.MdiParent = this;
                f.Text = "Mua Hàng";
                f.Show();
              
            }
            else
            {
                form.Activate();
            }
        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmBanHang));//kiểm tra có show hay không

            if (form == null)
            {
                frmBanHang f = new frmBanHang();
                f.MdiParent = this;
                f.Text = "Bán Hàng";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmTonKho));//kiểm tra có show hay không

            if (form == null)
            {
                frmTonKho f = new frmTonKho();
                f.MdiParent = this;
                f.Text = "Tồn Kho";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnChuyenKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmChuyenKho));//kiểm tra có show hay không

            if (form == null)
            {
                frmChuyenKho f = new frmChuyenKho();
                f.MdiParent = this;
                f.Text = "Chuyển Kho";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmThuTien));//kiểm tra có show hay không

            if (form == null)
            {
                frmThuTien f = new frmThuTien();
                f.MdiParent = this;
                f.Text = "Thu Tiền";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnTraTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmTraTien));//kiểm tra có show hay không

            if (form == null)
            {
                frmTraTien f = new frmTraTien();
                f.MdiParent = this;
                f.Text = "Phiếu Chi";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnBaoCaoKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmBaoCaoKhoHang));//kiểm tra có show hay không

            if (form == null)
            {
                frmBaoCaoKhoHang f = new frmBaoCaoKhoHang();
                f.MdiParent = this;
                f.Text = "Phiếu Chi";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnBaoCaoBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmBaoCaoBanHang));//kiểm tra có show hay không

            if (form == null)
            {
                frmBaoCaoBanHang f = new frmBaoCaoBanHang();
                f.MdiParent = this;
                f.Text = "Báo CÁo Bán Hàng";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void btnHoTroTrucTuyen_ItemClick(object sender, ItemClickEventArgs e)
        {

            //Process p = Process.Start(@"TeamViewer.exe");
        }

        private void btnChungTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmChungTu));//kiểm tra có show hay không

            if (form == null)
            {
                frmChungTu f = new frmChungTu();
                f.MdiParent = this;
                f.Text = "Chứng Từ";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void formMain_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnNhatKyHeThong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(FrmNhatKyHeThong));//kiểm tra có show hay không

            if (form == null)
            {
                FrmNhatKyHeThong f = new FrmNhatKyHeThong();
                f.MdiParent = this;
                f.Text = "Nhật Ký Hệ Thống";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
          

            string folderpath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();

          
            if (dr == DialogResult.OK)
            {
                folderpath = fbd.SelectedPath;
                BUS_SYS bUS = new BUS_SYS();
                
                
                DialogResult dialogResult = MessageBox.Show("Bạn Đã Cấp Quyền Cho Thư Mục Bạn Muốn Backup?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string kt = bUS.SaoLuu(folderpath);
                    if (kt != "1")
                    {
                        MessageBox.Show("Sao Lưu KHông Thành Công.Vui Lòng Cấp Quyền truy cập cho Folder Chứa file Backup\n Xóa File Backup vừa tạo: "+kt);
                    }
                    else
                    {
                        MessageBox.Show("Sao Lưu thành công");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    ;
                }

               
            }

        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.bak)|*.bak|All files (*.*)|*.*";
            dialog.Title = "Please select an Backup file to encrypt.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Chắc Chắc Muốn Backup?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BUS_SYS bUS = new BUS_SYS();
                    string kt = bUS.PhucHoi(dialog.FileName);
                    if (kt != "1")
                    {
                        MessageBox.Show("Phục Hồi KHông Thành Công.Vui Lòng Cấp Quyền truy cập cho Folder Chứa file Backup\n Xóa File Backup vừa tạo: " + kt);
                    }
                    else
                    {
                        MessageBox.Show("Phục Hồi thành công");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    ;
                }


            }


        }
    }
}