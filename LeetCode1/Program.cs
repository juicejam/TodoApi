﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.ExecuteReverse();
            //p.ExecuteIsPalindrome();
            p.ExeRemanToInt();

        }

        #region 7.给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

        void ExecuteReverse()
        {
            Console.WriteLine(Reverse(2147483641));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Reverse(int x)
        {
            if (x == 0)
            {
                return x;
            }

            bool minus = x < 0;
            var str = x.ToString().TrimStart('-').TrimEnd('0').Reverse();

            try
            {
                x = Convert.ToInt32(string.Join("", str));
            }
            catch (Exception e)
            {
                x = 0;
            }
            
            return minus ? -x : x;
        }
        #endregion

        #region 9.判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
        void ExecuteIsPalindrome()
        {
            //var result = IsPalindrome2(121);
            //Console.WriteLine(result);
            string str = Guid.NewGuid().ToString().Substring(0, 6);
            Console.WriteLine(str); 
        }


        public bool IsPalindrome(int x)
        {
            string array = string.Join("", x.ToString().Reverse());

            return x.ToString() == array;
        }

        public bool IsPalindrome2(int x)
        {
            if (x<0)
            {
                return false;
            }
            int r = 0;
            int temp = x;
            while (temp != 0)
            {
                r = r * 10 + temp % 10;
                temp = temp / 10;
            }

            return r == x;
        }

        #endregion

        #region 罗马数字转整数
        //罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。
        //字符 数值
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000
        //例如， 罗马数字 2 写做 II ，即为两个并列的 1。12 写做 XII ，即为 X + II 。 27 写做 XXVII, 即为 XX + V + II 。
        //通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，
        //所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：
        //I 可以放在 V(5) 和 X(10) 的左边，来表示 4 和 9。
        //X 可以放在 L(50) 和 C(100) 的左边，来表示 40 和 90。 
        //C 可以放在 D(500) 和 M(1000) 的左边，来表示 400 和 900。
        //给定一个罗马数字，将其转换成整数。输入确保在 1 到 3999 的范围内。
        public void ExeRemanToInt()
        {
            string str = "MCMXCIV";
            Console.WriteLine(RomanToInt(str));
        }

        public int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int num = 0;
            var specialDic = new Dictionary<string, int>
            {
                {"IV",4 },
                {"IX",9 },
                {"XL",40 },
                {"XC",90 },
                {"CD",400 },
                {"CM",900 }
            };
            var list = new List<string>();
            foreach (var item in specialDic)
            {
                if (s.Contains(item.Key))
                {
                    list.Add(item.Key);
                    s = s.Remove(s.IndexOf(item.Key, StringComparison.Ordinal), 2);
                }
            }

            var dic = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            
            foreach (var c in s.ToArray())
            {
                num += dic[c];
            }

            list.ForEach(m => num += specialDic[m]);
            return num;
        }
        #endregion
    }
}
