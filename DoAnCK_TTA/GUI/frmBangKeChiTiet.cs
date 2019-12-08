using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnCK_TTA.BUS;

namespace DoAnCK_TTA.GUI
{
    public partial class frmBangKeChiTiet : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBangKeChiTiet()
        {
            InitializeComponent();


        }

        private void frmBangKeChiTiet_Load(object sender, EventArgs e)
        {
            load();
        }
        DataTable _dt = new DataTable();
        public void load()
        {
            BUS_STOCK_INWARD_DETAIL bus1 = new BUS_STOCK_INWARD_DETAIL();
            _dt = bus1.LayThongTinBangKe();

            gridChiTiet.DataSource = _dt;
        }

       
        private void btnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            this.Hide();
            var banhang = new frmMuaHang();
       //     banhang.Sender(c,d,_dt);    //Gọi
            banhang.Show();

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string ma = "";
            string mahang = "";
            string Quantity = "";
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                ma = row[0].ToString();
                mahang = row["Product_ID"].ToString();
                Quantity = row["Quantity"].ToString();
            }

            this.Hide();
            var banhang = new frmMuaHang();
            //     banhang.Sender(c,d,_dt);    //Gọi
            banhang.Show();


            BUS_STOCK_INWARD_DETAIL bus = new BUS_STOCK_INWARD_DETAIL();
            bus.XoaPhieuNhapHang(ma, mahang, Quantity);
            load();

        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = "";
         
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                ma = row[0].ToString();
             
            }

            this.Hide();
            var banhang = new frmMuaHang();
            banhang.Sender(ma);    //Gọi
            banhang.Show();


        }
    }
}
