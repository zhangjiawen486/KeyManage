using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlFile;
using System.IO;

namespace KeyManage
{
    public partial class frmRecordLook : Form
    {
        public frmRecordLook()
        {
            InitializeComponent();
        }

        private String sSqlKey = new frmAdmin().sSqlKey;
        private String sSqlTouch = new frmAdmin().sSqlTouch;
        public String sNumber = "";

        private void frmRecordLook_Load(object sender, EventArgs e)
        {
            loding();
        }

        //单击确定时触发
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载学生信息
        private void loding()
        {
            DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlTouch,"XueSheng","XueHao",sNumber);
            if (ds.Tables[0].Rows.Count < 0)
                return;
            txtNumber.Text = ds.Tables[0].Rows[0][0].ToString();
            txtName.Text = ds.Tables[0].Rows[0][7].ToString();
            String sIDCard=ds.Tables[0].Rows[0][8].ToString();
            if (sIDCard.Length == 18)
            {
                sIDCard = sIDCard.Substring(0, 6) + "********" + sIDCard.Substring(14,4);
            }
            txtIDCard.Text = sIDCard;
            String sClass = ds.Tables[0].Rows[0][6].ToString();
            DataSet ds1 = new SqlFile.clsSql().sqlSelect3(sSqlTouch, "BanJi", "BanJiID", sClass);
            if (ds1.Tables[0].Rows.Count > 0)
                sClass = ds1.Tables[0].Rows[0][1].ToString();
            txtClass.Text = sClass;
            txtTel.Text = ds.Tables[0].Rows[0][10].ToString();
            pictureBox1.Image = new Bitmap(new MemoryStream((byte[])ds.Tables[0].Rows[0][1]));
            if (ds.Tables[0].Rows[0][9].ToString() == rdoMale.Text)
            {
                rdoMale.Checked = true;
                rdoFamale.Checked = false;
            }
            else if (ds.Tables[0].Rows[0][9].ToString() == rdoFamale.Text)
            {
                rdoMale.Checked = false;
                rdoFamale.Checked = true;
            }
            else
            {
                rdoMale.Checked = false;
                rdoFamale.Checked = false;
            }
        }
    }
}
