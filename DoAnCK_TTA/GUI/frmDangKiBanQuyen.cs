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
using System.Globalization;
using System.Runtime.InteropServices;

namespace DoAnCK_TTA.GUI
{
    public partial class frmDangKiBanQuyen : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hwnd, IntPtr proccess);
        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint thread);
        public string name ="";
        public frmDangKiBanQuyen()
        {
            InitializeComponent();
            IntPtr foregroundWindow = GetForegroundWindow();
            uint foregroundProcess = GetWindowThreadProcessId(foregroundWindow, IntPtr.Zero);
            int keyboardLayout = GetKeyboardLayout(foregroundProcess).ToInt32() & 0xFFFF;
            CultureInfo info = new CultureInfo(keyboardLayout);
            int keyboardLayoutId = info.KeyboardLayoutId;
            name = info.TextInfo.ToString() ;
        }

       

        private void frmDangKiBanQuyen_Load(object sender, EventArgs e)
        {
            txtmamay.Text = "3F6DA817-A1BF-5BB6-6428-08A834CA";
            txtmamay.ReadOnly = true;
            txtmamay.Enabled = false;
        }

        public delegate void SetParameterValueDelegate(string value, PictureBox pictureBox);
        public SetParameterValueDelegate SetParameterValueCallback;
        public void SetParamValueCallbackFn(string value, PictureBox pictureBox)
        {
            if (value == "")
            {
                pictureBox.Visible = true;
              
            }
            else
            {
                pictureBox.Visible = false;
              
            }
        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {
            SetParamValueCallbackFn(txtMaDK.Text, ptb1);
           
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            SetParamValueCallbackFn(txtMaKH.Text, ptb2);
               
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtMaKH.Text != "")
                MessageBox.Show("Gửi Thành Công\n");
            else
                MessageBox.Show("Vui lòng nhập dủ thông tin");
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}