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
    public partial class frmManageKey : Form
    {
        public frmManageKey()
        {
            InitializeComponent();
        }

        private String sKey="";
        private String sSqlKey = new frmAdmin().sSqlKey;
        private String sSqlTouch = new frmAdmin().sSqlTouch;

        //刷新楼层显示
        private void RefreshFloor()
        {            
            cboFloor.Items.Add("全部");
            cboFloor.Items.Clear();
            DataSet ds = new SqlFile.clsSql().sqlSelect1(sSqlKey,"Floor");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboFloor.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            cboFloor.SelectedIndex = 0;
        }

        //刷新教室信息
        private void RefreshSite()
        {
            lstSite.Items.Clear();
            if (cboFloor.SelectedIndex < 0)
                return;
            if (cboFloor.Text.Equals("全部"))
            {
                DataSet ds = new SqlFile.clsSql().sqlSelect1(sSqlKey, "Site");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    lstSite.Items.Add(ds.Tables[0].Rows[i][1].ToString() + "                                              @" + ds.Tables[0].Rows[i][0].ToString());
            }
            else
            {
                DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlKey, "Site", "Floor_ID", cboFloor.Text);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    lstSite.Items.Add(ds.Tables[0].Rows[i][1].ToString() + "                                              @" + ds.Tables[0].Rows[i][0].ToString());
            }
            lstSite.SelectedIndex = -1;
        }

        //选择楼层时触发
        private void cboFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSite();
        }

        //选择教室时触发
        private void lstSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSite.SelectedIndex < 0)
            {
                txtKey.Text = null;
                return;
            }
            string str= lstSite.Text.Substring(lstSite.Text.IndexOf("@") + 1, lstSite.Text.Length - lstSite.Text.IndexOf("@") - 1);
            DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlKey, "Site", "Site_ID", str);
            sKey=ds.Tables[0].Rows[0][4].ToString();
            if (sKey == "")
                sKey = "0";
            txtKey.Text = sKey;
        }

        //单击修改按钮
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstSite.SelectedIndex < 0)
            {
                MessageBox.Show("请选择要修改的教室！");
                return;
            }
            if (txtKey.Text == "")
            {
                MessageBox.Show("请输入钥匙数量");
                return;
            }
            String str = lstSite.Text.Substring(lstSite.Text.IndexOf("@") + 1, lstSite.Text.ToString().Length - lstSite.Text.IndexOf("@") - 1);
            String sSite = lstSite.Text.Substring(0, lstSite.Text.IndexOf(" "));
            if (new SqlFile.clsSql().sql2(sSqlKey, "insert into Record (Record_Time,Record_Site,Record_User,Record_UserID,Record_Content) values (getdate(),'" + sSite + "','管理员','管理员','钥匙数" + sKey + "改为" + txtKey.Text + "')"))
            {
                if (new SqlFile.clsSql().sql2(sSqlKey, "update Site set Site_Key='" + txtKey.Text + "' where Site_ID='" + str + "'"))
                {

                    MessageBox.Show("修改成功！");
                    txtKey.Text = null;
                    return;
                }
            }
            MessageBox.Show("修改失败！");
        }

        //判断输入的是否为数字
        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != '\b'))//判断输入的是否为数字或退格键
                e.Handled = true;//事件结束
        }

        private void frmManageKey_Load(object sender, EventArgs e)
        {
            RefreshFloor();
        }

    }
}
