using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlFile;
using System.Threading;

namespace KeyManage
{
    
    public partial class frmAdmin : Form
    {
        private static bool b=true;
        public String sSqlKey = "sqlConfig";
        public String sSqlTouch = "sqlConfig1";
        private bool bFlag = true;
        Thread threadLoading;
        frmLoading frmLoading1;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        //打开进度条窗口
        private void s()
        {
            frmLoading1 = new frmLoading();
            frmLoading1.str = "尝试与‘指纹’服务进行连接...";
            frmLoading1.ShowDialog();
        }

        private void s1()
        {
            frmLoading1 = new frmLoading();
            frmLoading1.str = "尝试与‘钥匙’服务进行连接...";
            frmLoading1.ShowDialog();
        }

        //关闭子窗体
        private bool FormClose()
        {
            if (bFlag)
            {
                threadLoading = new Thread(new ThreadStart(s));
                threadLoading.IsBackground = true;
                threadLoading.Start();
                String str = new SqlFile.clsSql().sqlOpen1(sSqlTouch);
                if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                {
                    Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                    frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                }
                if (threadLoading != null)
                    threadLoading.Abort();
                if (str != "")
                {
                    MessageBox.Show(str);
                    return false;
                }
                threadLoading = new Thread(new ThreadStart(s1));
                threadLoading.IsBackground = true;
                threadLoading.Start();
                String str1 = new SqlFile.clsSql().sqlOpen1(sSqlKey);
                if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                {
                    Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                    frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                }
                if (threadLoading != null)
                    threadLoading.Abort();
                if (str1 != "")
                {
                    MessageBox.Show(str1);
                    return false;
                }
                bFlag = false;
            }
            if (clsFormStatic.frmOutKey1 != null)
            {
                clsFormStatic.frmOutKey1.Close();
                clsFormStatic.frmOutKey1 = null;
            }
            if (clsFormStatic.frmPutKey1 != null)
            {
                clsFormStatic.frmPutKey1.Close();
                clsFormStatic.frmPutKey1 = null;
            }
            if (clsFormStatic.frmRecord1 != null)
            {
                clsFormStatic.frmRecord1.Close();
                clsFormStatic.frmRecord1 = null;
            }
            if (clsFormStatic.frmManageSite1 != null)
            {
                clsFormStatic.frmManageSite1.Close();
                clsFormStatic.frmManageSite1 = null;
            }
            if (clsFormStatic.frmMananeKey1 != null)
            {
                clsFormStatic.frmMananeKey1.Close();
                clsFormStatic.frmMananeKey1 = null;
            }
            return true;
        }

        private void 取钥匙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormClose())
                return;
            if (clsFormStatic.frmOutKey1==null)
            {
                clsFormStatic.frmOutKey1 = new frmOutKey();
                clsFormStatic.frmOutKey1.MdiParent = this;
                clsFormStatic.frmOutKey1.Show();
            }
        }

        private void 还钥匙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormClose())
                return;
            if (clsFormStatic.frmPutKey1 == null)
            {
                clsFormStatic.frmPutKey1 = new frmPutKey();
                clsFormStatic.frmPutKey1.MdiParent = this;
                clsFormStatic.frmPutKey1.Show();
            }
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b)
            {
                FormClose();
                frmPassword frmPassword1 = new frmPassword();
                frmPassword1.ShowDialog(this);
            }
            else
            {
                钥匙管理ToolStripMenuItem.Visible = true;
                教室管理ToolStripMenuItem.Visible = true;
                修改密码ToolStripMenuItem.Visible = true;
                退出ToolStripMenuItem.Visible = true;
                menuStrip1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void 钥匙管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormClose())
                return;
            if (clsFormStatic.frmMananeKey1 == null)
            {
                clsFormStatic.frmMananeKey1 = new frmManageKey();
                clsFormStatic.frmMananeKey1.MdiParent = this;
                clsFormStatic.frmMananeKey1.Show();
            }
        }

        private void 房间管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormClose())
                return;
            if (clsFormStatic.frmManageSite1 == null)
            {
                clsFormStatic.frmManageSite1 = new frmManageSite();
                clsFormStatic.frmManageSite1.MdiParent = this;
                clsFormStatic.frmManageSite1.Show();
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormClose())
                return;
            new frmPassword1().ShowDialog(this);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClose();
            钥匙管理ToolStripMenuItem.Visible = false;
            教室管理ToolStripMenuItem.Visible = false;
            修改密码ToolStripMenuItem.Visible = false;
            退出ToolStripMenuItem.Visible = false;
            menuStrip1.ContextMenuStrip = null;
            b = true;
        }

        private void 记录日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormClose())
                return;
            if (clsFormStatic.frmRecord1 == null)
            {
                clsFormStatic.frmRecord1 = new frmRecord();
                clsFormStatic.frmRecord1.MdiParent = this;
                clsFormStatic.frmRecord1.Show();
            }
        }

        //密码校验
        public static bool Password(String str)
        {
            String s = new clsSqlPassword().MD5Pass(str);
            String ss = new clsPassword().IniReadValue("Password");
            if (s.Equals(ss))
            {
                MessageBox.Show("登录成功！");
                b = false;
                return false;
            }
            MessageBox.Show("登录失败！" );
            return true;
        }

        private void 服务器配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bFlag = true;
            SqlFile.frmConfig frmConfig1 = new frmConfig();
            frmConfig1.sServer = "sqlConfig";
            frmConfig1.ShowDialog(this);
        }

        private void 服务器配置2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bFlag = true;
            SqlFile.frmConfig frmConfig1 = new frmConfig();
            frmConfig1.sServer = "sqlConfig1";
            frmConfig1.ShowDialog(this);
        }


    }
}
