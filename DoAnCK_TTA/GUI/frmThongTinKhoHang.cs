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

namespace DoAnCK_TTA.GUI
{
    public partial class frmThongTinKhoHang : DevExpress.XtraEditors.XtraForm
    {

        public frmThongTinKhoHang()
        {
            InitializeComponent();
        }

        public class cEmployee
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<cEmployee> _dsEmployee = new List<cEmployee>();
        private void frmThongTinKhoHang_Load(object sender, EventArgs e)
        {
            BUS_EMPLOYEE bus = new BUS_EMPLOYEE();

            DataTable dt = new DataTable();


            dt = bus.LayDanhSachQuanLy();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cEmployee employee = new cEmployee();
                employee.Id = dt.Rows[i]["Employee_ID"].ToString();
                employee.Name = dt.Rows[i]["Employee_Name"].ToString();
                _dsEmployee.Add(employee);
            }


            lookNguoiQuanLy.Properties.DataSource = _dsEmployee;
            lookNguoiQuanLy.Properties.DisplayMember = "Name";
            lookNguoiQuanLy.Properties.ValueMember = "Id";
        }

        private void lookNguoiQuanLy_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}