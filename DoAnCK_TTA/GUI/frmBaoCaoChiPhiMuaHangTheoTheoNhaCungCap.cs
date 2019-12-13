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
using DevExpress.XtraGrid.Views.Grid;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmBaoCaoChiPhiMuaHangTheoTheoNhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BUS_STOCK_INWARD_DETAIL bus = new BUS_STOCK_INWARD_DETAIL();
           dt = bus.LayThongTinMuaHangTheoNCC();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                TongMua tm = new TongMua();
                tm.MaNCC = dt.Rows[i]["Customer_ID"].ToString();
                tm.TenNCC = dt.Rows[i]["CustomerName"].ToString();
                tm.TongTien = dt.Rows[i]["TienMua"].ToString();
                tm.KhuVuc = dt.Rows[i]["Customer_Group_Name"].ToString();
                dsGroup.Add(tm);
            }

            gridChiPhiMuaHang.DataSource = dsGroup;

           
            BUS_STOCK_INWARD bus1 = new BUS_STOCK_INWARD();
            DataTable dt2 = new DataTable();
            dt2 = bus1.LayThongTinBangKeChiTiet();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DTO_STOCK_INWARD dTO_STOCK_INWARD = new DTO_STOCK_INWARD();
                dTO_STOCK_INWARD.ID = dt2.Rows[i]["ID"].ToString();
                dTO_STOCK_INWARD.RefDate = dt2.Rows[i]["RefDate"].ToString();
                dTO_STOCK_INWARD.Charge = dt2.Rows[i]["Charge"].ToString();
                dTO_STOCK_INWARD.Customer_ID = dt2.Rows[i]["Customer_ID"].ToString();
                dsDetail.Add(dTO_STOCK_INWARD);
            }
        }

        private void gridView5_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.IsEmpty = !dsDetail.Any(x => x.Customer_ID == group.MaNCC);
        }

        private void gridView5_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.ChildList = dsDetail.Where(x => x.Customer_ID == group.MaNCC).ToList();
        }
        class TongMua
        {
            public string MaNCC { get; set; }
            public string TenNCC { get; set; }
            public string TongTien { get; set; }
            public string KhuVuc { get; set; }
        }
        List<TongMua> dsGroup = new List<TongMua>();
        List<DTO_STOCK_INWARD> dsDetail = new List<DTO_STOCK_INWARD>();
        private void gridView5_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView5_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Level1";
        }
    }
}
