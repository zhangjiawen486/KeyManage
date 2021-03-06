﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyManage
{
    public partial class frmOutKey : Form
    {
        public frmOutKey()
        {
            InitializeComponent();
        }

        private String sSqlKey = new frmAdmin().sSqlKey;
        private String sSqlTouch = new frmAdmin().sSqlTouch;

        private void frmOutKey_Load(object sender, EventArgs e)
        {
            RefreshBtn();
        }

        //刷新窗体内容
        public void RefreshBtn()
        {
            this.panel1.Controls.Clear();
            DataSet ds = new SqlFile.clsSql().sqlSelect1(sSqlKey,"Floor");
            if (ds == null)
                return;
            DataSet ds1 = new SqlFile.clsSql().sqlSelect1(sSqlKey, "Site");
            int s = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int f = 0;
                String sFloor = ds.Tables[0].Rows[i][0].ToString();
                GroupBox grp = new GroupBox();
                grp.Name = "grp" + sFloor;
                grp.Text = sFloor + "楼：";
                int n = 0;
                for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() == ds1.Tables[0].Rows[j][2].ToString())
                    {
                        Button btn = new Button();
                        String sID = ds1.Tables[0].Rows[j][0].ToString();
                        String sName = ds1.Tables[0].Rows[j][1].ToString();
                        String sKey = ds1.Tables[0].Rows[j][4].ToString();
                        if (sKey == "")
                            sKey = "0";
                        if (sKey == "0")
                            btn.Enabled = false;
                        btn.Name = "btn" + sID;
                        btn.Text = string.Format(sName + "\n钥匙：" + sKey);
                        btn.Size = new Size(106, 60);
                        if (n > 8)
                        {
                            n = 0;
                            f++;
                        }
                        btn.Location = new Point(6 + n * 110, 24 + f * 66);
                        btn.Click += new EventHandler(this.btn_Click);//为动态控件添加事件
                        grp.Controls.Add(btn);
                        n++;
                    }
                }
                grp.Location = new Point(3, 3 + s);
                grp.Size = new Size(885, 87 + f * 67);
                this.panel1.Controls.Add(grp);
                s += 87 + f * 67;
            }
            panel1.Size = new Size(891, 78);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button h = (Button)sender;
            frmOutKeyTouch frmTouch1 = new frmOutKeyTouch();
            frmTouch1.sName = h.Name;
            frmTouch1.sText = h.Text;
            frmTouch1.ShowDialog();
        }

    }
}
