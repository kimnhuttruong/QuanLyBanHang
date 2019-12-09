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
using DoAnCK_TTA.DTO;
using DoAnCK_TTA.BUS;

namespace DoAnCK_TTA.GUI
{
    public partial class frmThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNhanVien()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);

            if (txtMa.Text == "")
            {
                BUS_EMPLOYEE busnv = new BUS_EMPLOYEE();
                _dtQuanLy = busnv.LayDanhSachNhanVien();

                lookQuanLy.Properties.DataSource = _dtQuanLy;
                lookQuanLy.Properties.DisplayMember = "Employee_Name";
                lookQuanLy.Properties.ValueMember = "Employee_ID";

                txtMa.Text = _dtQuanLy.Rows[_dtQuanLy.Rows.Count - 1][0].ToString();

                txtMa.Text = txtMa.Text.Remove(0, 2);

                txtMa.Text = (int.Parse(txtMa.Text) + 2).ToString("000000");
                txtMa.Text = "NV" + txtMa.Text.ToString();
            }

        }
        
        private void GetMessage(DTO_EMPLOYEE c)
        {
            txtMa.Text = c.Employee_ID;
            txtTen.Text = c.Employee_Name;
            txtChucVu.Text = c.Position_ID;
            txtDiaChi.Text = c.Address;
            txtEmail.Text = c.Email;
            txtDienThoai.Text = c.O_Tel;
            txtDiDong.Text = c.Mobile;
            _idBoPhan = c.Department_ID;
            _idQuanLy = c.Manager_ID;

            //DataTable dt1 = new DataTable();

            //lookBoPhan.EditValue = lookBoPhan.Properties.GetKeyValue(int.Parse(Department_ID.Remove(0, 2)) - 1);
            //lookQuanLy.EditValue = lookBoPhan.Properties.GetKeyValue(int.Parse(Department_ID.Remove(0, 2)) - 1);
            checkQuanLy.Checked = c.Active;
            if (c.Employee_Name == null)
                isAdd = true;
            else
                isAdd = false;
        }
       
        bool isAdd = true;
        public delegate void SendMessage(DTO_EMPLOYEE c);
        public SendMessage Sender;
        string _idBoPhan="",_idQuanLy="NV";
        DataTable _dtBoPhan = new DataTable();
        DataTable _dtQuanLy = new DataTable();
        void formLoad()
        {
            BUS_DEPARTMENT bus = new BUS_DEPARTMENT();
            _dtBoPhan = bus.LayDanhSachBoPhan();

            lookBoPhan.Properties.DataSource = _dtBoPhan;
            lookBoPhan.Properties.DisplayMember = "Department_Name";
            lookBoPhan.Properties.ValueMember = "Department_ID";

            for(int i=0;i< _dtBoPhan.Rows.Count-1;i++)
            {
                if (_idBoPhan == _dtBoPhan.Rows[i]["Department_ID"].ToString())
                    _idBoPhan =  i.ToString();
            }

            if (_idBoPhan != "" && _idBoPhan != null)
                lookBoPhan.EditValue = lookBoPhan.Properties.GetKeyValue(int.Parse(_idBoPhan));


           



            BUS_EMPLOYEE busnv = new BUS_EMPLOYEE();
            _dtQuanLy = busnv.LayDanhSachNhanVien();

            lookQuanLy.Properties.DataSource = _dtQuanLy;
            lookQuanLy.Properties.DisplayMember = "Employee_Name";
            lookQuanLy.Properties.ValueMember = "Employee_ID";

            for (int i = 0; i < _dtQuanLy.Rows.Count - 1; i++)
            {
                if (_idQuanLy == _dtQuanLy.Rows[i]["Employee_ID"].ToString())
                    _idQuanLy = i.ToString();
            }

            if (_idQuanLy != "" && _idQuanLy != null && _idQuanLy != "NV")
                lookQuanLy.EditValue = lookQuanLy.Properties.GetKeyValue(int.Parse(_idQuanLy));

        }
        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_EMPLOYEE bus = new BUS_EMPLOYEE();
            DTO_EMPLOYEE c = new DTO_EMPLOYEE();
            c.Employee_ID = txtMa.Text;
            c.Employee_Name= txtTen.Text;
            c.Position_ID= txtChucVu.Text;
            c.Address= txtDiaChi.Text;
            c.Email= txtEmail.Text;
            c.H_Tel= txtDienThoai.Text;
            c.Mobile= txtDiDong.Text;
            c.Department_ID = lookBoPhan.EditValue.ToString();
            c.Manager_ID= lookQuanLy.EditValue.ToString();


            c.Active = checkQuanLy.Checked;
            if (isAdd == true)
            {
                int kt = bus.ThemNhanVien(c);

            }
            else
            {
                int kt = bus.CapNhatNhanVien(c);

            }
            this.Close();
        }
        bool _thembophan = false;
        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            Form bophan = new frmThemBoPhan();
            bophan.ShowDialog();

            _thembophan = true;

            formLoad();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
           

            Form them = new frmThongTinNhanVien();
            them.ShowDialog();
            formLoad();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}