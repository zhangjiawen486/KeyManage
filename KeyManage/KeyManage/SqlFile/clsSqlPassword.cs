using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace SqlFile
{
    class clsSqlPassword
    {
        //简单的MD5加密
        public String MD5Pass(String str)
        {
            MD5 m = new MD5CryptoServiceProvider();
            byte[] data = Encoding.Default.GetBytes(str);
            byte[] result = m.ComputeHash(data);
            String str1 = "";
            try
            {
                for (int i = 0; i < result.Length; i++)
                {
                    str1 += result[i].ToString("x").PadLeft(2, '0');
                }
                return str1;
            }
            catch
            {
                return str;
            }
        }

        //字符加密运算
        public String InPass(String str)
        {
            String s = "";
            try
            {
                for (int i = 0; i < str.Length;i++ )
                {
                    s += (char)(str[i] + 10 - 1 * 2);
                }
                return s;
            }
            catch
            {
                return str;
            }
        }

        //字符反向解密运算
        public String OutPass(String str)
        {
            String s = "";
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    s += (char)(str[i] - 10 - 1 * 2);
                }
                return s;
            }
            catch
            {
                return str;
            }
        }

        //秘钥向量
        private byte[] bKey = {0xA1,0xB2,0xC3,0xD4,0x4D,0x3C,0x2B,0x1A};

        //加密秘钥
        private String sKey = "12345678";

        //秘钥加密算法
        public String InPassword(String str)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(sKey.Substring(0, 8));
                byte[] rgbIV = bKey;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(str);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return str;
            }
        }

        //秘钥解密算法
        public String OutPassword(String str)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(sKey);
                byte[] rgbIV = bKey;
                byte[] inputByteArray = Convert.FromBase64String(str);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return str;
            }
        }
    }
}
