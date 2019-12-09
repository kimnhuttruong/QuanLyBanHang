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

namespace DoAnCK_TTA.GUI
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Bitmap ApplicationIcon { get; set; }
        public formMain()
        {
          
            
        InitializeComponent();
        }


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

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
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
                MessageBox.Show(f.Location.X.ToString() + " " + f.Location.Y.ToString());
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
            //Form form = IsActive(typeof());//kiểm tra có show hay không

            //if (form == null)
            //{
            //    frmThuTien f = new frmThuTien();
            //    f.MdiParent = this;
            //    f.Text = "Thu Tiền";
            //    f.Show();
            //}
            //else
            //{
            //    form.Activate();
            //}
        }
    }
}