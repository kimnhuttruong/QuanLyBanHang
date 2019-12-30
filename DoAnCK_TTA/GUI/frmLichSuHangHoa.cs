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

namespace DoAnCK_TTA.GUI
{
    public partial class frmLichSuHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        public frmLichSuHangHoa()
        {
            InitializeComponent();
        }

        private void frmLichSuHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            BUS_SYS_USER_RULE bus4 = new BUS_SYS_USER_RULE();
            dt4= bus4.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt4.Rows[i][0].ToString())
                    {


                        //if (dt.Rows[i]["AllowAdd"].ToString() == "False")
                        //    btnThem.Enabled = false;
                        //if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                        //    btnXoa.Enabled = false;
                        //if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                        //    btnSuaChua.Enabled = false;
                        if (dt4.Rows[i]["AllowAccess"].ToString() == "False")
                            btnXem.Enabled = false;
                        //if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                        //    btnIn.Enabled = false;
                        //if (dt.Rows[i]["AllowExport"].ToString() == "False")
                        //    btnXuat.Enabled = false;
                        //if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //    btnNhap.Enabled = false;
                    }
                    //     }
                    //}
                }
            }




            List<ChungTu> listCT = new List<ChungTu>();
            DataTable dt = new DataTable();
            BUS_STOCK_INWARD bus = new BUS_STOCK_INWARD();
            dt = bus.LayThongTinBangKe();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChungTu ct = new ChungTu();
                ct.STT = (i + 1).ToString();
                ct.MaChungTu = dt.Rows[i]["ID"].ToString();
                ct.Ngay = dt.Rows[i]["RefDate"].ToString();
                ct.Loai = dt.Rows[i]["LoaiPhieu"].ToString();
                ct.ThanhTien = dt.Rows[i]["Charge"].ToString();
                ct.DienGiai = dt.Rows[i]["Description"].ToString();
                listCT.Add(ct);
            }
            gridChungTu.DataSource = listCT;
          
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
        class ChungTu
        {
            public string STT { get; set; }
            public string MaChungTu { get; set; }
            public string Ngay { get; set; }
            public string Loai { get; set; }
            public string ThanhTien { get; set; }
            public string DienGiai { get; set; }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }
    }
}
