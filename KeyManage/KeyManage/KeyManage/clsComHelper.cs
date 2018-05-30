using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace KeyManage
{
    class clsComHelper
    {
        /// <summary>初始化串行端口</summary>
        private SerialPort _serialPort;

        public SerialPort serialPort
        {
            get { return _serialPort; }
            set { _serialPort = value; }
        }

        /// <summary>
        /// COM口通信构造函数
        /// </summary>
        /// <param name="PortID">通信端口</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="parity">奇偶校验位</param>
        /// <param name="dataBits">标准数据位长度</param>
        /// <param name="stopBits">每个字节的标准停止位数</param>
        /// <param name="readTimeout">获取或设置读取操作未完成时发生超时之前的毫秒数</param>
        /// <param name="writeTimeout">获取或设置写入操作未完成时发生超时之前的毫秒数</param>
        public clsComHelper()
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = "COM3" ;//通信端口
                serialPort.BaudRate = 2400;//波特率
                serialPort.Encoding = Encoding.ASCII;
                serialPort.Parity = 0;//奇偶校验位
                serialPort.DataBits = 8;//标准数据位长度
                serialPort.StopBits =(StopBits)1;//每个字节的标准停止位数
                serialPort.ReadTimeout = 1000;//获取或设置读取操作未完成时发生超时之前的毫秒数
                serialPort.WriteTimeout = 1000;//获取或设置写入操作未完成时发生超时之前的毫秒数
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        /// <summary>
        /// 打开COM口
        /// </summary>
        /// <returns>true 打开成功；false 打开失败；</returns>
        public bool Open()
        {
            try
            {
                if (serialPort.IsOpen == false)
                {
                    serialPort.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        /// <summary>
        /// 关闭COM口
        /// </summary>
        /// <returns>true 关闭成功；false 关闭失败；</returns>
        public bool Close()
        {
            try
            {
                serialPort.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断端口是否打开
        /// </summary>
        /// <returns></returns>
        public bool IsOpen()
        {
            try
            {
                return serialPort.IsOpen;
            }
            catch { throw; }
        }

        /// <summary>
        /// 向COM口发送信息
        /// </summary>
        /// <param name="sendData">16进制的字节</param>
        public void WriteData(byte[] sendData)
        {
            try
            {
                if (IsOpen())
                {
                    Thread.Sleep(5);
                    serialPort.Write(sendData, 0, sendData.Length);
                }
            }
            catch { throw; }
        }

        /// <summary>
        /// 接收来自COM的信息
        /// </summary>
        /// <returns>返回收到信息的数组</returns>
        public string[] ReceiveDataArray()
        {
            try
            {
                Thread.Sleep(5);
                if (!serialPort.IsOpen) return null;
                int DataLength = serialPort.BytesToRead;
                byte[] ds = new byte[DataLength];
                int bytecount = serialPort.Read(ds, 0, DataLength);
                return ByteToStringArry(ds);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 把字节型转换成十六进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string[] ByteToStringArry(byte[] bytes)
        {
            try
            {
                string[] strArry = new string[bytes.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    strArry[i] = String.Format("{0:X2} ", bytes[i]).Trim();
                }
                return strArry;
            }
            catch { throw; }
        }

        /// <summary>
        /// 清除缓存数据
        /// </summary>
        public void ClearDataInBuffer()
        {
            try
                {
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
            }
            catch { throw; }
        }
    }
}
