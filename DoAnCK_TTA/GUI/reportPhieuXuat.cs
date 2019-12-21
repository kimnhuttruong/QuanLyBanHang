using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraPrinting;
using System.Collections.Generic;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class reportPhieuXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public reportPhieuXuat()
        {
            InitializeComponent();
        }
        public void InitData(string ck, string tienck,string dienthoai,string ngaygiao,string tenCT, string diaChiCT, string tel, string logo, string fax, string chungtu, string KhachHang, string DiaChi, string LyDo, string tongSoTien, string tongSoLuong, string congThanhTien, string vat, string tienVat, List<DTO_STOCK_OUTWARD_DETAIL> list)
        {

            picLogo.ImageUrl = logo;
            picLogo.Sizing = ImageSizeMode.StretchImage;
            txtTenCongTy.Text = tenCT;
            txtDiaChi.Text = diaChiCT;
            txtDienThoai.Text = tel;
            txtFax.Text = fax;
            txtPhieu.Text = chungtu;
            txtNgay.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
            txtKhachHang.Text = KhachHang;
            txtDiaChiKH.Text = DiaChi;
            txtGhiChu.Text = LyDo;
            TongSL.Text = tongSoLuong;
            Cong.Text = congThanhTien;
            Vat.Text = vat;
            TienVat.Text = tienVat;
            TongThanhTien.Text = tongSoTien;
            txtDienThoaiKH.Text = dienthoai;
            CK.Text = ck;
            TienCK.Text = tienck;
            txtNgayGiao.Text = ngaygiao;

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("MaHang");
            dt.Columns.Add("TenHang");
            dt.Columns.Add("DonVi");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            dt.Columns.Add("ChietKhau");
            dt.Columns.Add("ThanhToan");
            for (int i = 0; i < list.Count; i++)
            {

                //dt.Row.Cells.AddRange(i.ToString())
                dt.Rows.Add((i + 1).ToString(),
                 /* MaHang.Value = */list[i].Product_ID.ToString(),
                 /* TenHang.Value =*/ list[i].ProductName.ToString(),
                 /* DonVi.Value = */list[i].Unit.ToString(),
                 /* SoLuong.Value =*/ list[i].Quantity.ToString(),
                 /* DonGia.Value =*/ list[i].UnitPrice.ToString(),
                  /*ThanhTien.Value =*/ float.Parse(list[i].Quantity.ToString()) * float.Parse(list[i].UnitPrice.ToString()),
                  list[i].DiscountRate,list[i].Charge
                  
                  
                  );
            }
            dataTable.Report.DataSource = dt;
        }
    }
}
