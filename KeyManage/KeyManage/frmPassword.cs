using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KeyManage
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!KeyManage.frmAdmin.Password(txtPassword.Text))
                this.Close();
            else
                txtPassword.Text = null;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//判断输入的是否为数字或退格键
                this.btnOk.PerformClick();
        }

    }
}
