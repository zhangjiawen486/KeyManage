using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace KeyManage
{
    public abstract class OpticalDriver
    {
	    /**********************************************************************
	    功	能：读取驱动库版本
	    参  数：szVersion    - 驱动库版本(小于100字节)
	    返  回：0 - 成功  
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetDllVersion(Byte[] Version);

        /**********************************************************************
        功	能：获取设备个数
        参	数：iDeviceNum - 设备个数
        返回值：   
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetDeviceNum(Byte[] iDeviceNum);

        /**********************************************************************
        功	能：获取指纹图像
	    参	数：iDeviceIndex - 设备序号(从0开始)
			    ucImgBuf     - 接收图像数据缓存指针
			    nTimeOut     - 超时时间，单位：毫秒,如果nTimeOut=0，则表示无限时等待
			    iFlagLeave   - 是否等待手指离开，0-否，1-是
	    返	回:  0   - 成功
	    		其他 - 失败
	    备	注：-1   - 打开USB设备失败	
			    -2   - 用户取消操作
			    -3   - 等待手指超时
			    -4   - 采集图像失败
			    -5   - 上传图像失败
			    -10  - 参数非法
			    -11  - 设备已在获取图像操作
			    -12  - 驱动尚未安装 
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetImage(int iDeviceIndex, Byte[] imageBuf,int nTimeOut,int iFlagLeave);
        
        /**********************************************************************
        功	能：取消正在进行获取指纹图像操作
	    参	数：iDeviceIndex - 设备序号(从0开始)
	    返回值：    
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxCancelGetImage(int iDeviceIndex);

        /**********************************************************************
        功	能：读取设备版本
	    参  数：iDeviceIndex - 设备序号(从0开始)
			    szVersion    - 设备版本(小于100字节)
	    返  回：   
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetDeviceVersion(int iDeviceIndex,Byte[] szVersion);
 
        /**********************************************************************
        功  能：读厂商标识
	    参  数：iDeviceIndex - 设备序号(从0开始)
			    szDeviceLogo - 厂商标识,24字节
	    返回值：0    - 操作成功
			    其他 - 操作失败
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetDeviceLogo(int iDeviceIndex,Byte[] szDeviceLogo);

        /**********************************************************************
        功  能：读取BMP图像
	    参  数：strFileName  - BMP图像路径
			    pImage       - 图像缓存
			    pWidth       - 图像宽度
			    pHeight      - 图像高度
	    返回值：0    - 操作成功
			    其他 - 操作失败
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxReadBMP(string strFileName, Byte[] pImage, Byte[] pWidth, Byte[] pHeight);

        /**********************************************************************
        功  能：保存BMP图像
	    参  数：strFileName  - BMP图像路径
			    pImage       - 图像缓存
			    iWidth       - 图像宽度
			    iHeight      - 图像高度
	    返回值：0    - 操作成功
			    其他 - 操作失败
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxSaveBMP(string strFileName, Byte[] pImage, int iWidth, int iHeight);

        /**********************************************************************
        功	能：读取算法版本
	    参  数：szVersion    - 算法版本(小于100字节)
	    返  回：0 - 成功 
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetAlgVersion(Byte[] szVersion);

        /**********************************************************************
        功  能：从指纹图象中抽取特征。
	    参  数：input  － 输入，指纹图象缓冲，大小为256×304字节（二进制码）；
			    tzBuf  － 输出，指针指向现场录入的指纹特征，344字节（Base64码）。
	    返  回：   0   － 特征抽取成功；
			      -1   － 特征抽取失败。  
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetTzBase64(Byte[] input,Byte[] tzBuf);

        /**********************************************************************
        功  能：从三个指纹特征中合并指纹模板。
	    参  数：tzBuf1 － 输入，指向指纹特征1的指针，344字节（Base64码）；
			    tzBuf2 － 输入，指向指纹特征2的指针，344字节（Base64码）；
			    tzBuf3 － 输入，指向指纹特征3的指针，344字节（Base64码）；
			    mbBuf  － 输出，指向指纹模板的指针 ，344字节（Base64码）；
	    返  回：   0   － 合并模板成功
			      -1   － 合并模板失败   
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxGetMBBase64(Byte[] tzBuf1,Byte[] tzBuf2,Byte[] tzBuf3,Byte[] nbBuf);
    
        
        /**********************************************************************
        功  能：比对指纹特征和指纹模板。
	    参  数：mbBuf － 输入，指向指纹模板的指针，344字节（Base64码）；
			    tzBuf － 输入，指向指纹特征的指针，344字节（Base64码）；
			    level － 输入，安全等级，1-5级，级别越高，越安全，一般取3
	    返	回：  0   － 比对成功
			     -1   － 比对失败 
        **********************************************************************/
        [DllImport("mxOpticalDriver.dll")]
        public static extern int mxFingerMatchBase64(Byte[] mbBuf,Byte[] tzBuf,int iLevel);


        [DllImport("mxOpticalDriver.dll")]
        public static extern void mxCancelGetImage();

         [DllImport("mxOpticalDriver.dll")]
        public static extern int IsMxGetImage();
    }
}
