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
using System.IO;
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        DataTable _dt = new DataTable();
        public void Init()
        {


            BUS_DEPARTMENT bUS_ = new BUS_DEPARTMENT();
            _dt = bUS_.LayDanhSachBoPhan();


            treeBoPhan.DataSource = _dt;
        }
        DTO_DEPARTMENT c = new DTO_DEPARTMENT();
        DTO_DEPARTMENT dTO_DEPARTMENT = new DTO_DEPARTMENT();
        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThemBoPhan();




            mainWindow.Sender(dTO_DEPARTMENT);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThemBoPhan();



            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_DEPARTMENT bus = new BUS_DEPARTMENT();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaBoPhan(c.Department_ID);
                Init();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }
        }

        private void btnNapLai_ItemClick(object sender, ItemClickEventArgs e)
        {

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
                            treeBoPhan.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeBoPhan.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeBoPhan.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeBoPhan.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeBoPhan.ExportToHtml(exportFilePath);
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

        private void btnDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void treeBoPhan_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            c.Department_ID = e.Node.GetValue("Department_ID").ToString();
            c.Department_Name = e.Node.GetValue("Department_Name").ToString();
            c.Description = e.Node.GetValue("Description").ToString();
            c.Active = bool.Parse(e.Node.GetValue("Active").ToString());
        }
    }
}