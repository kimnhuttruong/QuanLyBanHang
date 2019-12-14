﻿using System;
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
    public partial class frmBaoCaoDoanhSoTheoNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBaoCaoDoanhSoTheoNhanVien()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhSoTheoNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BUS_EMPLOYEE bus = new BUS_EMPLOYEE();
            dt = bus.BaoCaoDoanhSoNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TongMua tm = new TongMua();
                tm.Ma = dt.Rows[i]["Employee_ID"].ToString();
                tm.Ten = dt.Rows[i]["Employee_Name"].ToString();
                tm.DiaChi = dt.Rows[i]["Address"].ToString();
                tm.DienThoai = dt.Rows[i]["Mobile"].ToString();
                tm.Mua = dt.Rows[i]["TienMua"].ToString();
                tm.Ban = dt.Rows[i]["TienBan"].ToString();

                dsGroup.Add(tm);
            }

            gridBaoCaoDoanhThuNhanVien.DataSource = dsGroup;


            BUS_EMPLOYEE bus1 = new BUS_EMPLOYEE();
            DataTable dt2 = new DataTable();
            dt2 = bus1.BaoCaoDoanhSoNhanVienChiTiet();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                ChiTiet dTO_STOCK_INWARD = new ChiTiet();
                dTO_STOCK_INWARD.Ma = dt2.Rows[i]["Employee_ID"].ToString();
                dTO_STOCK_INWARD.Loai = dt2.Rows[i]["PhieuMua"].ToString();
                dTO_STOCK_INWARD.ChungTu = dt2.Rows[i]["ID"].ToString();
                dTO_STOCK_INWARD.Ngay = dt2.Rows[i]["RefDate"].ToString();
                dTO_STOCK_INWARD.MaHang = dt2.Rows[i]["Product_ID"].ToString();
                dTO_STOCK_INWARD.TenHang = dt2.Rows[i]["Product_Name"].ToString();
                dTO_STOCK_INWARD.DonVi = dt2.Rows[i]["Unit"].ToString();
                dTO_STOCK_INWARD.KhoHang = dt2.Rows[i]["Stock_Name"].ToString();
                dTO_STOCK_INWARD.SoLuong = dt2.Rows[i]["Quantity"].ToString();
                dTO_STOCK_INWARD.DonGia = dt2.Rows[i]["UnitPrice"].ToString();
                dTO_STOCK_INWARD.ThanhTien = dt2.Rows[i]["ThanhTien"].ToString();
                dTO_STOCK_INWARD.CK = dt2.Rows[i]["Amount"].ToString();
                dTO_STOCK_INWARD.ChiecKhau = dt2.Rows[i]["FAmount"].ToString();
                dTO_STOCK_INWARD.ThanhToan = dt2.Rows[i]["ThanhToan"].ToString();

                dsDetail.Add(dTO_STOCK_INWARD);
            }
        }

        private void gridView5_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.IsEmpty = !dsDetail.Any(x => x.Ma == group.Ma);
        }

        private void gridView5_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            TongMua group = view.GetRow(e.RowHandle) as TongMua;
            if (group != null)
                e.ChildList = dsDetail.Where(x => x.Ma == group.Ma).ToList();

        }
        class TongMua
        {
            public string Ma { get; set; }
            public string Ten { get; set; }
            public string DiaChi { get; set; }
            public string DienThoai { get; set; }
            public string Mua { get; set; }
            public string Ban { get; set; }
        }
        class ChiTiet
        {
            public string Ma { get; set; }
            public string Loai { get; set; }
            public string ChungTu { get; set; }
            public string Ngay { get; set; }
            public string MaHang { get; set; }
            public string TenHang { get; set; }
            public string DonVi { get; set; }
            public string KhoHang { get; set; }
            public string SoLuong { get; set; }
            public string DonGia { get; set; }
            public string ThanhTien { get; set; }
            public string CK { get; set; }
            public string ChiecKhau { get; set; }
            public string ThanhToan { get; set; }
        }
        List<TongMua> dsGroup = new List<TongMua>();
        List<ChiTiet> dsDetail = new List<ChiTiet>();
        private void gridView5_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView5_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Level1";
        }

        private void gridBaoCaoDoanhThuNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
