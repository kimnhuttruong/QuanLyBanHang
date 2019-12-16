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
using DoAnCK_TTA.DTO;
using DevExpress.XtraGrid.Views.Grid;

namespace DoAnCK_TTA.GUI
{
    public partial class BangKeTongHop_BanHang : DevExpress.XtraEditors.XtraUserControl
    {
        public BangKeTongHop_BanHang()
        {
            InitializeComponent();
        }
      
        private void frmBangKeTongHop_Load(object sender, EventArgs e)
        {
           
        }
        public void load()
        {
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Xem";
            log.Created = DateTime.Now.ToString(); ;
            busLog.ThemLichSu(log);




            DataTable dt1 = new DataTable();
            BUS_STOCK_OUTWARD busnhom = new BUS_STOCK_OUTWARD();
            dt1 = busnhom.LayThongTinBangKeChiTiet();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                DTO_STOCK_OUTWARD group = new DTO_STOCK_OUTWARD();
                group.RefDate = dt1.Rows[i]["RefDate"].ToString();
                group.DeliveryDate = dt1.Rows[i]["DeliveryDate"].ToString();
                group.ID = dt1.Rows[i]["ID"].ToString();
                group.RefDate = dt1.Rows[i]["RefDate"].ToString(); ;
                group.PaymentMethod = dt1.Rows[i]["PaymentMethod"].ToString();
                group.TermID = dt1.Rows[i]["TermID"].ToString();
                group.PaymentDate = dt1.Rows[i]["PaymentDate"].ToString();
                group.Barcode = dt1.Rows[i]["Barcode"].ToString();
                group.Employee_ID = dt1.Rows[i]["Employee_ID"].ToString();
                group.Stock_ID = dt1.Rows[i]["Stock_ID"].ToString();
                group.Customer_ID = dt1.Rows[i]["Customer_ID"].ToString();
                group.CustomerName = dt1.Rows[i]["CustomerName"].ToString();
                group.CustomerAddress = dt1.Rows[i]["CustomerAddress"].ToString();
                group.Payment = dt1.Rows[i]["Payment"].ToString();
                group.Vat = dt1.Rows[i]["Vat"].ToString();
                group.VatAmount = dt1.Rows[i]["VatAmount"].ToString();
                group.Amount = dt1.Rows[i]["Amount"].ToString();
                group.FAmount = dt1.Rows[i]["FAmount"].ToString();
                group.Charge = dt1.Rows[i]["Charge"].ToString();
                group.Description = dt1.Rows[i]["Description"].ToString();
                group.Ref_OrgNo = dt1.Rows[i]["Ref_OrgNo"].ToString();
                group.RefStatus = dt1.Rows[i]["RefStatus"].ToString();

                dsGroup.Add(group);
            }

            DataTable dt2 = new DataTable();
            BUS_STOCK_OUTWARD_DETAIL bus = new BUS_STOCK_OUTWARD_DETAIL();
            dt2 = bus.LayThongTinBangKe();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DTO_STOCK_OUTWARD_DETAIL Detail = new DTO_STOCK_OUTWARD_DETAIL();
                Detail.Outward_ID = dt2.Rows[i]["Outward_ID"].ToString();
                Detail.Product_ID = dt2.Rows[i]["Product_ID"].ToString();
                Detail.ProductName = dt2.Rows[i]["Product_Name"].ToString();
                Detail.Stock_ID = dt2.Rows[i]["Stock_ID"].ToString();
                Detail.Unit = dt2.Rows[i]["Unit"].ToString();
                Detail.Quantity = (dt2.Rows[i]["Quantity"].ToString());
                Detail.UnitPrice = dt2.Rows[i]["UnitPrice"].ToString();

                dsDetail.Add(Detail);
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_STOCK_OUTWARD group = view.GetRow(e.RowHandle) as DTO_STOCK_OUTWARD;
            if (group != null)
                e.IsEmpty = !dsDetail.Any(x => x.Outward_ID == group.ID);
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_STOCK_OUTWARD group = view.GetRow(e.RowHandle) as DTO_STOCK_OUTWARD;
            if (group != null)
                e.ChildList = dsDetail.Where(x => x.Outward_ID == group.ID).ToList();

        }
        List<DTO_STOCK_OUTWARD> dsGroup = new List<DTO_STOCK_OUTWARD>();
        List<DTO_STOCK_OUTWARD_DETAIL> dsDetail = new List<DTO_STOCK_OUTWARD_DETAIL>();
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

        private void BangKeTongHop_BanHang_Load(object sender, EventArgs e)
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

                        if (dt.Rows[i]["AllowImport"].ToString() == "False")
                            btnXuat.Enabled = false;

                    }
                }
       
            }
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Xem";
            log.Created = DateTime.Now.ToString(); ;
            busLog.ThemLichSu(log);


            load();
            gridBangKeTongHop.DataSource = dsGroup;
        }
    }
}
