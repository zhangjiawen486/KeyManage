using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace KeyManage
{
    class clsPassword
    {
        [DllImport("kernel32")]//--引入API
        //声明读写ini文件的API函数
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //新建INI文件
        public void IniNew()
        {
            FileStream fs = new FileStream("\\KeyManage" + ".ini", FileMode.Create, FileAccess.ReadWrite);
            IniWriteValue("Password", "0");
            fs.Flush();
            fs.Close();
        }

        //写INI文件 （名称，内容）
        public void IniWriteValue(string Key, string Value)
        {
            string str = System.AppDomain.CurrentDomain.BaseDirectory;
            WritePrivateProfileString("Admin", Key, Value, str + "\\KeyManage.ini");
        }

        //读取INI文件指定 （名称）
        public string IniReadValue(string Key)
        {
            string str = System.AppDomain.CurrentDomain.BaseDirectory;
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString("Admin", Key, "", temp, 255, str + "\\KeyManage.ini");
            return temp.ToString();
        }
    }
}
