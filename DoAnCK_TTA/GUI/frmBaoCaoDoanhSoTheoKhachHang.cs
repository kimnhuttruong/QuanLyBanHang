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
using DevExpress.XtraGrid.Views.Grid;
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.BUS;

namespace DoAnCK_TTA.GUI
{
    public partial class frmBaoCaoDoanhSoTheoKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBaoCaoDoanhSoTheoKhachHang()
        {
            InitializeComponent();
        }

        private void gridView5_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.IsEmpty = !dsDetail.Any(x => x.Customer_ID == group.MaKH);
        }

        private void gridView5_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.ChildList = dsDetail.Where(x => x.Customer_ID == group.MaKH).ToList();
        }
        class TongMua
        {
            public string MaKH { get; set; }
            public string TenKH{ get; set; }
            public string TongTien { get; set; }
            public string KhuVuc { get; set; }
        }
        List<TongMua> dsGroup = new List<TongMua>();
        List<DTO_STOCK_OUTWARD> dsDetail = new List<DTO_STOCK_OUTWARD>();
        private void gridView5_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView5_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Level1";
        }

        private void frmBaoCaoDoanhSoTheoKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BUS_STOCK_OUTWARD_DETAIL bus = new BUS_STOCK_OUTWARD_DETAIL();
            dt = bus.LayThongTinMuaHangTheoKH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TongMua tm = new TongMua();
                tm.MaKH = dt.Rows[i]["Customer_ID"].ToString();
                tm.TenKH = dt.Rows[i]["CustomerName"].ToString();
                tm.TongTien = dt.Rows[i]["TienBan"].ToString();
                tm.KhuVuc = dt.Rows[i]["Customer_Group_Name"].ToString();
                tm.TongTien = dt.Rows[i]["TienBan"].ToString();

                dsGroup.Add(tm);
            }

            gridChiPhiMuaHang.DataSource = dsGroup;


            BUS_STOCK_OUTWARD bus1 = new BUS_STOCK_OUTWARD();
            DataTable dt2 = new DataTable();
            dt2 = bus1.LayThongTinBangKeChiTiet();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DTO_STOCK_OUTWARD dTO_STOCK_INWARD = new DTO_STOCK_OUTWARD();
                dTO_STOCK_INWARD.ID = dt2.Rows[i]["ID"].ToString();
                dTO_STOCK_INWARD.RefDate = dt2.Rows[i]["RefDate"].ToString();
                dTO_STOCK_INWARD.Charge = dt2.Rows[i]["Charge"].ToString();
                dTO_STOCK_INWARD.Customer_ID = dt2.Rows[i]["Customer_ID"].ToString();
                dTO_STOCK_INWARD.Vat = dt2.Rows[i]["Vat"].ToString();
                dTO_STOCK_INWARD.VatAmount = dt2.Rows[i]["VatAmount"].ToString();
                dTO_STOCK_INWARD.Amount = dt2.Rows[i]["Amount"].ToString();
                dTO_STOCK_INWARD.FAmount = dt2.Rows[i]["FAmount"].ToString();
                dsDetail.Add(dTO_STOCK_INWARD);
            }
        }
    }
}
