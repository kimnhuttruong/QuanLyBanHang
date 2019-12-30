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
using ExcelDataReader;
using System.IO;
using DoAnCK_TTA.BUS;
using DoAnCK_TTA.DTO;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Layout.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraCharts;
using DevExpress.ClipboardSource.SpreadsheetML;
using Excel = Microsoft.Office.Interop.Excel;

namespace DoAnCK_TTA.GUI
{
    public partial class frmNhapFile : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapFile()
        {
            InitializeComponent();
        }
      
        DataSet result;
        DataTable dt = new DataTable();
        private void txtDuongDan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx";
            openFileDialog1.Title = "Select an excel file";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = openFileDialog1.FileName;
                string txtPath = openFileDialog1.FileName;
                FileStream stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                result = excelReader.AsDataSet();
              
                var sheets = result.Tables
                                        .OfType<DataTable>()
                                        .Select(c => c.TableName)
                                        .ToArray();
                listSheet.DataSource = sheets;
            }
            

        }

        private void completionWizardPage1_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl_FinishClick(object sender, CancelEventArgs e)
        {
            if (rbKhachHang.Checked)
            {
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
            if (rbNhaCungCap.Checked)
            {
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    BUS_PROVIDER bus = new BUS_PROVIDER();
                    DTO_PROVIDER c = new DTO_PROVIDER();
                    c.Customer_ID = dt.Rows[i][0].ToString();
                    c.OrderID = 0.ToString();
                    c.CustomerName = dt.Rows[i][1].ToString();
                    c.Customer_Type_ID = 0.ToString();
                    c.Customer_Group_ID = dt.Rows[i][17].ToString();
                    c.CustomerAddress = dt.Rows[i][2].ToString();
                    //  c.Birthday = dt.Rows[i][0].ToString();
                    c.Barcode = dt.Rows[i][14].ToString();
                    c.Tax = dt.Rows[i][3].ToString();
                    c.Tel = dt.Rows[i][4].ToString();
                    c.Fax = dt.Rows[i][5].ToString();
                    c.Email = dt.Rows[i][6].ToString();
                    c.Mobile = dt.Rows[i][7].ToString();
                    c.Website = dt.Rows[i][12].ToString();
                    c.Contact = dt.Rows[i][10].ToString();
                    c.Position = dt.Rows[i][11].ToString();
                    //  c.NickYM = dt.Rows[i][0].ToString();
                    //    c.NickSky = dt.Rows[i][0].ToString();
                    c.Area = dt.Rows[i][17].ToString();
                    //   c.District = dt.Rows[i][0].ToString();
                    //   c.Contry = dt.Rows[i][0].ToString();
                    //   c.City = dt.Rows[i][0].ToString();
                    c.BankAccount = dt.Rows[i][9].ToString();
                    c.BankName = dt.Rows[i][8].ToString();
                    c.CreditLimit = dt.Rows[i][16].ToString();
                    //c.Discount = dt.Rows[i][0].ToString();
                    //c.IsDebt = dt.Rows[i][0].ToString();
                    //c.IsDebtDetail = dt.Rows[i][0].ToString();
                    //c.IsProvider = dt.Rows[i][0].ToString();
                    c.Description = dt.Rows[i][13].ToString();
                    c.Active = true;

                    bus.ThemNhaCungCap(c);
                }
            }
            if (rbHangHoa.Checked)
            {
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    BUS_PRODUCT bus = new BUS_PRODUCT();
                    DTO_PRODUCT c = new DTO_PRODUCT();
                    BUS_INVENTORY_DETAIL iNVENTORY_DETAIL = new BUS_INVENTORY_DETAIL();
                    c.Product_ID = dt.Rows[i][0].ToString();
                    c.Product_Name = dt.Rows[i][1].ToString();
                    c.Origin = 1.ToString();
                    c.MinStock = dt.Rows[i][5].ToString();
                    c.CurrentCost = dt.Rows[i][10].ToString();
                    c.Barcode = dt.Rows[i][9].ToString();
                    c.Org_Price = dt.Rows[i][4].ToString();
                    c.Sale_Price = dt.Rows[i][11].ToString();
                    c.Retail_Price = dt.Rows[i][10].ToString();
                    BUS_STOCK s = new BUS_STOCK();
                    DataTable bangKho = s.LayThongTinKhoHang();
                    string ma = "MaNhapSai";

                    for (int k = 0; k < bangKho.Rows.Count; k++)
                    {
                        if (dt.Rows[i][3].ToString() == bangKho.Rows[k][1].ToString())
                        {
                            ma = bangKho.Rows[k][0].ToString();
                            break;
                        }
                    }
                    c.Stock_ID = ma;
                    BUS_PRODUCT_GROUP g = new BUS_PRODUCT_GROUP();
                    DataTable bangNhomHang = g.LayDanhSachNhomHang();
                    ma = "MaNhapSai";

                    for (int k = 0; k < bangNhomHang.Rows.Count; k++)
                    {
                        if (dt.Rows[i][7].ToString() == bangNhomHang.Rows[k][1].ToString())
                        {
                            ma = bangNhomHang.Rows[k][0].ToString();
                            break;
                        }
                    }
                    c.Product_Group_ID = ma;
                    BUS_UNIT u = new BUS_UNIT();
                    DataTable bangUNIT = u.LayDanhSachDonViTinh();
                    ma = "MaNhapSai";

                    for (int k = 0; k < bangUNIT.Rows.Count; k++)
                    {
                        if (dt.Rows[i][2].ToString() == bangUNIT.Rows[k][1].ToString())
                        {
                            ma = bangUNIT.Rows[k][0].ToString();
                            break;
                        }
                    }
                    c.Unit = ma;
                    BUS_PROVIDER p = new BUS_PROVIDER();
                    DataTable bangPROVIDER = p.LayDanhSachNhaCungCap();
                    ma = "MaNhapSai";

                    for (int k = 0; k < bangPROVIDER.Rows.Count; k++)
                    {
                        if (dt.Rows[i][6].ToString() == bangPROVIDER.Rows[k][1].ToString())
                        {
                            ma = bangPROVIDER.Rows[k][0].ToString();
                            break;
                        }
                    }
                    c.Provider_ID = ma;


                    c.Active = true;

                    int kt = bus.ThemHangHoa(c);

                }
            }
        }

       
        private void wizardControl_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
           
        }
        DevExpress.XtraWizard.WizardButton btnNext;
        private void wizardControl_CustomizeCommandButtons(object sender, DevExpress.XtraWizard.CustomizeCommandButtonsEventArgs e)
        {
            btnNext = e.NextButton.Button;

            if (rbHangHoa.Checked || rbKhachHang.Checked || rbNhaCungCap.Checked)
            {
                btnNext.Enabled = true;
                if (txtDuongDan.Text=="")
                {
                    btnNext.Enabled = false;
                }else
                {
                    btnNext.Enabled = true;
                }
            }
            else
            {
                btnNext.Enabled = false;
            }

        }

        private void rbKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

        private void rbNhaCungCap_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

        private void rbHangHoa_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

        private void txtDuongDan_EditValueChanged(object sender, EventArgs e)
        {
            if(File.Exists(txtDuongDan.Text))
                btnNext.Enabled = true;
        }

        private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
         
        }

        private void gridNoiDung_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void listSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            gridNoiDung.DataSource = result.Tables[listSheet.SelectedIndex];
            dt= result.Tables[listSheet.SelectedIndex];
        }

        private void frmNhapFile_Load(object sender, EventArgs e)
        {

        }
    }
}