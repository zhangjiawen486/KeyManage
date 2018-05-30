using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace KeyManage
{
    public partial class frmPutKeyTouch : Form
    {
        public frmPutKeyTouch()
        {
            InitializeComponent();
        }

        Thread fThread;
        Thread threadT;
        Thread threadT1;

        public String sName1 = "";
        public String sText = "";
        private String sStudent = "";
        private String sStudentID = "";
        private String sNumber = "";
        private String sSqlKey = new frmAdmin().sSqlKey;
        private String sSqlTouch = new frmAdmin().sSqlTouch;

        private void frmPutKeyTouch_Load(object sender, EventArgs e)
        {
            RefreshKey();
            txtSite.Text = sText.Substring(0, sText.IndexOf("钥匙"));
        }

        //刷新钥匙信息
        private void RefreshKey()
        {
            String sID = sName1.Substring(sName1.IndexOf("btn") + 3);
            DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlKey,"Record1", "Record1_Site", sID);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String sID1 = ds.Tables[0].Rows[i][0].ToString();
                String sTime = Convert.ToDateTime(ds.Tables[0].Rows[i][1]).ToString("MM月dd号 hh:mm");
                String sNumber = ds.Tables[0].Rows[i][3].ToString();
                lstKey.Items.Add(sTime + "   @学号：" + sNumber + "@       &" + sID1);
            }
        }

        //选择记录时触发
        private void lstKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKey.SelectedIndex < 0)
            {
                return;
            }
            String sNumber = lstKey.Text.Substring(lstKey.Text.IndexOf("：") + 1, lstKey.Text.IndexOf("@ ") - lstKey.Text.IndexOf("：") - 1);
            DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlTouch, "XueSheng", "XueHao", sNumber);
            if (ds.Tables[0].Rows.Count <= 0)
                return;
            txtNumber.Text = sNumber;
            pictureBox1.Image = new Bitmap(new MemoryStream((byte[])ds.Tables[0].Rows[0][1]));
            txtName.Text = ds.Tables[0].Rows[0][7].ToString();
            String sClass = ds.Tables[0].Rows[0][6].ToString();
            DataSet ds1 = new SqlFile.clsSql().sqlSelect3(sSqlTouch, "BanJi", "BanJiID", sClass);
            txtClass.Text = ds1.Tables[0].Rows[0][1].ToString();
        }

        //单击取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //单击确认按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstKey.SelectedIndex < 0)
            {
                MessageBox.Show("请先选择要归还的钥匙！");
                return;
            }
            label2.Text = "扫描中！";
            btnOK.Enabled = false;
            sNumber = txtNumber.Text;
            frmPutKeyTouch.CheckForIllegalCrossThreadCalls = false;//允许线程非安全调用窗体控件
            ThreadStart thr_start_func = new ThreadStart(VerifyFinger_Thread);
            fThread = new Thread(thr_start_func);
            fThread.Name = "VerifyFinger_Thread";
            fThread.Start();
        }

        frmLoading frmLoading1;
        //打开服务器访问进度条
        public void threadA()
        {
            frmLoading1 = new frmLoading();
            frmLoading1.str = "正在访问指纹服务》》》";
            frmLoading1.ShowDialog(this);
        }

        //打开指纹匹配进度条窗体
        public void threadB()
        {
            frmLoading1 = new frmLoading();
            frmLoading1.str = "正在进行指纹匹配。。。";
            frmLoading1.ShowDialog(this);
        }

        private void VerifyFinger_Thread()
        {
            while (true)
            {
                int lRV = 0;
                byte[] FingerBuf = new byte[304 * 256]; //图像缓冲区
                byte[] tzBuf = new byte[345];
                byte[] mbBuf = new byte[345];
                string strFileName = "";
                try
                {
                    lRV = OpticalDriver.mxGetImage(0, FingerBuf, 5000, 1);
                    if (lRV != 0)
                    {
                        label2.Text = GetErrorInfo(lRV);
                    }
                    else
                    {
                        strFileName += "image1.bmp";
                        //图像数据流保存成bmp

                        OpticalDriver.mxSaveBMP(strFileName, FingerBuf, 256, 304);
                        //显示图像
                        // this.pictureBox1.Image = Image.FromFile(strFileName);
                        lRV = OpticalDriver.mxGetTzBase64(FingerBuf, tzBuf);
                        if (lRV != 0)
                        {
                            label2.Text = "获取指纹特征失败";
                            // return;
                        }

                        threadT = new Thread(new ThreadStart(threadA));
                        threadT.Start();
                        DataSet XiangMu2 = new SqlFile.clsSql().RunProcedure(sSqlTouch, "chaxunyundongyuanzhiwenxinxipipei", new IDataParameter[] { }, "db");
                        if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                        {
                            Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                            frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                        }
                        if (threadT != null)
                            threadT.Abort();//关闭进程释
                        threadT1 = new Thread(new ThreadStart(threadB));
                        threadT1.Start();

                        int i;
                        for (i = 0; i < XiangMu2.Tables[0].Rows.Count; i++)
                        {
                            if (XiangMu2.Tables[0].Rows[i][2].ToString().Equals("") == false)
                            {
                                mbBuf = (byte[])XiangMu2.Tables[0].Rows[i][2];
                                //验证指纹
                                lRV = OpticalDriver.mxFingerMatchBase64(mbBuf, tzBuf, 3);
                                if (lRV == 0)
                                {
                                    sStudent = XiangMu2.Tables[0].Rows[i][1].ToString();
                                    sStudentID = XiangMu2.Tables[0].Rows[i][0].ToString();
                                    label2.Text = "指纹比对成功";
                                    if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                                    {
                                        Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                                        frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                                    }
                                    if (threadT != null)
                                        threadT.Abort();//关闭进程释
                                    RecordKey();
                                    btnOK.Enabled = true;
                                    this.Close();
                                    break;
                                }
                            }
                            if (XiangMu2.Tables[0].Rows[i][3].ToString().Equals("") == false)
                            {
                                mbBuf = (byte[])XiangMu2.Tables[0].Rows[i][3];
                                //验证指纹
                                lRV = OpticalDriver.mxFingerMatchBase64(mbBuf, tzBuf, 3);
                                if (lRV == 0)
                                {
                                    sStudent = XiangMu2.Tables[0].Rows[i][1].ToString();
                                    sStudentID = XiangMu2.Tables[0].Rows[i][0].ToString();
                                    label2.Text = "指纹比对成功";
                                    if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                                    {
                                        Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                                        frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                                    }
                                    if (threadT != null)
                                        threadT.Abort();//关闭进程释
                                    RecordKey();
                                    btnOK.Enabled = true;
                                    break;
                                }
                            }
                            if (XiangMu2.Tables[0].Rows[i][4].ToString().Equals("") == false)
                            {
                                mbBuf = (byte[])XiangMu2.Tables[0].Rows[i][4];
                                //验证指纹
                                lRV = OpticalDriver.mxFingerMatchBase64(mbBuf, tzBuf, 3);
                                if (lRV == 0)
                                {
                                    sStudent = XiangMu2.Tables[0].Rows[i][1].ToString();
                                    sStudentID = XiangMu2.Tables[0].Rows[i][0].ToString();
                                    label2.Text = "指纹比对成功";
                                    if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                                    {
                                        Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                                        frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                                    }
                                    if (threadT != null)
                                        threadT.Abort();//关闭进程释
                                    RecordKey();
                                    btnOK.Enabled = true;
                                    break;
                                }
                            }
                            if (XiangMu2.Tables[0].Rows[i][5].ToString().Equals("") == false)
                            {
                                mbBuf = (byte[])XiangMu2.Tables[0].Rows[i][5];
                                //验证指纹
                                lRV = OpticalDriver.mxFingerMatchBase64(mbBuf, tzBuf, 3);
                                if (lRV == 0)
                                {
                                    sStudent = XiangMu2.Tables[0].Rows[i][1].ToString();
                                    sStudentID = XiangMu2.Tables[0].Rows[i][0].ToString();
                                    label2.Text = "指纹比对成功";
                                    if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                                    {
                                        Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                                        frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                                    }
                                    if (threadT != null)
                                        threadT.Abort();//关闭进程释
                                    RecordKey();
                                    btnOK.Enabled = true;
                                    break;
                                }
                            }
                        }
                        if (i == XiangMu2.Tables[0].Rows.Count)
                        {
                            label2.Text = "指纹比对失败";
                            btnOK.Enabled = true;
                            //this.pictureBox1.Image = null;
                        }
                        if (frmLoading1.InvokeRequired)//判断是否有其他线程想访问
                        {
                            Action act = () => { frmLoading1.Close(); };//封装一个窗体关闭的方法
                            frmLoading1.Invoke(act);//在拥有该控件的线程上执行该方法
                        }
                        if (threadT1 != null)
                            threadT1.Abort();//关闭进程释
                        //pictureBox1.Image = Image.FromFile(strFileName);
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show(this, e.Message, "异常");
                }
                finally
                {
                    lRV = OpticalDriver.mxCancelGetImage(0);
                    btnOK.Enabled = true;
                    DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlTouch, "XueSheng", "XueHao",sNumber);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        String sClassID = ds.Tables[0].Rows[0][6].ToString();
                        //pictureBox1.Image = new Bitmap(new MemoryStream((byte[])ds.Tables[0].Rows[0][1]));
                        DataSet ds1 = new SqlFile.clsSql().sqlSelect3(sSqlTouch, "BanJi", "BanJiID", sClassID);
                        //txtClass.Text = ds1.Tables[0].Rows[0][1].ToString();
                    }
                    fThread.Abort();
                    // EnabledButton(true); ;
                }
            }
        }

        //输出错误原因
        private String GetErrorInfo(int ret)
        {
            string strInfo;
            switch (ret)
            {
                case -1:
                    strInfo = "打开设备失败";
                    break;
                case -2:
                    strInfo = "用户取消操作";
                    break;
                case -3:
                    strInfo = "等待手指超时";
                    break;
                case -4:
                    strInfo = "采集图像失败";
                    break;
                case -5:
                    strInfo = "上传图像失败";
                    break;
                case -10:
                    strInfo = "参数非法";
                    break;
                case -11:
                    strInfo = "设备已在获取图像操作";
                    break;
                case -12:
                    strInfo = "驱动安装失败";
                    break;
                default:
                    strInfo = "其他错误";
                    break;
            }
            return strInfo;
        }

        private void RecordKey()
        {
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口打开异常，错误原因。（" + ex + ")");
                return;
            }
            String sID = sName1.Substring(sName1.IndexOf("btn") + 3);
            String sID1 = lstKey.Text.Substring(lstKey.Text.IndexOf("&") + 1, lstKey.Text.Length - lstKey.Text.IndexOf("&") - 1);
            DataSet dsO = new SqlFile.clsSql().sql1(sSqlKey, "select * from Site where Site_ID = '" + sID + "' ");
            String sRoomClose = dsO.Tables[0].Rows[0][5].ToString();
            if (new SqlFile.clsSql().sql2(sSqlKey, "insert into Record (Record_Time,Record_Site,Record_User,Record_UserID,Record_Content) values (getdate(),'" + txtSite.Text + "','" + sStudent + "','" + sStudentID + "','还钥匙')"))
            {
                if (new SqlFile.clsSql().sql2(sSqlKey, "delete from Record1 where Record1_ID='" + sID1 + "'"))
                {
                    DataSet ds = new SqlFile.clsSql().sqlSelect3(sSqlKey, "Site", "Site_ID", sID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        String sKey = ds.Tables[0].Rows[0][4].ToString();
                        int iKey = Convert.ToInt32(sKey) + 1;
                        Byte[] B = new Byte[1];
                        B[0] = Byte.Parse(sRoomClose);
                        try
                        {
                            serialPort1.Write(B, 0, 1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("串口异常，错误原因。（" + ex + ")");
                        }
                        serialPort1.Close();
                        if (new SqlFile.clsSql().sql2(sSqlKey, "update Site set Site_Key = '" + iKey + "' where Site_ID = '" + sID + "'"))
                            MessageBox.Show("归还" + txtSite.Text + "教室的钥匙！成功！");
                        else
                            MessageBox.Show("修改钥匙数据失败！");
                    }
                    else
                        MessageBox.Show("修改钥匙数据失败！");
                }
                else
                    MessageBox.Show("删除借钥匙记录失败！");
            }
            else
                MessageBox.Show("添加记录失败！");
            this.Close();
        }

        private void frmPutKeyTouch_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fThread != null)
                fThread.Abort();
            OpticalDriver.mxCancelGetImage(0);
            clsFormStatic.frmPutKey1.RefreshBtn();
        }
    }
}
