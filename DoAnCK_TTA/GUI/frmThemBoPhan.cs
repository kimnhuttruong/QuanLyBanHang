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
    public partial class frmThemBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemBoPhan()
        {
            InitializeComponent();
        }
        BUS.BUS_DEPARTMENT BUS_ = new BUS.BUS_DEPARTMENT();
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            DTO.DTO_DEPARTMENT dTO = new DTO.DTO_DEPARTMENT();
            dTO.Name1 = txtTen.Text;
            dTO.ID1 = txtMa.Text;
            if (checkQuanLy.Checked)

                dTO.Active = 1;
            else
                dTO.Active = 0;


            if (BUS_.insert(dTO) == 1)
                MessageBox.Show("thanh cong");
            else
                MessageBox.Show("that bai");



        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}