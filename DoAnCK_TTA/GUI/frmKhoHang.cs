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
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {

        public frmKhoHang()
        {
            InitializeComponent();
        }



        private void treeKhoHang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        public void Init()
        {
            DataTable dt = new DataTable();

            BUS_STOCK bUS_ = new BUS_STOCK();
            dt = bUS_.LayThongTinKhoHang();
            List<DTO_STOCK> _dsStock = new List<DTO_STOCK>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_STOCK stock = new DTO_STOCK();
                stock.Stock_ID = dt.Rows[i]["Stock_ID"].ToString();
                stock.Stock_Name = dt.Rows[i]["Stock_Name"].ToString();
                stock.Contact = dt.Rows[i]["Contact"].ToString();
                stock.Address = dt.Rows[i]["Address"].ToString();
                stock.Telephone = dt.Rows[i]["Telephone"].ToString();
                stock.Description = dt.Rows[i]["Description"].ToString();
                stock.Mobi = dt.Rows[i]["Mobi"].ToString();
                stock.Active = bool.Parse(dt.Rows[i]["Active"].ToString());
                _dsStock.Add(stock);
            }

            treeKhoHang.DataSource = _dsStock;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainwindown = new frmThongTinKhoHang();
            mainwindown.ShowDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}