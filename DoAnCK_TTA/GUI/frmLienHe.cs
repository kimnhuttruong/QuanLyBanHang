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

namespace DoAnCK_TTA.GUI
{
    public partial class frmLienHe : DevExpress.XtraEditors.XtraForm
    {
        public frmLienHe()
        {
            InitializeComponent();
        }
     
        
       
        private void frmLienHe_Load(object sender, EventArgs e)
        {
            txtTenDonVi.Text = "Công Ty Phần Mềm Hoàn Hảo";
           
            txtDiaChi.Text = "227 Nguễn Văn Cừ , Phường 4 , Quận 5 ";
            txtDT.Text = "19001560";
            txtFax.Text = "0866748591";
            txtWeb.Text = "www.hcmus.edu.vn";
            txtEmail.Text = "bantin@hcmus.edu.vn";
            cbxLinhVuc.Properties.Items.Add("1. Sản Xuất");
            cbxLinhVuc.Properties.Items.Add("2.Thương Mại");
            cbxLinhVuc.Properties.Items.Add("3. Dịch Vụ");
            cbxLinhVuc.Properties.Items.Add("4. Xây Dựng");
            cbxLinhVuc.Properties.Items.Add("5. Khác");
           
           txtNganhNghe.Text = "Cung Cấp Giải Pháp Phần Mền";
            txtMaThue.Text = "1100803080";
            txtGPKD.Text = "1100803080";
            cbxNLH.Properties.Items.Add("Anh");
            cbxNLH.Properties.Items.Add("Chị");
            
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNganhNghe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtNLH.Text=="" && cbxLinhVuc.EditValue==null && cbxNLH.EditValue==null&& rtxND.Text!="")
            {
                MessageBox.Show("Xin vui lòng điền đủ thông tin ");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công \n Cảm ơn quý khách đã sử dụng phần mềm cuả chúng tôi");
            }
        }
    }
}