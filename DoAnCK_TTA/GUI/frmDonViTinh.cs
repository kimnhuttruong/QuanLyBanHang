using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmDonViTinh1_Load(object sender, EventArgs e)
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
                            btnThem.Enabled = false;
                        if (dt.Rows[i]["AllowDelete"].ToString() == "False")
                            btnXoa.Enabled = false;
                        if (dt.Rows[i]["AllowEdit"].ToString() == "False")
                            btnSuaChua.Enabled = false;
                        //if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                        //    btnXem.Enabled = false;
                        //if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                        //    btnIn.Enabled = false;
                        if (dt.Rows[i]["AllowExport"].ToString() == "False")
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
                Init();
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
        DataTable _dt = new DataTable();
        public void Init()
        {


            BUS_UNIT bUS_ = new BUS_UNIT();
            _dt = bUS_.LayDanhSachDonViTinh();
            //List<DTO_UNIT> dsUnit = new List<DTO_UNIT>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DTO_UNIT unit = new DTO_UNIT();
            //    unit.Unit_ID = dt.Rows[i]["Unit_ID"].ToString();
            //    unit.Unit_Name = dt.Rows[i]["Unit_Name"].ToString();
            //    unit.Description = dt.Rows[i]["Description"].ToString();
            //    unit.Active = bool.Parse(dt.Rows[i]["Active"].ToString());

            //    dsUnit.Add(unit);
            //}

            treeDonViTinh.DataSource = _dt;
        }
        DTO_UNIT c = new DTO_UNIT();
        DTO_UNIT dTO_UNIT = new DTO_UNIT();
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new FrmThongTinDonViTinh();


            dTO_UNIT.Unit_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_UNIT.Unit_ID = dTO_UNIT.Unit_ID.Remove(0, 2);

            dTO_UNIT.Unit_ID = (int.Parse(dTO_UNIT.Unit_ID) + 1).ToString();
            dTO_UNIT.Unit_ID = "DV" + dTO_UNIT.Unit_ID.ToString();

            mainWindow.Sender(dTO_UNIT);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new FrmThongTinDonViTinh();



            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaKhuVuc(c.Unit_ID);
                Init();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Init();
        }

        private void treeDonViTinh_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            c.Unit_ID = e.Node.GetValue("Unit_ID").ToString();
            c.Unit_Name = e.Node.GetValue("Unit_Name").ToString();
            c.Description = e.Node.GetValue("Description").ToString();
            c.Active = bool.Parse(e.Node.GetValue("Active").ToString());
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            treeDonViTinh.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeDonViTinh.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeDonViTinh.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeDonViTinh.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeDonViTinh.ExportToHtml(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            log.Action_Name = "Xuất";
            busLog.ThemLichSu(log);

        }
    }
}