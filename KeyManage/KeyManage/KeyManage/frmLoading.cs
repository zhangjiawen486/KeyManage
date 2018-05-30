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
    public partial class frmLoading : Form
    {
        public String str = "";

        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            label1.Text = str;
        }
    }
}
