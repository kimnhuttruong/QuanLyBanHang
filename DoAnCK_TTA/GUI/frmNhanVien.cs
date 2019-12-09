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

namespace DoAnCK_TTA.GUI
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS.BUS_EMPLOYEE bUS_ = new BUS_EMPLOYEE();
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
          
            dt = bUS_.LayThongTinNhanVien();
            treeNhanVien.DataSource = dt;


        }
       
        public  DTO.DTO_EMPLOYEE id; 
        private void BtnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmThongTinNhanVien = new frmThongTinNhanVien(id);
            frmThongTinNhanVien.Show();
        }

        private void BtnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmThongTinNhanVien = new frmThongTinNhanVien(id);
            frmThongTinNhanVien.ShowDialog();
        }

        private void BtnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Delete???", "Important Question", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                bUS_.Delete(id.Employee_ID1);
                DataTable dt = new DataTable();

                dt = bUS_.LayThongTinNhanVien();
                treeNhanVien.DataSource = dt;
            }

        }

        private void BtnDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void TreeNhanVien_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            
            //if (e.Node.Checked)
            {
                id = new DTO.DTO_EMPLOYEE();
                 id.Employee_ID1 = e.Node.GetValue("Employee_ID").ToString();
                MessageBox.Show(id.Employee_ID1);
                //var frmThongTinNhanVien = new frmThongTinNhanVien(id);
                //frmThongTinNhanVien.Show();
            }
        }

        private void TreeNhanVien_RowCellClick(object sender, DevExpress.XtraTreeList.RowCellClickEventArgs e)
        {
            

        }
    }
}