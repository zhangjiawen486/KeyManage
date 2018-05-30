using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SqlFile
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        public String sServer = "";

        private void frmConfig_Load(object sender, EventArgs e)
        {
            SelectFile();
            PutServer();
        }

        //单击保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveServer();
        }

        //判断文件是否存在
        private void SelectFile()
        {
            if (!File.Exists(sServer + ".ini"))
                new IniFile.clsIni().IniNew(sServer);
            switch (sServer)
            {
                case "sqlConfig":
                    this.Text="连接指纹服务器"; break;
                default:
                    this.Text="未定义的数据库文件";break;
            }
        }

        //显示服务器配置
        private void PutServer()
        {
            txtServer.Text = new IniFile.clsIni().IniReadValue("Server", sServer);
            txtDatabase.Text = new IniFile.clsIni().IniReadValue("Database", sServer);
            txtUserName.Text = new IniFile.clsIni().IniReadValue("UserName", sServer);
            String str = new IniFile.clsIni().IniReadValue("Password", sServer);
            txtPassword.Text = new clsSqlPassword().OutPassword(str);
        }

        //保存服务器配置
        private void SaveServer()
        {
            new IniFile.clsIni().IniWriteValue("Server", txtServer.Text, sServer);
            new IniFile.clsIni().IniWriteValue("Database", txtDatabase.Text, sServer);
            new IniFile.clsIni().IniWriteValue("UserName", txtUserName.Text, sServer);
            String str=new clsSqlPassword().InPassword(txtPassword.Text);
            new IniFile.clsIni().IniWriteValue("Password", str, sServer);
            MessageBox.Show("保存成功！", "提示");
            this.Close();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
