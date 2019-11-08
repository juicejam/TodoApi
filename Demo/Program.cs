using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.JsonPath.LambdaCompilation.ObjectDynamicExtension;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Demo.Tools;

namespace Demo
{
    static class Program
    {

        static void Main(string[] args)
        {
            //Operation.ExecuteFunc();
            //AsyncDemo.ExecuteFirstRespondingUrl();
            //AsyncDemo.ExecuteTaskWhenAll();
            //AsyncDemo.ExecueteThrowException();
            //AsyncDemo.ExecuteParallelFor();
            //AsyncDemo.ConcurrentDictionaryMethod();
            //AsyncDemo.ExecuteSynchronizeCode();
            //AsyncDemo.ExecuteBlockMethod();
            //AsyncDemo.ExecuteAsyncLockMethod();
            //AsyncDemo.Scheduling();
            //Sort s = new Sort();
            //s.InsertSort();
            //s.BubbleSort();

            //We know that musical tastes begin to crystallize as early as age 13 or 14. By the time we're in our early 20s,these tastes get
            //locked into place pretty firmly.
            var a1 =new int[1,2,3];
            var a2 = new int[3, 4, 5];

            //var necessary = new string[]
            //{
            //    "memberClass", "name", "gender", "birthday", "cardType", "cardNo", "phone", "joinDate",
            //    "memberPassword", "regMall"
            //};
            //necessary = new string[]{};
            //if (necessary == null || ((string[])necessary).Length == 0)
            //{
            //    Console.WriteLine("空");
            //}
            //else
            //{
            //    Console.WriteLine("通过");
            //}

            var allowFileds = new[]
            {
                "name:realName","gender:genderValue","cardtype:cardTypeValue","cardno","email","country","province","city","county","address","subscribenews"
            };
            foreach (var item in allowFileds)
            {
                Console.Write(item.IndexOf(':'));
                var requestField = item.Substring(0, item.IndexOf(':'));
                var fff = item.Substring(item.IndexOf(':')+1);
                Console.Write(requestField);
                Console.WriteLine("---"+fff);
            }


            Console.ReadKey();
        }

    }
    public enum Member_Gender
    {
        男 = 1,
        女 = 2,
        未知 = 0,
    }

    public enum enumColor
    {
        Red = 1,
        Yellow,
        Green,
        Blue,
        White,
        Black
    }



}
