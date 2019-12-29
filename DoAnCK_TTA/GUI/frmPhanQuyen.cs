using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.StyleFormatConditions;
using System.ComponentModel.DataAnnotations;
using DoAnCK_TTA.BUS;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DoAnCK_TTA.DTO;

namespace DoAnCK_TTA.GUI
{
    public partial class frmPhanQuyen : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();


        }



        private void btnThemVaiTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThemVaiTro();
            mainWindow.ShowDialog();
            load();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("btnXoa_ItemClick");
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        { 
            DataTable dt3 = new DataTable();
            BUS_SYS_USER_RULE bus = new BUS_SYS_USER_RULE();
            dt3 = bus.LayDanhSachPhanQuyen();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                if (this.Tag != null)
                {
                    if (this.Tag.ToString() == dt3.Rows[i][0].ToString())
                    {


                        if (dt3.Rows[i]["AllowAdd"].ToString() == "False")
                        {
                            btnThemNguoiDung.Enabled = false;
                            btnThemVaiTro.Enabled = false;
                        }

                        if (dt3.Rows[i]["AllowDelete"].ToString() == "False")
                            btnXoa.Enabled = false;
                        if (dt3.Rows[i]["AllowEdit"].ToString() == "False")
                            btnSuaChua.Enabled = false;
                        //if (dt.Rows[i]["AllowAccess"].ToString() == "False")
                        //    btnXem.Enabled = false;
                        //if (dt.Rows[i]["AllowPrint"].ToString() == "False")
                        //    btnIn.Enabled = false;
                        //if (dt.Rows[i]["AllowExport"].ToString() == "False")
                        //    btnXuat.Enabled = false;
                        //if (dt.Rows[i]["AllowImport"].ToString() == "False")
                        //    btnNhap.Enabled = false;
                    }

                }
                BUS_SYS_LOG busLog = new BUS_SYS_LOG();
                DTO_SYS_LOG log = new DTO_SYS_LOG();
                BUS_SYS_USER busform = new BUS_SYS_USER();
                DataTable dtlog = new DataTable();
                dtlog = busform.LayThongTinUSER();
                log.MChine = dtlog.Rows[0][1].ToString();
                log.UserID = dtlog.Rows[0][2].ToString();
                log.Module = this.Tag.ToString();
                log.Action_Name = "Xem";
                busLog.ThemLichSu(log);

            }



            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            BUS_GROUP bUS_ = new BUS_GROUP();
            dt = bUS_.LayThongTinVaiTro();


            treeVaiTroNguoiDung.DataSource = dt;
            treeVaiTroNguoiDung.ParentFieldName = "Group_ID";
            treeVaiTroNguoiDung.KeyFieldName = "GroupID";
            treeVaiTroNguoiDung.ExpandAll();
        }
        string manhom = "";
        DataSet ds1 = new DataSet();
        private void treeList2_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            manhom = e.Node.GetValue("Group_ID").ToString();
            gridNhomphanquyen.DataSource = null;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt.Clear();
            dt2.Clear();
            ds1.Clear();
            dsUser.Clear();
            dsGroup.Clear();
            BUS_GROUP bUS_ = new BUS_GROUP();
            BUS_SYS_USER bUS = new BUS_SYS_USER();
            if (e.Node.Level == 0)
            {
                dt = bUS_.LayThongTinPhanQuyenbyName(e.Node.GetValue("UserName").ToString());
               
            }
            else
            {
                dt = bUS_.LayThongTinPhanQuyenbyID(e.Node.GetValue("Group_ID").ToString());
            }
            if (e.Node.Level == 1)
            {
                dt2 = bUS.LayThongTinPhanQuyen(e.Node.GetValue("Group_ID").ToString());
            }
            else
            {
                dt2 = bUS.LayThongTinPhanQuyen(e.Node.GetValue("GroupID").ToString());
            }
            ds1.Tables.Add(dt);
            ds1.Tables.Add(dt2);

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DTO_GROUP group = new DTO_GROUP();
                group.Group_ID = dt.Rows[i]["Group_ID"].ToString();
                group.Group_Name = dt.Rows[i]["Group_Name"].ToString();
                group.Group_NameEn = dt.Rows[i]["Group_NameEn"].ToString();
                group.Description = dt.Rows[i]["Description"].ToString();
                group.Active = bool.Parse(dt.Rows[i]["Active"].ToString());


                dsGroup.Add(group);
            }
            
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DTO_SYS_USER User = new DTO_SYS_USER();
                User.UserID = "";
                User.UserName = dt2.Rows[i]["UserName"].ToString();
                User.Description = dt2.Rows[i]["Description"].ToString();
                User.Active = bool.Parse(dt2.Rows[i]["Active"].ToString());
                User.Password = "";
                User.Group_ID = dt2.Rows[i]["Group_ID"].ToString();

                User.Group_Name = dt2.Rows[i]["Group_Name"].ToString();
                dsUser.Add(User);
            }
            BUS_SYS_USER_RULE busRule = new BUS_SYS_USER_RULE();
            if (dt.Rows.Count > 0)
            {
                dt = busRule.LayDanhSachPhanQuyen(dt.Rows[0]["Group_ID"].ToString());
                treePhanQuyen.DataSource = dt;
                treePhanQuyen.ParentFieldName = "Parent_ID";
                treePhanQuyen.KeyFieldName = "Object_ID";
                treePhanQuyen.ExpandAll();
                gridView1.ExpandAllGroups();
            }
            gridNhomphanquyen.DataSource = dsGroup;
        }
        private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_GROUP group = view.GetRow(e.RowHandle) as DTO_GROUP;
            if (group != null)
                e.IsEmpty = !dsUser.Any(x => x.Group_ID == group.Group_ID);
        }

        private void gridView1_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;

            DTO_GROUP group = view.GetRow(e.RowHandle) as DTO_GROUP;
            if (group != null)
                e.ChildList = dsUser.Where(x => x.Group_ID == group.Group_ID).ToList();

        }
        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            
        }
        List<DTO_GROUP> dsGroup = new List<DTO_GROUP>();
        List<DTO_SYS_USER> dsUser = new List<DTO_SYS_USER>();
        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Level1";
        }

        private void btnThemNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mainWindow = new frmThemNguoiDung();
            mainWindow.ShowDialog();
            load();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemVaiTro f = new frmThemVaiTro();
            f.Sender(manhom);
            f.ShowDialog();

            load();
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Sữa chữa";
            log.Description = manhom;
            busLog.ThemLichSu(log);
        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUS_SYS_USER bus = new BUS_SYS_USER();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = bus.XoaNguoiDung(manhom);
                load();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }
            BUS_SYS_LOG busLog = new BUS_SYS_LOG();
            DTO_SYS_LOG log = new DTO_SYS_LOG();
            BUS_SYS_USER busform = new BUS_SYS_USER();
            DataTable dtlog = new DataTable();
            dtlog = busform.LayThongTinUSER();
            log.MChine = dtlog.Rows[0][1].ToString();
            log.UserID = dtlog.Rows[0][2].ToString();
            log.Module = this.Tag.ToString();
            log.Action_Name = "Xóa group";
            log.Description = manhom;
            busLog.ThemLichSu(log);
        }
    }

}