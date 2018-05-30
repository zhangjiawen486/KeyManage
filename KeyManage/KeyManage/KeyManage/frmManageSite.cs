using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlFile;

namespace KeyManage
{
    public partial class frmManageSite : Form
    {
        public frmManageSite()
        {
            InitializeComponent();
        }

        private String sSqlKey = new frmAdmin().sSqlKey;
        private String sSqlTouch = new frmAdmin().sSqlTouch;
        private String sRoom4="";
        private String sRoomC4="";
        private String sName4="";

        private void frmManageSite_Load(object sender, EventArgs e)
        {
            RefreshFloor();
        }

        //清空所有控件的内容
        private void Clean()
        {
            numericUpDown1.Value = 0;
            cboFloor2.SelectedIndex = -1;
            cboFloor3.SelectedIndex = -1;
            cboFloor4.SelectedIndex = -1;
            lstSite.Items.Clear();
            txtName3.Text = null;
            txtName4.Text = null;
            txtRoom3.Text = null;
            txtRoomC3.Text = null;
            txtRoom4.Text = null;
            txtRoomC4.Text = null;
        }

        //刷新楼层信息
        private void RefreshFloor()
        {
            cboFloor2.Items.Clear();
            cboFloor3.Items.Clear();
            cboFloor4.Items.Clear();
            cboFloor2.Items.Add("全部");
            DataSet ds = new SqlFile.clsSql().sqlSelect1(sSqlKey ,"Floor");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboFloor2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                cboFloor3.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                cboFloor4.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        //刷新教室信息
        private void RefreshSite()
        {
            lstSite.Items.Clear();
            if (cboFloor2.SelectedIndex < 0)
                return;
            if (cboFloor2.Text.Equals("全部"))
            {
                DataSet ds = new SqlFile.clsSql().sqlSelect1(sSqlKey, "Site");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    lstSite.Items.Add(ds.Tables[0].Rows[i][1].ToString() + "                                              @" + ds.Tables[0].Rows[i][0].ToString());
            }
            else
            {
                DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlKey, "Site", "Floor_ID", cboFloor2.Text);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    lstSite.Items.Add(ds.Tables[0].Rows[i][1].ToString() + "                                              @" + ds.Tables[0].Rows[i][0].ToString());
            }
            lstSite.SelectedIndex = -1;
            txtName4.Text = "";
            txtRoom4.Text = "";
            txtRoomC4.Text = "";
        }

        //单击楼层添加按钮
        private void btnFloorAdd_Click(object sender, EventArgs e)
        {
            if (new SqlFile.clsSql().sqlSelect2(sSqlKey, "Floor", "Floor_ID", numericUpDown1.Value.ToString()))
                return;
            if (new SqlFile.clsSql().sql2(sSqlKey, "insert into Floor (Floor_ID) values ('" + numericUpDown1.Value.ToString() + "')"))
            {
                MessageBox.Show("添加成功!", "提示！");
                RefreshFloor();
            }
            else
                MessageBox.Show("添加失败!", "错误！");
        }

        //单击楼层移除按钮
        private void btnFloorDelete_Click(object sender, EventArgs e)
        {
            DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlKey, "Site", "Floor_ID", numericUpDown1.Value.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("移除失败，请先移除该楼层内教室！");
                return;
            }
            DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel);
            if (dr != DialogResult.OK)
                return;
            if (new SqlFile.clsSql().sql2(sSqlKey, "delete from Floor where Floor_ID='" + numericUpDown1.Value.ToString() + "'"))
            {
                MessageBox.Show("删除成功!", "提示！");
                RefreshFloor();
            }
            else
                MessageBox.Show("删除失败!", "错误！");
        }

        //选择楼层是触发
        private void cboFloor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSite();
        }

        //选择教室时触发
        private void lstSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSite.SelectedIndex < 0)
            {
                cboFloor4.SelectedIndex = -1;
                txtName4.Text = null;
                txtRoom4.Text = null;
                return;
            }
            string str = lstSite.Text.Substring(lstSite.Text.IndexOf("@") + 1, lstSite.Text.Length - lstSite.Text.IndexOf("@") - 1);
            DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlKey, "Site", "Site_ID", str);
            sRoom4 = ds.Tables[0].Rows[0][3].ToString();
            sRoomC4 = ds.Tables[0].Rows[0][5].ToString();
            sName4 = ds.Tables[0].Rows[0][1].ToString();
            txtName4.Text = sName4;
            txtRoom4.Text = sRoom4;
            txtRoomC4.Text = sRoomC4;
            String s = ds.Tables[0].Rows[0][2].ToString();
            cboFloor4.SelectedItem = s;
        }

        //单击添加教室按钮
        private void btnSiteAdd_Click(object sender, EventArgs e)
        {
            if (txtName3.Text == "" || txtRoom3.Text == "" || txtRoomC3.Text == "" || cboFloor3.SelectedIndex < 0)
                return;
            if (new SqlFile.clsSql().sqlSelect2(sSqlKey, "Site", "Site_Name", txtName3.Text))
            {
                MessageBox.Show("该教室名称已存在！");
                return;
            }
            if (new SqlFile.clsSql().sqlSelect2(sSqlKey, "Site", "Site_RoomOpen", txtRoom3.Text))
            {
                MessageBox.Show("该IO打开数据已存在！");
                return;
            }
            if (new SqlFile.clsSql().sqlSelect2(sSqlKey, "Site", "Site_RoomClose", txtRoomC3.Text))
            {
                MessageBox.Show("该IO关闭数据已存在！");
                return;
            }
            String sFloor = cboFloor3.SelectedText;
            String sRoom = txtRoom3.Text;
            String sName = txtName3.Text;
            if (new SqlFile.clsSql().sql2(sSqlKey, "insert into Site (Site_Name,Floor_ID,Site_RoomOpen,Site_RoomClose) values ('" + txtName3.Text + "','" + cboFloor3.Text + "','" + txtRoom3.Text + "','" + txtRoomC3.Text + "')"))
            {
                MessageBox.Show("添加教室成功！");
                cboFloor3.SelectedIndex = -1;
                txtName3.Text = null;
                txtRoom3.Text = null;
                txtRoomC3.Text = null;
                RefreshSite();
            }
            else
                MessageBox.Show("添加教室失败!", "错误！");
        }

        //单击修改教室按钮
        private void btnSiteUpdate_Click(object sender, EventArgs e)
        {
            if (lstSite.SelectedIndex < -1)
            {
                MessageBox.Show("请选择要修改的教室！");
                return;
            }
            if (txtName4.Text == "" || txtRoom4.Text == "" || txtRoomC4.Text == "" || cboFloor4.SelectedIndex < 0)
                return;
            if (new SqlFile.clsSql().sqlSelect2(sSqlKey, "Site", "Site_RoomOpen", txtRoom4.Text) && txtRoom4.Text != sRoom4)
            {
                MessageBox.Show("该IO打开数据已存在！");
                txtRoom4.Text = "";
                return;
            }
            if (new SqlFile.clsSql().sqlSelect2(sSqlKey, "Site", "Site_RoomClose", txtRoomC4.Text) && txtRoomC4.Text != sRoomC4)
            {
                MessageBox.Show("该IO关闭数据已存在！");
                txtRoomC4.Text = "";
                return;
            }
            if (new SqlFile.clsSql().sqlSelect2(sSqlKey, "Site", "Site_Name", txtName4.Text) && txtName4.Text != sName4)
            {
                MessageBox.Show("该教室名称已存在！");
                txtName4.Text = "";
                return;
            }
            String str = lstSite.Text.Substring(lstSite.Text.IndexOf("@") + 1, lstSite.Text.ToString().Length - lstSite.Text.IndexOf("@") - 1);
            if (new SqlFile.clsSql().sql2(sSqlKey, "update Site set Site_Name='" + txtName4.Text + "',Site_RoomOpen='" + txtRoom4.Text + "',Site_RoomClose='" + txtRoomC4.Text + "',Floor_ID='" + cboFloor4.Text + "' where Site_ID='" + str + "'"))
            {
                MessageBox.Show("修改成功！");
                cboFloor4.SelectedIndex = -1;
                txtRoomC4.Text = null;
                txtName4.Text = null;
                txtRoom4.Text = null;
            }
            else
                MessageBox.Show("修改失败！");
        }

        //单击删除教室按钮
        private void btnSiteDelate_Click(object sender, EventArgs e)
        {
            if (lstSite.SelectedIndex < -1)
            {
                MessageBox.Show("请选择要删除的教室！");
                return;
            }
            DialogResult dr = MessageBox.Show("是否删除？","提示", MessageBoxButtons.OKCancel);
            if (dr != DialogResult.OK)
                return;
            if (txtName4.Text == "" || txtRoom4.Text == "" || cboFloor4.SelectedIndex < 0)
                return;
            String str = lstSite.Text.Substring(lstSite.Text.IndexOf("@") + 1, lstSite.Text.ToString().Length - lstSite.Text.IndexOf("@") - 1);
            if (new SqlFile.clsSql().sql2(sSqlKey, "delete from Site where Site_ID='" + str + "'"))
            {
                MessageBox.Show("删除成功！");
                RefreshSite();
            }
            else
                MessageBox.Show("删除失败！");
        }

        private void txtRoom3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != '\b'))//判断输入的是否为数字或退格键
                e.Handled = true;//事件结束
        }

        private void txtRoom4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != '\b'))//判断输入的是否为数字或退格键
                e.Handled = true;//事件结束
        }

    }
}
