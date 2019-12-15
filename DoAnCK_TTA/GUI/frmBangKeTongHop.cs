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
    public partial class frmBangKeTongHop : DevExpress.XtraEditors.XtraUserControl 
    {
        public frmBangKeTongHop()
        {
            InitializeComponent();
        }

        private void frmBangKeTongHop_Load(object sender, EventArgs e)
        {
            load();
            gridBangKeTongHop.DataSource = dsGroup;
        }
        public void load ()
        {
            DataTable dt1 = new DataTable();
            BUS_STOCK_INWARD busnhom = new BUS_STOCK_INWARD();
            dt1 = busnhom.LayThongTinBangKeChiTiet();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                DTO_STOCK_INWARD group = new DTO_STOCK_INWARD();
                group.RefDate = dt1.Rows[i]["RefDate"].ToString();
                group.Ref_OrgNo = dt1.Rows[i]["Ref_OrgNo"].ToString();
                group.RefStatus = dt1.Rows[i]["RefStatus"].ToString();
                group.CustomerName = (dt1.Rows[i]["CustomerName"].ToString());
                group.Amount = dt1.Rows[i]["Amount"].ToString();
                group.Vat = dt1.Rows[i]["Vat"].ToString();
                group.Amount = dt1.Rows[i]["Amount"].ToString();
                group.ID = dt1.Rows[i]["ID"].ToString();
                group.Charge = dt1.Rows[i]["Charge"].ToString();
                group.Description = (dt1.Rows[i]["Description"].ToString());

                dsGroup.Add(group);
            }

            DataTable dt2 = new DataTable();
            BUS_STOCK_INWARD_DETAIL bus = new BUS_STOCK_INWARD_DETAIL();
            dt2 = bus.LayThongTinBangKe();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {

                DTO_STOCK_INWARD_DETAIL Detail = new DTO_STOCK_INWARD_DETAIL();
                Detail.Inward_ID = dt2.Rows[i]["Inward_ID"].ToString();
                Detail.Product_ID = dt2.Rows[i]["Product_ID"].ToString();
                Detail.ProductName = dt2.Rows[i]["Product_Name"].ToString();
                Detail.Stock_ID = dt2.Rows[i]["Stock_ID"].ToString();
                Detail.Unit = dt2.Rows[i]["Unit"].ToString();
                Detail.Quantity = (dt2.Rows[i]["Quantity"].ToString());
                Detail.UnitPrice = dt2.Rows[i]["UnitPrice"].ToString();
                Detail.Amount = dt2.Rows[i]["Amount"].ToString();
                
                dsDetail.Add(Detail);
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_STOCK_INWARD group = view.GetRow(e.RowHandle) as DTO_STOCK_INWARD;
            if (group != null)
                e.IsEmpty = !dsDetail.Any(x => x.Inward_ID == group.ID);
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_STOCK_INWARD group = view.GetRow(e.RowHandle) as DTO_STOCK_INWARD;
            if (group != null)
                e.ChildList = dsDetail.Where(x => x.Inward_ID == group.ID).ToList();

        }
        List<DTO_STOCK_INWARD> dsGroup = new List<DTO_STOCK_INWARD>();
        List<DTO_STOCK_INWARD_DETAIL> dsDetail = new List<DTO_STOCK_INWARD_DETAIL>();
        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Level1";
        }

        private void gridBangKeTongHop_Click(object sender, EventArgs e)
        {

        }
    }
}
