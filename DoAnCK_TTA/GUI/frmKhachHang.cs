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
using DevExpress.XtraGrid;
using DoAnCK_TTA.DTO;
using System.IO;
using ExcelDataReader;

namespace DoAnCK_TTA.GUI
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        DataTable _dt = new DataTable();
        void formLoad()
        {
            BUS_CUSTOMER bus = new BUS_CUSTOMER();
            _dt = bus.LayDanhSachKhachHang();

            treeKhachHang.DataSource = _dt;
        }
        DTO_CUSTOMER c = new DTO_CUSTOMER();
        DTO_CUSTOMER dTO_CUSTOMER = new DTO_CUSTOMER();
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinKhachHang();
         

            dTO_CUSTOMER.Customer_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_CUSTOMER.Customer_ID = dTO_CUSTOMER.Customer_ID.Remove(0, 2);

            dTO_CUSTOMER.Customer_ID = (int.Parse(dTO_CUSTOMER.Customer_ID) + 1).ToString("000000");
            dTO_CUSTOMER.Customer_ID = "KH" + dTO_CUSTOMER.Customer_ID.ToString();

            mainWindow.Sender(dTO_CUSTOMER) ;    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinKhachHang();

            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            BUS_CUSTOMER bus = new BUS_CUSTOMER();
            DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaKhachHang(c.Customer_ID);
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
                            treeKhachHang.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeKhachHang.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeKhachHang.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeKhachHang.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeKhachHang.ExportToHtml(exportFilePath);
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

        private void btnNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx";
            openFileDialog1.Title = "Select an excel file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string txtPath = openFileDialog1.FileName;
                FileStream stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet result = excelReader.AsDataSet();
                DataTable dt = result.Tables[0];

                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    BUS_CUSTOMER bus = new BUS_CUSTOMER();
                    DTO_CUSTOMER c = new DTO_CUSTOMER();
                    c.Customer_ID = dt.Rows[i][0].ToString();
                    c.OrderID = 0.ToString();
                    c.CustomerName = dt.Rows[i][1].ToString();
                   
                    c.Customer_Group_ID = dt.Rows[i][20].ToString();
                    c.CustomerAddress = dt.Rows[i][3].ToString();
                   // c.Birthday = dt.Rows[i]["Birthday"].ToString();
                    c.Barcode = dt.Rows[i][15].ToString();
                    c.Tax = dt.Rows[i][4].ToString();
                    c.Tel = dt.Rows[i][5].ToString();
                    c.Fax = dt.Rows[i][8].ToString();
                    c.Email = dt.Rows[i][7].ToString();
                    c.Mobile = dt.Rows[i][6].ToString();
                    c.Website = dt.Rows[i][14].ToString();
                    c.Contact = dt.Rows[i][11].ToString();
                    c.Position = dt.Rows[i][12].ToString();
                    c.NickYM = dt.Rows[i][18].ToString();
                    c.NickSky = dt.Rows[i][19].ToString();
                    c.Area = dt.Rows[i][20].ToString();
                    c.District = dt.Rows[i][20].ToString();
                    c.Contry = dt.Rows[i][20].ToString();
                    c.City = dt.Rows[i][20].ToString();
                    c.BankAccount = dt.Rows[i][9].ToString();
                    c.BankName = dt.Rows[i][10].ToString();
                    c.CreditLimit = dt.Rows[i][16].ToString();
                  //      c.Discount = dt.Rows[i]["Discount"].ToString();
                   // c.IsDebt = dt.Rows[i]["IsDebt"].ToString();
                 //   c.IsDebtDetail = dt.Rows[i]["IsDebtDetail"].ToString();
                  //  c.IsProvider = dt.Rows[i]["IsProvider"].ToString();
                    c.Description = dt.Rows[i][13].ToString();

                    c.Active = true;
                    bus.ThemKhachHang(c);
                }
            }
        }

        private void bntDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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
                    //     }
                    //}
                }
            }
                formLoad();
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
        private void treeKhachHang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                c.Customer_ID = row["Customer_ID"].ToString();
                c.OrderID = row["OrderID"].ToString();
                c.CustomerName = row["CustomerName"].ToString();
                c.Customer_Type_ID = row["Customer_Type_ID"].ToString();
                c.Customer_Group_ID = row["Customer_Group_ID"].ToString();
                c.CustomerAddress = row["CustomerAddress"].ToString();
                c.Birthday = row["Birthday"].ToString();
                c.Barcode = row["Barcode"].ToString();
                c.Tax = row["Tax"].ToString();
                c.Tel = row["Tel"].ToString();
                c.Fax = row["Fax"].ToString();
                c.Email = row["Email"].ToString();
                c.Mobile = row["Mobile"].ToString();
                c.Website = row["Website"].ToString();
                c.Contact = row["Contact"].ToString();
                c.Position = row["Position"].ToString();
                c.NickYM = row["NickYM"].ToString();
                c.NickSky = row["NickSky"].ToString();
                c.Area = row["Area"].ToString();
                c.District = row["District"].ToString();
                c.Contry = row["Contry"].ToString();
                c.City = row["City"].ToString();
                c.BankAccount = row["BankAccount"].ToString();
                c.BankName = row["BankName"].ToString();
                c.CreditLimit = row["CreditLimit"].ToString();
                c.Discount = row["Discount"].ToString();
                c.IsDebt = row["IsDebt"].ToString();
                c.IsDebtDetail = row["IsDebtDetail"].ToString();
                c.IsProvider = row["IsProvider"].ToString();
                c.Description = row["Description"].ToString();
                if (row["Active"].ToString().ToLower() != "")
                    c.Active = bool.Parse(row["Active"].ToString().ToLower());
            }
        }
    }
}