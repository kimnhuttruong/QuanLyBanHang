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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        DataTable _dt = new DataTable();
        void formLoad()
        {
            BUS_PRODUCT bus = new BUS_PRODUCT();
            _dt = bus.LayDanhSachHangHoa();

            treeHangHoa.DataSource = _dt;
        }
        DTO_PRODUCT c = new DTO_PRODUCT();
        DTO_PRODUCT dTO_PRODUCT = new DTO_PRODUCT();
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {

            var mainWindow = new frmThongTinHangHoa();


            dTO_PRODUCT.Product_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_PRODUCT.Product_ID = dTO_PRODUCT.Product_ID.Remove(0, 3);

            dTO_PRODUCT.Product_ID = (int.Parse(dTO_PRODUCT.Product_ID) + 1).ToString("000000");
            dTO_PRODUCT.Product_ID = "HH" + dTO_PRODUCT.Product_ID.ToString();

            mainWindow.Sender(dTO_PRODUCT);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void treeHangHoa_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
          
        }

        private void btnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinHangHoa();

            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);

                c.Product_ID = row["Product_ID"].ToString();
                c.Product_Name = row["Product_Name"].ToString();
                c.Product_NameEN = row["Product_NameEN"].ToString();
                c.Product_Type_ID = row["Product_Type_ID"].ToString();
                c.Manufacturer_ID = row["Manufacturer_ID"].ToString();
                c.Model_ID = row["Model_ID"].ToString();
                c.Product_Group_ID = row["Product_Group_ID"].ToString();
                c.Provider_ID = row["Provider_ID"].ToString();
                c.Origin = row["Origin"].ToString();
                c.Barcode = row["Barcode"].ToString();
                c.Unit = row["Unit"].ToString();
                c.UnitConvert = row["UnitConvert"].ToString();
                c.UnitRate = row["UnitRate"].ToString();
                c.Org_Price = row["Org_Price"].ToString();
                c.Sale_Price = row["Sale_Price"].ToString();
                c.Retail_Price = row["Retail_Price"].ToString();
                c.Quantity = row["Quantity"].ToString();
                c.CurrentCost = row["CurrentCost"].ToString();
                c.AverageCost = row["AverageCost"].ToString();
                c.Warranty = row["Warranty"].ToString();
                c.VAT_ID = row["VAT_ID"].ToString();
                c.ImportTax_ID = row["ImportTax_ID"].ToString();
                c.ExportTax_ID = row["ExportTax_ID"].ToString();
                c.LuxuryTax_ID = row["LuxuryTax_ID"].ToString();
                c.Customer_ID = row["Customer_ID"].ToString();
                c.Customer_Name = row["Customer_Name"].ToString();
                c.CostMethod = row["CostMethod"].ToString();
                c.MinStock = row["MinStock"].ToString();
                c.MaxStock = row["MaxStock"].ToString();
                c.Discount = row["Discount"].ToString();
                c.Commission = row["Commission"].ToString();
                c.Description = row["Description"].ToString();
                c.Color = row["Color"].ToString();
                c.Expiry = row["Expiry"].ToString();
                c.LimitOrders = row["LimitOrders"].ToString();
                c.ExpiryValue = row["ExpiryValue"].ToString();
                c.Batch = row["Batch"].ToString();
                c.Depth = row["Depth"].ToString();
                c.Height = row["Height"].ToString();
                c.Width = row["Width"].ToString();
                c.Thickness = row["Thickness"].ToString();
                c.Size = row["Size"].ToString();
                c.Photo = row["Photo"].ToString();
                c.Currency_ID = row["Currency_ID"].ToString();
                c.ExchangeRate = row["ExchangeRate"].ToString();
                c.Stock_ID = row["Stock_ID"].ToString();
                c.UserID = row["UserID"].ToString();
                c.Serial = row["Serial"].ToString();

                if (row["Active"].ToString().ToLower() == "1")
                    c.Active = true;
                else
                    c.Active = false;
            }





            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            formLoad();
        }

        private void btnNapLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            formLoad();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_PRODUCT bus = new BUS_PRODUCT();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaHangHoa(c.Product_ID);
                formLoad();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }
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
                            treeHangHoa.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeHangHoa.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeHangHoa.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeHangHoa.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeHangHoa.ExportToHtml(exportFilePath);
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

        private void btnDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
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
                        if (dt.Rows[i]["AllowImport"].ToString() == "False")
                                btnNhap.Enabled = false;
                            //}
                            //     }
                            //}
                        }
                }
            }
            formLoad();
        }

        private void treeHangHoa_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            //c.Product_ID =  treeHangHoa.FocusedView.SourceRow   row["Product_ID"].ToString();
            //c.Product_Name = row["Product_Name"].ToString();
            //c.Product_NameEN = row["Product_NameEN"].ToString();
            //c.Product_Type_ID = row["Product_Type_ID"].ToString();
            //c.Manufacturer_ID = row["Manufacturer_ID"].ToString();
            //c.Model_ID = row["Model_ID"].ToString();
            //c.Product_Group_ID = row["Product_Group_ID"].ToString();
            //c.Provider_ID = row["Provider_ID"].ToString();
            //c.Origin = row["Origin"].ToString();
            //c.Barcode = row["Barcode"].ToString();
            //c.Unit = row["Unit"].ToString();
            //c.UnitConvert = row["UnitConvert"].ToString();
            //c.UnitRate = row["UnitRate"].ToString();
            //c.Org_Price = row["Org_Price"].ToString();
            //c.Sale_Price = row["Sale_Price"].ToString();
            //c.Retail_Price = row["Retail_Price"].ToString();
            //c.Quantity = row["Quantity"].ToString();
            //c.CurrentCost = row["CurrentCost"].ToString();
            //c.AverageCost = row["AverageCost"].ToString();
            //c.Warranty = row["Warranty"].ToString();
            //c.VAT_ID = row["VAT_ID"].ToString();
            //c.ImportTax_ID = row["ImportTax_ID"].ToString();
            //c.ExportTax_ID = row["ExportTax_ID"].ToString();
            //c.LuxuryTax_ID = row["LuxuryTax_ID"].ToString();
            //c.Customer_ID = row["Customer_ID"].ToString();
            //c.Customer_Name = row["Customer_Name"].ToString();
            //c.CostMethod = row["CostMethod"].ToString();
            //c.MinStock = row["MinStock"].ToString();
            //c.MaxStock = row["MaxStock"].ToString();
            //c.Discount = row["Discount"].ToString();
            //c.Commission = row["Commission"].ToString();
            //c.Description = row["Description"].ToString();
            //c.Color = row["Color"].ToString();
            //c.Expiry = row["Expiry"].ToString();
            //c.LimitOrders = row["LimitOrders"].ToString();
            //c.ExpiryValue = row["ExpiryValue"].ToString();
            //c.Batch = row["Batch"].ToString();
            //c.Depth = row["Depth"].ToString();
            //c.Height = row["Height"].ToString();
            //c.Width = row["Width"].ToString();
            //c.Thickness = row["Thickness"].ToString();
            //c.Size = row["Size"].ToString();
            //c.Photo = row["Photo"].ToString();
            //c.Currency_ID = row["Currency_ID"].ToString();
            //c.ExchangeRate = row["ExchangeRate"].ToString();
            //c.Stock_ID = row["Stock_ID"].ToString();
            //c.UserID = row["UserID"].ToString();
            //c.Serial = row["Serial"].ToString();
            //c.Active = bool.Parse(row["Active"].ToString());
        }
    }
}