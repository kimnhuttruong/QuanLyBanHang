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
    public partial class frmThemVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public frmThemVaiTro()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        string coma = "";
        private void GetMessage(string ma)
        {
            coma = ma;
            if (ma.Length > 0)
            {
                BUS_SYS_USER_RULE bUS_ = new BUS_SYS_USER_RULE();
                treeVaiTro.DataSource = bUS_.LayDanhSachPhanQuyen(ma);
                treeVaiTro.KeyFieldName = "Object_ID";
                treeVaiTro.ParentFieldName = "Parent_ID";

                BUS_GROUP bus = new BUS_GROUP();
                DataTable dt2 = new DataTable();
                dt2=bus.LayThongTinGroup();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (ma == dt2.Rows[i]["Group_ID"].ToString())
                    {
                       txtMa.Text = dt2.Rows[i]["Group_ID"].ToString();
                       txtTen.Text = dt2.Rows[i]["Group_Name"].ToString();
                       txtDienGiai.Text = dt2.Rows[i]["Description"].ToString();
                       check.Checked =bool.Parse( dt2.Rows[i]["Active"].ToString());
                    }
                }

            }
        }
        public delegate void SendMessage(string ma);
        public SendMessage Sender;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThemVaiTro_Load(object sender, EventArgs e)
        {
            BUS_SYS_USER_RULE bUS_ = new BUS_SYS_USER_RULE();
            if (coma.Length == 0)
            {
                treeVaiTro.DataSource = bUS_.LayDanhSachPhanQuyen("admin");
                treeVaiTro.KeyFieldName = "Object_ID";
                treeVaiTro.ParentFieldName = "Parent_ID";
            }

        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_GROUP g = new DTO_GROUP();
            g.Group_ID = txtMa.Text;
            g.Group_Name = txtTen.Text;
            g.Description = txtDienGiai.Text;
            g.Active = check.Checked;
            BUS_GROUP bus = new BUS_GROUP();


            int a = bus.ThemThongTinVaiTro(g);
            if (a == 0)
                MessageBox.Show("Thêm không thành công.Vui lòng kiểm tra lại thông tin");
            else
            {
                MessageBox.Show("Thêm thành công.");

                DataTable dt = new DataTable();

                var dataGridView = new DataGridView();
                dataGridView.ColumnCount = 10;
                dataGridView.Columns[0].Name = "Object_ID";
                dataGridView.Columns[1].Name = "Rule_ID";
                dataGridView.Columns[2].Name = "AllowAdd";
                dataGridView.Columns[3].Name = "AllowDelete";
                dataGridView.Columns[4].Name = "AllowEdit";
                dataGridView.Columns[5].Name = "AllowAccess";
                dataGridView.Columns[6].Name = "AllowPrint";
                dataGridView.Columns[7].Name = "AllowImport";
                dataGridView.Columns[8].Name = "AllowExport";
                dataGridView.Columns[9].Name = "Active";

                //for (int i = 0; i < treeVaiTro.Nodes.Count; i++)
                //{
                //    string  node = treeVaiTro.Nodes[i].GetValue("UserName").ToString();

                //    Object[] row = new Object[node.Nodes.Count];

                //    for (int j = 0; j < node.Nodes.Count; j++)
                //    {
                //        row[j] = node.Nodes[j].Text;
                //    }

                //    dataGridView.Rows.Add(dr);
                //}

                for (int i = 0; i < treeVaiTro.Nodes.Count; i++)
                {

                    DTO_SYS_USER_RULE bus1 = new DTO_SYS_USER_RULE();
                    if (treeVaiTro.Nodes[i].GetValue("AllowAdd").ToString() == "True")
                    {
                        bus1.AllowAdd = 1;
                    }

                    else
                        bus1.AllowAdd = 0;
                    if (treeVaiTro.Nodes[i].GetValue("AllowDelete").ToString() == "True")
                    {

                        bus1.AllowDelete = 1;
                    }
                    else
                        bus1.AllowDelete = 0;
                    if (treeVaiTro.Nodes[i].GetValue("AllowEdit").ToString() == "True")
                    {

                        bus1.AllowEdit = 1;
                    }
                    else
                        bus1.AllowEdit = 0;
                    if (treeVaiTro.Nodes[i].GetValue("AllowAccess").ToString() == "True")
                    {
                        bus1.AllowAccess = 1;
                    }
                    else
                        bus1.AllowAccess = 0;
                    if (treeVaiTro.Nodes[i].GetValue("AllowPrint").ToString() == "True")
                    {
                        bus1.AllowPrint = 1;
                    }
                    else
                        bus1.AllowPrint = 0;
                    if (treeVaiTro.Nodes[i].GetValue("AllowExport").ToString() == "True")
                    {
                        bus1.AllowExport = 1;
                    }
                    else
                        bus1.AllowExport = 0;
                    if (treeVaiTro.Nodes[i].GetValue("AllowImport").ToString() == "True")
                    {
                        bus1.AllowImport = 1;
                    }
                    else
                        bus1.AllowImport = 0;
                    if (treeVaiTro.Nodes[i].GetValue("Active").ToString() == "True")
                    {

                        bus1.Active = 1;
                    }
                    else
                        bus1.Active = 0;

                    bus1.Goup_ID = txtMa.Text;
                    bus1.Object_ID = treeVaiTro.Nodes[i].GetValue("Object_ID").ToString();
                    bus1.Rule_ID = treeVaiTro.Nodes[i].GetValue("Rule_ID").ToString();

                 
                    BUS_SYS_USER_RULE bUS_ = new BUS_SYS_USER_RULE();
                    int b = bUS_.ThemDanhSachPhanQuyen(bus1);
                    if (b == 0)
                        MessageBox.Show("Thêm Phân Quyền không thành công.Vui lòng kiểm tra lại thông tin");
                    else
                    {

                    }
                    for (int j = 0; j < treeVaiTro.Nodes[i].Nodes.Count; j++)
                    {
                        DTO_SYS_USER_RULE bus2 = new DTO_SYS_USER_RULE();
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("AllowAdd").ToString() == "True")
                        {
                            bus2.AllowAdd = 1;
                        }

                        else
                            bus2.AllowAdd = 0;
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("AllowDelete").ToString() == "True")
                        {

                            bus2.AllowDelete = 1;
                        }
                        else
                            bus2.AllowDelete = 0;
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("AllowEdit").ToString() == "True")
                        {

                            bus2.AllowEdit = 1;
                        }
                        else
                            bus2.AllowEdit = 0;
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("AllowAccess").ToString() == "True")
                        {
                            bus2.AllowAccess = 1;
                        }
                        else
                            bus2.AllowAccess = 0;
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("AllowPrint").ToString() == "True")
                        {
                            bus2.AllowPrint = 1;
                        }
                        else
                            bus2.AllowPrint = 0;
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("AllowExport").ToString() == "True")
                        {
                            bus2.AllowExport = 1;
                        }
                        else
                            bus2.AllowExport = 0;
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("AllowImport").ToString() == "True")
                        {
                            bus2.AllowImport = 1;
                        }
                        else
                            bus2.AllowImport = 0;
                        if (treeVaiTro.Nodes[i].Nodes[j].GetValue("Active").ToString() == "True")
                        {

                            bus2.Active = 1;
                        }
                        else
                            bus2.Active = 0;

                        bus2.Goup_ID = txtMa.Text;
                        bus2.Object_ID = treeVaiTro.Nodes[i].Nodes[j].GetValue("Object_ID").ToString();
                        bus2.Rule_ID = treeVaiTro.Nodes[i].Nodes[j].GetValue("Rule_ID").ToString();

                        BUS_SYS_USER_RULE bUS_1 = new BUS_SYS_USER_RULE();
                        b = bUS_1.ThemDanhSachPhanQuyen(bus2);
                        if (b == 0)
                            MessageBox.Show("Thêm Phân Quyền không thành công.Vui lòng kiểm tra lại thông tin");
                        else
                        {

                        }
                        for (int z = 0; z < treeVaiTro.Nodes[i].Nodes[j].Nodes.Count; z++)
                        {
                            DTO_SYS_USER_RULE bus3 = new DTO_SYS_USER_RULE();
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("AllowAdd").ToString() == "True")
                            {
                                bus3.AllowAdd = 1;
                            }

                            else
                                bus3.AllowAdd = 0;
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("AllowDelete").ToString() == "True")
                            {

                                bus3.AllowDelete = 1;
                            }
                            else
                                bus3.AllowDelete = 0;
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("AllowEdit").ToString() == "True")
                            {

                                bus3.AllowEdit = 1;
                            }
                            else
                                bus3.AllowEdit = 0;
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("AllowAccess").ToString() == "True")
                            {
                                bus3.AllowAccess = 1;
                            }
                            else
                                bus3.AllowAccess = 0;
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("AllowPrint").ToString() == "True")
                            {
                                bus3.AllowPrint = 1;
                            }
                            else
                                bus3.AllowPrint = 0;
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("AllowExport").ToString() == "True")
                            {
                                bus3.AllowExport = 1;
                            }
                            else
                                bus3.AllowExport = 0;
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("AllowImport").ToString() == "True")
                            {
                                bus3.AllowImport = 1;
                            }
                            else
                                bus3.AllowImport = 0;
                            if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("Active").ToString() == "True")
                            {

                                bus3.Active = 1;
                            }
                            else
                                bus3.Active = 0;

                            bus3.Goup_ID = txtMa.Text;
                            bus3.Object_ID = treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("Object_ID").ToString();
                            bus3.Rule_ID = treeVaiTro.Nodes[i].Nodes[j].Nodes[z].GetValue("Rule_ID").ToString();

                            BUS_SYS_USER_RULE bUS_2 = new BUS_SYS_USER_RULE();
                            b = bUS_2.ThemDanhSachPhanQuyen(bus3);
                            if (b == 0)
                                MessageBox.Show("Thêm Phân Quyền không thành công.Vui lòng kiểm tra lại thông tin");
                            else
                            {

                            }
                            for (int k = 0; k < treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes.Count; k++)
                            {
                                DTO_SYS_USER_RULE bus4 = new DTO_SYS_USER_RULE();
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("AllowAdd").ToString() == "True")
                                {
                                    bus4.AllowAdd = 1;
                                }

                                else
                                    bus4.AllowAdd = 0;
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("AllowDelete").ToString() == "True")
                                {

                                    bus4.AllowDelete = 1;
                                }
                                else
                                    bus4.AllowDelete = 0;
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("AllowEdit").ToString() == "True")
                                {

                                    bus4.AllowEdit = 1;
                                }
                                else
                                    bus4.AllowEdit = 0;
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("AllowAccess").ToString() == "True")
                                {
                                    bus4.AllowAccess = 1;
                                }
                                else
                                    bus4.AllowAccess = 0;
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("AllowPrint").ToString() == "True")
                                {
                                    bus4.AllowPrint = 1;
                                }
                                else
                                    bus4.AllowPrint = 0;
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("AllowExport").ToString() == "True")
                                {
                                    bus4.AllowExport = 1;
                                }
                                else
                                    bus4.AllowExport = 0;
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("AllowImport").ToString() == "True")
                                {
                                    bus4.AllowImport = 1;
                                }
                                else
                                    bus4.AllowImport = 0;
                                if (treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("Active").ToString() == "True")
                                {

                                    bus4.Active = 1;
                                }
                                else
                                    bus4.Active = 0;

                                bus4.Goup_ID = txtMa.Text;
                                bus4.Object_ID = treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("Object_ID").ToString();
                                bus4.Rule_ID = treeVaiTro.Nodes[i].Nodes[j].Nodes[z].Nodes[k].GetValue("Rule_ID").ToString();

                                BUS_SYS_USER_RULE bUS_3 = new BUS_SYS_USER_RULE();
                                b = bUS_3.ThemDanhSachPhanQuyen(bus4);
                                if (b == 0)
                                    MessageBox.Show("Thêm Phân Quyền không thành công.Vui lòng kiểm tra lại thông tin");
                                else
                                {

                                }
                            }
                        }
                    }
                
                }
                txtMa.Text = "";
                txtTen.Text = "";
                txtDienGiai.Text = "";
                check.Checked = true;
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}