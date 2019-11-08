using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Demo.Tools
{
    public static class Md5
    {
        /// <summary>
        /// 32位 小写 MD5加密
        /// </summary>
        public static string ConvertMd5(string Str, bool isUpper = false)
        {
            var bytes = new MD5CryptoServiceProvider().ComputeHash(Str.ToBytes(Encoding.UTF8));
            string ret = "";
            foreach (byte bb in bytes) { ret += Convert.ToString(bb, 16).PadLeft(2, '0'); }
            var result = ret.PadLeft(32, '0');
            return isUpper ? result.ToUpper() : result.ToLower();
        }


        public static byte[] ToBytes(this string data, Encoding encoding)
        {
            data = data ?? "";
            return encoding.GetBytes(data);
        }
    }
}
