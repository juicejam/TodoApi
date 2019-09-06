using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            Sort s = new Sort();
            s.InsertSort();


        }

        public class HelloCollection : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return "Hello";
                yield return "World";
            }
        }





    }
}
