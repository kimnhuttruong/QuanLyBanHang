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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        DataTable _dt = new DataTable();
        void formLoad()
        {
            BUS_PROVIDER bus = new BUS_PROVIDER();
            _dt = bus.LayDanhSachNhaCungCap();

            treeNhaCungCap.DataSource = _dt;
        }
        DTO_PROVIDER c = new DTO_PROVIDER();
        DTO_PROVIDER dTO_PROVIDER = new DTO_PROVIDER();
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            c.Customer_ID = e.Node.GetValue("Customer_ID").ToString();
            c.OrderID = e.Node.GetValue("OrderID").ToString();
            c.CustomerName = e.Node.GetValue("CustomerName").ToString();
            c.Customer_Type_ID = e.Node.GetValue("Customer_Type_ID").ToString();
            c.Customer_Group_ID = e.Node.GetValue("Customer_Group_ID").ToString();
            c.CustomerAddress = e.Node.GetValue("CustomerAddress").ToString();
            c.Birthday = e.Node.GetValue("Birthday").ToString();
            c.Barcode = e.Node.GetValue("Barcode").ToString();
            c.Tax = e.Node.GetValue("Tax").ToString();
            c.Tel = e.Node.GetValue("Tel").ToString();
            c.Fax = e.Node.GetValue("Fax").ToString();
            c.Email = e.Node.GetValue("Email").ToString();
            c.Mobile = e.Node.GetValue("Mobile").ToString();
            c.Website = e.Node.GetValue("Website").ToString();
            c.Contact = e.Node.GetValue("Contact").ToString();
            c.Position = e.Node.GetValue("Position").ToString();
            c.NickYM = e.Node.GetValue("NickYM").ToString();
            c.NickSky = e.Node.GetValue("NickSky").ToString();
            c.Area = e.Node.GetValue("Area").ToString();
            c.District = e.Node.GetValue("District").ToString();
            c.Contry = e.Node.GetValue("Contry").ToString();
            c.City = e.Node.GetValue("City").ToString();
            c.BankAccount = e.Node.GetValue("BankAccount").ToString();
            c.BankName = e.Node.GetValue("BankName").ToString();
            c.CreditLimit = e.Node.GetValue("CreditLimit").ToString();
            c.Discount = e.Node.GetValue("Discount").ToString();
            c.IsDebt = e.Node.GetValue("IsDebt").ToString();
            c.IsDebtDetail = e.Node.GetValue("IsDebtDetail").ToString();
            c.IsProvider = e.Node.GetValue("IsProvider").ToString();
            c.Description = e.Node.GetValue("Description").ToString();
            c.Active = bool.Parse(e.Node.GetValue("Active").ToString());
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinNhaCungCap();


            dTO_PROVIDER.Customer_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_PROVIDER.Customer_ID = dTO_PROVIDER.Customer_ID.Remove(0, 3);

            dTO_PROVIDER.Customer_ID = (int.Parse(dTO_PROVIDER.Customer_ID) + 1).ToString("00000");
            dTO_PROVIDER.Customer_ID = "NCC" + dTO_PROVIDER.Customer_ID.ToString();

            mainWindow.Sender(dTO_PROVIDER);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void btnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinNhaCungCap();

            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUS_PROVIDER bus = new BUS_PROVIDER();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaNhaCungCap(c.Customer_ID);
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
                            treeNhaCungCap.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeNhaCungCap.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeNhaCungCap.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeNhaCungCap.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeNhaCungCap.ExportToHtml(exportFilePath);
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

        private void btnNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
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
    }
}