using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyManage
{
    public partial class frmPassword1 : Form
    {
        public frmPassword1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtPassword1.Text))
            {
                MessageBox.Show("请确保两次密码相同！");
                return;
            }
            String str = new clsSqlPassword().MD5Pass(txtPassword.Text);
            new clsPassword().IniWriteValue("Password", str);
            MessageBox.Show("修改成功！");
            this.Close();
        }

        private void frmPassword1_Load(object sender, EventArgs e)
        {

        }
    }
}
