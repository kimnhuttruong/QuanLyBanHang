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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainwindown = new FrmThongTinDonViTinh();
            mainwindown.ShowDialog();
        }

        private void barStaticItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            DataTable dt = new DataTable();

            BUS_UNIT bUS_ = new BUS_UNIT();
            dt = bUS_.LayThongTinDonVi();
            List<DTO_UNIT> dsUnit = new List<DTO_UNIT>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_UNIT unit = new DTO_UNIT();
                unit.Unit_ID = dt.Rows[i]["Unit_ID"].ToString();
                unit.Unit_Name = dt.Rows[i]["Unit_Name"].ToString();
                unit.Description = dt.Rows[i]["Description"].ToString();
                unit.Active = bool.Parse(dt.Rows[i]["Active"].ToString());

                dsUnit.Add(unit);
            }

            treeDonViTinh.DataSource = dsUnit;
        }
    }
}