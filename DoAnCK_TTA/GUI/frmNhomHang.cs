using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;
using System.IO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomHang()
        {
            InitializeComponent();
        }
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinNhomHang();


            dTO_PRODUCT_GROUP.ProductGroup_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_PRODUCT_GROUP.ProductGroup_ID = dTO_PRODUCT_GROUP.ProductGroup_ID.Remove(0, 2);

            dTO_PRODUCT_GROUP.ProductGroup_ID = (int.Parse(dTO_PRODUCT_GROUP.ProductGroup_ID) + 1).ToString("000000");
            dTO_PRODUCT_GROUP.ProductGroup_ID = "NH" + dTO_PRODUCT_GROUP.ProductGroup_ID.ToString();

            mainWindow.Sender(dTO_PRODUCT_GROUP);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhomHang_Load(object sender, EventArgs e)
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
                        if (dt.Rows[i]["AllowImport"].ToString() == "False")
                            btnNhap.Enabled = false;
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
         

            BUS_PRODUCT_GROUP bUS_ = new BUS_PRODUCT_GROUP();
            _dt = bUS_.LayDanhSachNhomHang();
            //List<DTO_PRODUCT_GROUP> ds = new List<DTO_PRODUCT_GROUP>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DTO_PRODUCT_GROUP pro_g = new DTO_PRODUCT_GROUP();
            //    pro_g.ProductGroup_ID = dt.Rows[i]["ProductGroup_ID"].ToString();
            //    pro_g.ProductGroup_Name = dt.Rows[i]["ProductGroup_Name"].ToString();
            //    pro_g.Description = dt.Rows[i]["Description"].ToString();
            //    pro_g.Active = bool.Parse(dt.Rows[i]["Active"].ToString());

            //    ds.Add(pro_g);
            //}

            treeNhomHang.DataSource = _dt;
        }
        DTO_PRODUCT_GROUP c = new DTO_PRODUCT_GROUP();
        DTO_PRODUCT_GROUP dTO_PRODUCT_GROUP = new DTO_PRODUCT_GROUP();
        private void btnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinNhomHang();



            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_PRODUCT_GROUP bus = new BUS_PRODUCT_GROUP();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaNhomHang(c.ProductGroup_ID);
                Init();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }
        }

        private void btnNapLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            Init();
        }

        private void btnXuat_ItemClick(object sender, ItemClickEventArgs e)
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
                            treeNhomHang.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeNhomHang.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeNhomHang.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeNhomHang.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeNhomHang.ExportToHtml(exportFilePath);
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
        }
        private void btnNhap_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void treeNhomHang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            c.ProductGroup_ID = e.Node.GetValue("ProductGroup_ID").ToString();
            c.ProductGroup_Name = e.Node.GetValue("ProductGroup_Name").ToString();
            c.Description = e.Node.GetValue("Description").ToString();
            c.Active = bool.Parse(e.Node.GetValue("Active").ToString());
        }
    }
}