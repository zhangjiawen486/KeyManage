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
    public partial class frmRecord : Form
    {
        public frmRecord()
        {
            InitializeComponent();
        }

        private String sSqlKey = new frmAdmin().sSqlKey;
        private String sSqlTouch = new frmAdmin().sSqlTouch;
        DataTable dt = new DataTable();

        //刷新纪录
        private void Refresh123()
        {
            DataSet ds = new SqlFile.clsSql().sql1(sSqlKey,"select *from Record order by Record_Time desc");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                String sSite = ds.Tables[0].Rows[i][2].ToString();
                String sUser = ds.Tables[0].Rows[i][3].ToString();
                String sUserID = ds.Tables[0].Rows[i][4].ToString();
                String sContent = ds.Tables[0].Rows[i][5].ToString();
                dr[0] = ds.Tables[0].Rows[i][1];
                dr[1] = sSite;
                dr[2] = sUser;
                dr[3] = sUserID;
                dr[4] = sContent;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 238;
        }

        //单击刷新按钮
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh123();
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("时间", typeof(System.DateTime));
            dt.Columns.Add("教室", typeof(System.String));
            dt.Columns.Add("用户", typeof(System.String));
            dt.Columns.Add("学号", typeof(System.String));
            dt.Columns.Add("事件", typeof(System.String));
            dt.Columns["时间"].ReadOnly = false;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 238;
            Refresh123();
        }

        //双击单元格时触发
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmRecordLook frmRecordLook1 = new frmRecordLook();
            frmRecordLook1.sNumber = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            frmRecordLook1.ShowDialog();
        }
    }
}
