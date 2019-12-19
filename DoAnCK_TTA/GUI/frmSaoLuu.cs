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
    public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSaoLuu_Load(object sender, EventArgs e)
        {
          

        }
        string folderpath = "";
        private void btnBrown_Click(object sender, EventArgs e)
        {
          
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //DialogResult dr = fbd.ShowDialog();


            //if (dr == DialogResult.OK)
            //{
              
               
            //    DialogResult dialogResult = MessageBox.Show("Bạn Đã Cấp Quyền Cho Thư Mục Bạn Muốn Backup?", "Thông Báo", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        folderpath = fbd.SelectedPath;
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        ;
            //    }


            //}
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            //BUS_SYS bUS = new BUS_SYS();
            //string kt = bUS.SaoLuu(folderpath);
            //if (kt != "1")
            //{
            //    MessageBox.Show("Sao Lưu KHông Thành Công.Vui Lòng Cấp Quyền truy cập cho Folder Chứa file Backup\n Xóa File Backup vừa tạo: " + kt);
            //}
            //else
            //{
            //    MessageBox.Show("Sao Lưu thành công");
            //}
        }
    }
}