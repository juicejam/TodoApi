using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Demo.Tools
{
    public static class Tool
    {

        public static string Timestamp()
        {
            System.DateTime startTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string timestamp = ((long)(DateTime.UtcNow - startTime).TotalSeconds).ToString();
            return timestamp;
        }

        public static string EscapeDataString(string uri)
        {
            return Uri.EscapeDataString(uri);
        }
    }
}
