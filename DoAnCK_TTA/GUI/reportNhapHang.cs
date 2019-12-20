using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DoAnCK_TTA.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnCK_TTA.GUI
{
    public partial class reportNhapHang : DevExpress.XtraReports.UI.XtraReport
    {
        public reportNhapHang()
        {
            InitializeComponent();
        }
        public void InitData( string tenCT, string diaChiCT, string tel,string logo, string fax, string chungtu, string KhachHang, string DiaChi, string LyDo, string tongSoTien,  string tongSoLuong, string congThanhTien, string vat,string tienVat,List<DTO_STOCK_INWARD_DETAIL> list)
        {
            
            picLogo.ImageUrl = logo;
            picLogo.Sizing = ImageSizeMode.StretchImage;
            txtTenCongTy.Value = tenCT;
            txtDiaChi.Value = diaChiCT;
            txtDienThoai.Value = tel;
            txtFax.Value = fax;
            txtPhieu.Text = chungtu;
            txtNgay.Text = DateTime.Today.Day+"/"+ DateTime.Today.Month + "/"+ DateTime.Today.Year;
            txtNhaCungCap.Value = KhachHang;
            txtDiaChiNCC.Value = DiaChi;
            txtGhiChu.Value = LyDo;
            TongSL.Value = tongSoLuong;
            Cong.Value = congThanhTien;
            Vat.Value = vat;
            TienVat.Value = tienVat;
            TongThanhTien.Value = tongSoTien;

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("MaHang");
            dt.Columns.Add("TenHang");
            dt.Columns.Add("DonVi");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            for (int i=0;i<list.Count;i++)
            {

                //dt.Row.Cells.AddRange(i.ToString())
                dt.Rows.Add((i+1).ToString(),
                 /* MaHang.Value = */list[i].Product_ID.ToString(),
                 /* TenHang.Value =*/ list[i].ProductName.ToString(),
                 /* DonVi.Value = */list[i].Unit.ToString(),
                 /* SoLuong.Value =*/ list[i].Quantity.ToString(),
                 /* DonGia.Value =*/ list[i].UnitPrice.ToString(),
                  /*ThanhTien.Value =*/ float.Parse(list[i].Quantity.ToString()) * float.Parse(list[i].UnitPrice.ToString()));
            }
            dataTable.Report.DataSource = dt;
        }
    }
}
