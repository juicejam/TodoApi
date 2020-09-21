using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class StringDemo
    {
        public byte[] ToBytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);

        }
    }
}
