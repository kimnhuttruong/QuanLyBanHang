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
    public partial class frmThongTinKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinKhuVuc()
        {
            InitializeComponent();
        }

        bool isAdd;
        public bool Message//Thêm true,cập nhật false
        {
            get { return isAdd; }
            set { isAdd = value; }
        }
        string DoiMa(string chuoi)
        {
            if (chuoi.Length > 3)
            {
                chuoi = chuoi.Remove(0, 2);

                chuoi = (int.Parse(chuoi) + 1).ToString();

            }
            return chuoi;
        }
        DataTable _dt = new DataTable();
        private void frmThongTinKhuVuc_Load(object sender, EventArgs e)
        {
            //BUS_CUSTOMER_GROUP bus = new BUS_CUSTOMER_GROUP();
            //_dt = bus.LayDanhSachKhuVuc();

            //if (Message == true)
            //{
            //    txtMa.Text = DoiMa(_dt.Rows[_dt.Rows.Count - 1][0].ToString());
            //}

        }
    }
}