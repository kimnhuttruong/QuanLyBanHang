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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            DataTable dt = new DataTable();
            BUS_SYS_USER_RULE bus = new BUS_SYS_USER_RULE();
            dt = bus.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt.Rows[i][0].ToString())
                    {
                        for (int j = 0; j < this.Controls.Count; j++)
                        {
                             if (this.Controls[j].Name != null)
                             {
                                 if (this.Controls[j].Name.ToString().IndexOf("Them") != -1 || this.Controls[j].Name.ToString().IndexOf("Moi") != -1)
                                 {
                                     if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                                         this.Controls[j].Visible = false;
                                 }
                                 if (this.Controls[j].Name.ToString().IndexOf("Xoa") != -1)
                                 {
                                     if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                                         this.Controls[j].Visible = false;
                                 }
                                 if (this.Controls[j].Name.ToString().IndexOf("Sua") != -1)
                                 {
                                     if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                                         this.Controls[j].Visible = false; ;
                                 }
                                 if (this.Controls[j].Name.ToString().IndexOf("Xem") != -1)
                                 {
                                     if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                                         this.Controls[j].Visible = false;
                                 }
                                 if (this.Controls[j].Name.ToString().IndexOf("In") != -1)
                                 {
                                     if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                                         this.Controls[j].Visible = false;
                                 }
                                 if (this.Controls[j].Name.ToString().IndexOf("Xuat") != -1)
                                 {
                                     if (dt.Rows[i]["AllowExport"].ToString() == "False")
                                         this.Controls[j].Visible = false;
                                 }
                                 if (this.Controls[j].Name.ToString().IndexOf("Nhap") != -1)
                                 {
                                     if (dt.Rows[i]["AllowImport"].ToString() == "False")
                                         this.Controls[j].Visible = false;
                                 }
                             }
                        }
                    }
                }
            }
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

          //  this.Hide();
           


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
            

            var phieumuahang = new frmPhieuNhapHang();
            
            phieumuahang.Sender(ma);
            Form window1 = new Form()
            {
                Text = "Sửa Phiếu Mua Hàng",
                Width = 1130,
                Height = 550,
                AutoSize = false
               
            };
            window1.Controls.Add(phieumuahang);
            window1.ShowDialog();
            MessageBox.Show(ma);
        }
    }
}
