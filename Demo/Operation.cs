using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Operation
    {
        public static Tuple<int,int>  Fun1()
        {
            var fibonacciNumbers = new List<long> { 1, 1 };
            for (int i = 2; i < 20; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
            }
            Tuple<int,int> t=new Tuple<int, int>(1,2);
            return t;
        }

        public static (int,int) Fun2()
        {
            var fibonacciNumbers = new List<long> { 1, 1 };
            for (int i = 2; i < 20; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
            }
            Tuple<int, int> t = new Tuple<int, int>(1, 2);
            return (1, 2);
        }
    }
}
