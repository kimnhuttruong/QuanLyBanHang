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
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomHang()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainwindown = new frmThongTinNhomHang();
            mainwindown.ShowDialog();
        }

        private void btnDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhomHang_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            DataTable dt = new DataTable();

            BUS_PRODUCT_GROUP bUS_ = new BUS_PRODUCT_GROUP();
            dt = bUS_.LayThongTinNhomHang();
            List<DTO_PRODUCT_GROUP> ds = new List<DTO_PRODUCT_GROUP>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_PRODUCT_GROUP pro_g = new DTO_PRODUCT_GROUP();
                pro_g.ProductGroup_ID = dt.Rows[i]["ProductGroup_ID"].ToString();
                pro_g.ProductGroup_Name = dt.Rows[i]["ProductGroup_Name"].ToString();
                pro_g.Description = dt.Rows[i]["Description"].ToString();
                pro_g.Active = bool.Parse(dt.Rows[i]["Active"].ToString());

                ds.Add(pro_g);
            }

            treeNhomHang.DataSource = ds;
        }
    }
}