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
            DataTable dt4 = new DataTable();
            BUS_SYS_USER_RULE bus4 = new BUS_SYS_USER_RULE();
            dt4 = bus4.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt4.Rows[i][0].ToString())
                    {


                        //if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                        //    btnTaoMoi.Enabled = false;
                        //if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                        //    btnXoa.Enabled = false;
                        //if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                        //    btnSuaChua.Enabled = false;
                        if (dt4.Rows[i]["AllowAccess"].ToString() == "False")
                            btnXem.Enabled = false;
                        if (dt4.Rows[i]["AllowPrint"].ToString() == "False")
                            btnIn.Enabled = false;
                        if (dt4.Rows[i]["AllowExport"].ToString() == "False")
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
    }
}
