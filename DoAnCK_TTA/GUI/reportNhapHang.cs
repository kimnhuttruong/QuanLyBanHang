using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DoAnCK_TTA.DTO;
using System.Collections.Generic;

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
            txtPhieu.Value = chungtu;
            txtNgay.Value = DateTime.Now.Date+"/"+ DateTime.Now.Month + "/"+ DateTime.Now.Year;
            txtNhaCungCap.Value = KhachHang;
            txtDiaChiNCC.Value = DiaChi;
            txtGhiChu.Value = LyDo;
            TongSL.Value = tongSoLuong;
            Cong.Value = congThanhTien;
            Vat.Value = vat;
            TienVat.Value = tienVat;
            TongThanhTien.Value = tongSoTien;

            for(int i=0;i<list.Count;i++)
            {
                STT.Value = i.ToString();
                MaHang.Value = list[i].Product_ID.ToString();
                TenHang.Value = list[i].ProductName.ToString();
                DonVi.Value = list[i].Unit.ToString();
                SoLuong.Value = list[i].Quantity.ToString();
                DonGia.Value = list[i].UnitPrice.ToString();
                ThanhTien.Value= list[i].Amount.ToString();
            }

        }
    }
}
