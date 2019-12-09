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
            mainWindow.Show();

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
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            BUS_GROUP bUS_ = new BUS_GROUP();
            dt = bUS_.LayThongTinVaiTro();


            treeVaiTroNguoiDung.DataSource = dt;
            treeVaiTroNguoiDung.ParentFieldName = "Group_ID";
            treeVaiTroNguoiDung.KeyFieldName = "GroupID";

        }
      
        DataSet ds1 = new DataSet();
        private void treeList2_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
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

            {
                //dt2.Columns[0].Caption = "Tên Đăng Nhập";
                //dt2.Columns[1].Caption = "Vai Trò";
                //dt2.Columns[2].Caption = "Diễn Giải";
                //dt2.Columns[3].Caption = "Kích Hoạt";
                //dt2.Columns[4].ColumnMapping = MappingType.Hidden;



                //var colMaster = ds1.Tables[0].Columns["Group_ID"];
                //var colDetail = ds1.Tables[1].Columns["Group_ID"];
                ////đưa relation vào dataset
                // ds1.Relations.Add("List UserName", colMaster, colDetail);

                //gridNhomphanquyen.DataSource = ds1;
                // gridNhomphanquyen.DataMember = "Group";


                //gridNhomphanquyen.DataSource = ds1;
                //gridNhomphanquyen.DataMember = "Group";

                // Get the context.
            }
            
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
            mainWindow.Show();

        }

        private void TreePhanQuyen_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {

        }

        private void GridNhomphanquyen_Click(object sender, EventArgs e)
        {

        }
    }

}