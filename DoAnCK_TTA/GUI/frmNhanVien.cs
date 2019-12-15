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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinNhanVien();


            dTO_EMPLOYEE.Employee_ID = _dt.Rows[_dt.Rows.Count - 1][0].ToString();

            dTO_EMPLOYEE.Employee_ID = dTO_EMPLOYEE.Employee_ID.Remove(0, 2);

            dTO_EMPLOYEE.Employee_ID = (int.Parse(dTO_EMPLOYEE.Employee_ID) + 1).ToString("000000");
            dTO_EMPLOYEE.Employee_ID = "NV" + dTO_EMPLOYEE.Employee_ID.ToString();

            mainWindow.Sender(dTO_EMPLOYEE);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTinNhanVien();



            mainWindow.Sender(c);    //Gọi delegate
            mainWindow.ShowDialog();
            Init();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_EMPLOYEE bus = new BUS_EMPLOYEE();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaNhanVien(c.Employee_ID);
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
                            treeNhanVien.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            treeNhanVien.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            treeNhanVien.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            treeNhanVien.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            treeNhanVien.ExportToHtml(exportFilePath);
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

        private void frmNhanVien_Load(object sender, EventArgs e)
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
                        //if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //    btnNhap.Enabled = false;
                    }

                }
            }
            Init();
        }
        DataTable _dt = new DataTable();
        public void Init()
        {


            BUS_EMPLOYEE bUS_ = new BUS_EMPLOYEE();
            _dt = bUS_.LayDanhSachNhanVien();
           

            treeNhanVien.DataSource = _dt;
        }
        DTO_EMPLOYEE c = new DTO_EMPLOYEE();
        DTO_EMPLOYEE dTO_EMPLOYEE = new DTO_EMPLOYEE();
        private void treeNhanVien_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            c.Employee_ID = e.Node.GetValue("Employee_ID").ToString();
            c.FirtName = e.Node.GetValue("FirtName").ToString();
            c.LastName = e.Node.GetValue("LastName").ToString();
            c.Employee_Name = e.Node.GetValue("Employee_Name").ToString();
            c.Alias = e.Node.GetValue("Alias").ToString();
            c.Sex = e.Node.GetValue("Sex").ToString();
            c.Address = e.Node.GetValue("Address").ToString();
            c.Country_ID = e.Node.GetValue("Country_ID").ToString();
            c.H_Tel = e.Node.GetValue("H_Tel").ToString();
            c.O_Tel = e.Node.GetValue("O_Tel").ToString();
            c.Mobile = e.Node.GetValue("Mobile").ToString();
            c.Fax = e.Node.GetValue("Fax").ToString();
            c.Email = e.Node.GetValue("Email").ToString();
            c.Birthday = e.Node.GetValue("Birthday").ToString();
            c.Married = e.Node.GetValue("Married").ToString();
            c.Position_ID = e.Node.GetValue("Position_ID").ToString();
            c.JobTitle_ID = e.Node.GetValue("JobTitle_ID").ToString();
            c.Branch_ID = e.Node.GetValue("Branch_ID").ToString();
            c.Department_ID = e.Node.GetValue("Department_ID").ToString();
            c.Team_ID = e.Node.GetValue("Team_ID").ToString();
            c.PersonalTax_ID = e.Node.GetValue("PersonalTax_ID").ToString();
            c.City_ID = e.Node.GetValue("City_ID").ToString();
            c.District_ID = e.Node.GetValue("District_ID").ToString();
            c.Manager_ID = e.Node.GetValue("Manager_ID").ToString();
            c.EmployeeType = e.Node.GetValue("EmployeeType").ToString();
            c.BasicSalary = e.Node.GetValue("BasicSalary").ToString();
            c.Advance = e.Node.GetValue("Advance").ToString();
            c.AdvanceOther = e.Node.GetValue("AdvanceOther").ToString();
            c.Commission = e.Node.GetValue("Commission").ToString();
            c.Discount = e.Node.GetValue("Discount").ToString();
            c.ProfitRate = e.Node.GetValue("ProfitRate").ToString();
            c.IsPublic = e.Node.GetValue("IsPublic").ToString();
            c.CreatedBy = e.Node.GetValue("CreatedBy").ToString();
            c.CreatedDate = e.Node.GetValue("CreatedDate").ToString();
            c.ModifiedBy = e.Node.GetValue("ModifiedBy").ToString();
            c.ModifiedDate = e.Node.GetValue("ModifiedDate").ToString();
            c.OwnerID = e.Node.GetValue("OwnerID").ToString();
            c.Description = e.Node.GetValue("Description").ToString();
            c.Sorted = e.Node.GetValue("Sorted").ToString();
            c.Active = bool.Parse(e.Node.GetValue("Active").ToString());
        }
    }
}