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
    public partial class frmBangKeChiTiet_BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBangKeChiTiet_BanHang()
        {
            InitializeComponent();
        }
        DataTable _dt = new DataTable();
        public void load()
        {
            BUS_STOCK_OUTWARD_DETAIL bus1 = new BUS_STOCK_OUTWARD_DETAIL();
            _dt = bus1.LayThongTinBangKe();

            gridChiTiet.DataSource = _dt;
        }
        private void btnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            var banhang = new frmBanHang();
            //     banhang.Sender(c,d,_dt);    //Gọi

            banhang.Show();
        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = "";

            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                ma = row[0].ToString();

            }


            var phieumuahang = new frmPhieuXuatHang();

            phieumuahang.Sender(ma);
            Form window1 = new Form()
            {
                Text = "Sửa Phiếu Bán Hàng",
                Width = 1130,
                Height = 550,
                AutoSize = false

            };
            window1.Controls.Add(phieumuahang);
            window1.ShowDialog();
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

            //  this.Hide();



            BUS_STOCK_OUTWARD_DETAIL bus = new BUS_STOCK_OUTWARD_DETAIL();
            bus.XoaPhieuXuatHang(ma, mahang, Quantity);
            load();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmBangKeChiTiet_BanHang_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BUS_SYS_USER_RULE bus = new BUS_SYS_USER_RULE();
            dt = bus.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt.Rows[i][0].ToString())
                    {


                        if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                            btnTaoMoi.Enabled = false;
                        if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                            btnXoa.Enabled = false;
                        if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                            btnSuaChua.Enabled = false;
                        if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                            btnXem.Enabled = false;
                        if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                            btnIn.Enabled = false;
                        if (dt.Rows[i]["AllowExport"].ToString() == "False")
                            btnXuat.Enabled = false;
                        //}
                        //if (this.Controls[j].Name.ToString().IndexOf("Nhap") != -1)
                        //{
                        //    if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //        btnXuat.Enabled = false;
                        //}
                        //     }
                        //}
                    }
                }
            }
            load();
        }
    }
}
