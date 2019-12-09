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
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public static DTO.DTO_EMPLOYEE value;
        public static BUS.BUS_EMPLOYEE bus;
        public frmThongTinNhanVien(DTO.DTO_EMPLOYEE em)
        {

            InitializeComponent();

            value = new DTO.DTO_EMPLOYEE();
            value = em;
        }


        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {

            DTO.DTO_EMPLOYEE _EMPLOYEE = new DTO.DTO_EMPLOYEE();
            _EMPLOYEE.Employee_ID1 = txtMa.Text;
            _EMPLOYEE.Employee_Name1 = txtTen.Text;
            _EMPLOYEE.Department_ID1 = txtChucVu.Text;
            _EMPLOYEE.Address1 = txtDiaChi.Text;
            _EMPLOYEE.Mobile1 = txtDienThoai.Text;
            _EMPLOYEE.Fax1 = txtFax.Text;
            DataRowView selectedDataRow = (DataRowView)lookBoPhan.GetSelectedDataRow();
            DataRowView selectedDataRow1 = (DataRowView)lookQuanLy.GetSelectedDataRow();

            _EMPLOYEE.Department_Name1 = selectedDataRow.Row[1].ToString();
            _EMPLOYEE.Manager_ID1 = selectedDataRow1.Row[1].ToString();
            if (bus.Detail(_EMPLOYEE.Employee_ID1).Rows.Count<0)
            {
                if (bus.Insert(_EMPLOYEE) == 1)
                    MessageBox.Show("Thanh cong");
                else
                    MessageBox.Show("That bai");
            }
            else

            {
                
                if (bus.Delete(_EMPLOYEE.Employee_ID1)==1 && bus.Insert(_EMPLOYEE) == 1)
                    MessageBox.Show("Thanh cong");
                else
                    MessageBox.Show("That bai");
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BtnBoPhan_Click(object sender, EventArgs e)
        {
            frmThemBoPhan bp = new frmThemBoPhan();
            bp.ShowDialog();
        }

        private void BtnQuanLy_Click(object sender, EventArgs e)
        {
           

        }

        private void FrmThongTinNhanVien_Load_1(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            BUS_EMPLOYEE bus = new BUS_EMPLOYEE();
            dt2 = bus.getDEPARTMENT();

            lookBoPhan.Properties.DataSource = dt2;
            lookBoPhan.Properties.DisplayMember = "Department_Name";
            lookBoPhan.Properties.ValueMember = "Department_ID";

            DataTable dt1 = new DataTable();
            BUS_EMPLOYEE bus1 = new BUS_EMPLOYEE();
            dt1 = bus1.getManger();
            lookQuanLy.Properties.DataSource = dt1;
            lookQuanLy.Properties.DisplayMember = "Employee_Name";
            lookQuanLy.Properties.ValueMember = "Employee_ID";



            DataTable dt = new DataTable();

            BUS.BUS_EMPLOYEE bUS_ = new BUS_EMPLOYEE();
            dt = bUS_.Detail(value.Employee_ID1);

            if (dt.Rows.Count > 0)
            {
                var em = new DTO.DTO_EMPLOYEE();
                em.Employee_ID1 = dt.Rows[0][0].ToString();
                em.Employee_Name1 = dt.Rows[0][1].ToString();
                em.Department_ID1 = dt.Rows[0][2].ToString();
                em.Address1 = dt.Rows[0][3].ToString();
                em.Mobile1 = dt.Rows[0][4].ToString();
                em.Fax1 = dt.Rows[0][5].ToString();
                em.Department_Name1 = dt.Rows[0][6].ToString();
                em.Manager_ID1 = dt.Rows[0][7].ToString();


                txtMa.Text = em.Employee_ID1;
                txtTen.Text = em.Employee_Name1;
                txtChucVu.Text = em.Department_ID1;
                txtDiaChi.Text = em.Address1;
                txtDienThoai.Text = em.Mobile1;
                lookBoPhan.Text = em.Department_Name1;
                lookQuanLy.Text = em.Manager_ID1;

            }
        }
    }
}
