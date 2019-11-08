using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Sort
    {
        readonly int[] array;
        readonly int n;
        int temp;
        public Sort()
        {
            Console.WriteLine("无序数组：");
            Random r = new Random();
            n = r.Next(10, 16);
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        #region 直接插入
        public void InsertSort()
        {
            Console.WriteLine("直接插入排序-------");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                for (int x = 0; x < n; x++)
                {
                    Console.Write(array[x] + " ");
                }
                Console.WriteLine($"----------第{i + 1}次执行");
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public void BubbleSort()
        {
            for (var i = 0; i < n - 1; i++)
            {
                var exchange = false;
                for (var j = n - 2; j >= i; j--)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tempNum = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempNum;
                        exchange = true;
                    }
                }

                if (!exchange)
                {
                    break;
                }
            }

            for (int x = 0; x < n; x++)
            {
                Console.Write(array[x] + " ");
            }
        }
    }
}
