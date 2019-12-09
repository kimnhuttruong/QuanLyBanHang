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
using DoAnCK_TTA.BUS;
using System.IO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmKhuVuc : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        void formLoad()
        {
            BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            _dt = bus.LayDanhSachKhuVuc();

            gridKhuVuc.DataSource = _dt;
        }
        string _id = "";
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinKhuVuc();


            _id = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            _id = _id.Remove(0, 2);

            _id = (int.Parse(_id) + 1).ToString("000000");
            _id = "KV" + _id.ToString();

            mainWindow.Sender(_id,"","",true);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void gridKhuVuc_Click(object sender, EventArgs e)
        {
          
        }
        DataTable _dt = new DataTable();
        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            formLoad();
        }
        string ten, mota;
        bool check;

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                _id = row[0].ToString();
               
            }
              BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            DialogResult dialogResult = MessageBox.Show( "Bạn có muốn xóa không?","Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaKhuVuc(_id);
                formLoad();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }
           

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formLoad();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                            gridKhuVuc.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridKhuVuc.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridKhuVuc.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridKhuVuc.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridKhuVuc.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridKhuVuc.ExportToMht(exportFilePath);
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

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinKhuVuc();

           
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                _id = row[0].ToString();
                ten = row[1].ToString();
                mota = row[2].ToString();

                if (row[2].ToString().ToLower() == "1")
                    check = true;
                else
                    check = false;
            }


            mainWindow.Sender(_id, ten, mota, check);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }
    }
}