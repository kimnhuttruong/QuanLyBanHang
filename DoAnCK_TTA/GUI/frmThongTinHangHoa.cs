using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.BUS;

namespace DoAnCK_TTA.GUI
{
    public partial class frmThongTinHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinHangHoa()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(DTO_PRODUCT c)
        {
            BUS_PRODUCT busp = new BUS_PRODUCT();
            if (c.Product_ID == null || c.Product_ID == "")
                txtMaHang.Text = "HH" + (busp.LayDanhSachHangHoa().Rows.Count + 1).ToString();
            else
            {
                txtMaHang.Text = c.Product_ID;
                txtTenHang.Text = c.Product_Name;
                txtXuatXu.Text = c.Origin;
                calcTonKhoToiThieu.Text = c.MinStock;
                calcTonHienTai.Text = c.CurrentCost;
                txtMaVach.Text = c.Barcode;
                calcGiaMua.Text = c.Org_Price;
                calcBanSi.Text = c.Sale_Price;
                calcBanLe.Text = c.Retail_Price;
                if (c.Photo != null && c.Photo != "\0")
                {
                    try
                    {
                        picture.Image = Image.FromFile(c.Photo);
                    }
                    catch
                    {
                        ;
                    }
                }
                _idKhoHang = c.Stock_ID;
                _idPhanLoai = c.Product_Group_ID;
                _idDonVi = c.Unit;
                _idNhaCungCap = c.Provider_ID;



                checkQuanLy.Checked = c.Active;
            }
            if (c.Product_Name == null || c.Product_Name=="")
                isAdd = true;
            else
                isAdd = false;
        }
        void formLoad()
        {
            BUS_STOCK bus = new BUS_STOCK();
            _dtKhoHang = bus.LayThongTinKhoHang();

           cbKhoMacDinh.Properties.DataSource = _dtKhoHang;
           cbKhoMacDinh.Properties.DisplayMember = "Stock_Name";
           cbKhoMacDinh.Properties.ValueMember = "Stock_ID";

            for (int i = 0; i < _dtKhoHang.Rows.Count - 1; i++)
            {
                if (_idKhoHang == _dtKhoHang.Rows[i]["Stock_ID"].ToString())
                {
                    _idKhoHang = i.ToString();
                    cbKhoMacDinh.EditValue = cbKhoMacDinh.Properties.GetKeyValue(int.Parse(_idKhoHang));
                }
            }

            //if (_idKhoHang != "" && _idKhoHang != null)
              


            BUS_PRODUCT_GROUP bus1 = new BUS_PRODUCT_GROUP();
            _dtPhanLoai = bus1.LayDanhSachNhomHang();

            lookPhanLoai.Properties.DataSource = _dtPhanLoai;
            lookPhanLoai.Properties.DisplayMember = "ProductGroup_Name";
            lookPhanLoai.Properties.ValueMember = "ProductGroup_ID";

            for (int i = 0; i < _dtPhanLoai.Rows.Count - 1; i++)
            {
                if (_idPhanLoai == _dtPhanLoai.Rows[i]["ProductGroup_ID"].ToString())
                {
                    _idPhanLoai = i.ToString();
                    lookPhanLoai.EditValue = lookPhanLoai.Properties.GetKeyValue(int.Parse(_idPhanLoai));
                }
            }
            //if (_idPhanLoai != "" && _idPhanLoai != null)
               


            BUS_UNIT bus2 = new BUS_UNIT();
            _dtDonVi = bus2.LayDanhSachDonViTinh();

            lookDonVi.Properties.DataSource = _dtDonVi;
            lookDonVi.Properties.DisplayMember = "Unit_Name";
            lookDonVi.Properties.ValueMember = "Unit_ID";

            for (int i = 0; i < _dtDonVi.Rows.Count - 1; i++)
            {
                if (_idDonVi == _dtDonVi.Rows[i]["Unit_ID"].ToString())
                {
                    _idDonVi = i.ToString();
                    lookDonVi.EditValue = lookDonVi.Properties.GetKeyValue(int.Parse(_idDonVi));
                }

            }

            //if (_idDonVi != "" && _idDonVi != null)
               


            BUS_PROVIDER bus3 = new BUS_PROVIDER();
            _dtNhaCungCap = bus3.LayDanhSachNhaCungCap();

            lookNhaCungCap.Properties.DataSource = _dtNhaCungCap;
            lookNhaCungCap.Properties.DisplayMember = "CustomerName";
            lookNhaCungCap.Properties.ValueMember = "Customer_ID";

            for (int i = 0; i < _dtNhaCungCap.Rows.Count - 1; i++)
            {
                if (_idNhaCungCap == _dtNhaCungCap.Rows[i]["Customer_ID"].ToString())
                {
                    _idNhaCungCap = i.ToString();
                    lookNhaCungCap.EditValue = lookNhaCungCap.Properties.GetKeyValue(int.Parse(_idNhaCungCap));
                }

            }

            //if (_idNhaCungCap != "" && _idNhaCungCap != null)
              

        }
        bool isAdd = true;
        public delegate void SendMessage(DTO_PRODUCT c);
        public SendMessage Sender;
        string _idKhoHang = "", _idPhanLoai = "", _idDonVi = "", _idNhaCungCap = "";
        
        DataTable _dtKhoHang = new DataTable();
        DataTable _dtPhanLoai = new DataTable();
        DataTable _dtDonVi = new DataTable();
        DataTable _dtNhaCungCap = new DataTable();



        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            BUS_PRODUCT bus = new BUS_PRODUCT();
            DTO_PRODUCT c = new DTO_PRODUCT();
            BUS_INVENTORY_DETAIL iNVENTORY_DETAIL = new BUS_INVENTORY_DETAIL();
            c.Product_ID= txtMaHang.Text;
            c.Product_Name= txtTenHang.Text;
            c.Origin= txtXuatXu.Text;
            c.MinStock = calcTonKhoToiThieu.Text;
            c.CurrentCost= calcTonHienTai.Text;
            c.Barcode= txtMaVach.Text;
            c.Org_Price= calcGiaMua.Text;
            c.Sale_Price= calcBanSi.Text;
            c.Retail_Price = calcBanLe.Text;
            c.Stock_ID= cbKhoMacDinh.EditValue.ToString();
            c.Product_Group_ID = lookPhanLoai.EditValue.ToString();
            c.Unit= lookDonVi.EditValue.ToString();
            c.Provider_ID= lookNhaCungCap.EditValue.ToString();
            c.Photo = picture1;
            

            c.Active = checkQuanLy.Checked;
           
          
                int kt = bus.CapNhatHangHoa(c);
            
           

            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Lưu";
            busLog.ThemLichSu(log);

            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhoMatDinh_Click(object sender, EventArgs e)
        {
            Form khohang = new frmThongTinKhoHang();
            khohang.ShowDialog();

            formLoad();
        }

        private void btnPhanLoai_Click(object sender, EventArgs e)
        {
            Form nhomhang = new frmThongTinNhomHang();
            nhomhang.ShowDialog();
            formLoad();
        }

        private void btnDonVi_Click(object sender, EventArgs e)
        {
            Form donvi = new FrmThongTinDonViTinh();
            donvi.ShowDialog();
            formLoad();
        }

        private void picture_EditValueChanged(object sender, EventArgs e)
        {

        }
        string picture1;
        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            picture1 = dialog.FileName;
            try
            {
                picture.Image = Image.FromFile(dialog.FileName);
            }
            catch
            {
                XtraMessageBox.Show("Ảnh chọn không hợp lệ");
            }
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Form nhacungcap = new frmThongTinNhaCungCap();
            nhacungcap.ShowDialog();
            formLoad();
        }

        private void frmThongTinHangHoa_Load(object sender, EventArgs e)
        {
            formLoad();
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Xem";
            busLog.ThemLichSu(log);

        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            Form hh = new Form();
            hh.Text = "Lịch Sử Hàng Hóa";
            frmLichSuHangHoa a = new frmLichSuHangHoa();
            hh.Controls.Add(a);
            hh.ShowDialog();
        
        }
    }
}