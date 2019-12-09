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
    public partial class frmTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTyGia()
        {
            InitializeComponent();
        }
        DataTable _dt = new DataTable();
        public void Init()
        {


            BUS_CURRENCY bUS_ = new BUS_CURRENCY();
            _dt = bUS_.LayDanhSachTyGia();
           

            treeTyGia.DataSource = _dt;
        }
        DTO_CURRENCY c = new DTO_CURRENCY();
        DTO_CURRENCY dTO_CURRENCY = new DTO_CURRENCY();
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinTyGia();


           

            mainWindow.Sender(dTO_CURRENCY);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinTyGia();



            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_CURRENCY bus = new BUS_CURRENCY();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaTyGia(c.Currency_ID);
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
                            treeTyGia.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeTyGia.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeTyGia.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeTyGia.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeTyGia.ExportToHtml(exportFilePath);
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

        private void treeTyGia_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            c.Currency_ID = e.Node.GetValue("Currency_ID").ToString();
            c.CurrencyName = e.Node.GetValue("CurrencyName").ToString();
            c.Exchange = e.Node.GetValue("Exchange").ToString();
            c.Active = bool.Parse(e.Node.GetValue("Active").ToString());
        }

        private void frmTyGia_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}