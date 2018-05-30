using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace IniFile
{
    public class clsIni
    {
        [DllImport("kernel32")]//--引入API
        //声明读写ini文件的API函数
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //新建INI文件(文件名)
        public void IniNew(String sFile)
        {
            FileStream fs = new FileStream("\\sqlConfig"+".ini",FileMode.Create,FileAccess.ReadWrite);
            IniWriteValue("Server", "", sFile);
            IniWriteValue("Database", "", sFile);
            IniWriteValue("UserName", "", sFile);
            IniWriteValue("Password", "", sFile);
            fs.Flush();
            fs.Close();
        }

        //写INI文件 （名称，内容，文件名）
        public void IniWriteValue(string Key, string Value ,string sFile)
        {
            string str = System.AppDomain.CurrentDomain.BaseDirectory;
            WritePrivateProfileString("SQL", Key, Value, str + "\\" + sFile + ".ini");
        }

        //读取INI文件指定 （名称,文件名）
        public string IniReadValue(string Key,string sFile)
        {
            string str = System.AppDomain.CurrentDomain.BaseDirectory;
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString("SQL", Key, "", temp, 255, str + "\\" + sFile + ".ini");
            return temp.ToString();
        }
    }
}
