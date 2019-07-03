using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.DrawingCore.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Demo
{

    public class AsyncDemo
    {
        class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        #region FirstRespondingUrl

        public static void ExecuteFirstRespondingUrl()
        {
            Task<string> t1 = Task.Run(() => FirstRespondingUrlAsync("https://www.cnblogs.com/",
                "https://www.cnblogs.com/artech/p/inside-asp-net-core.html"));
            t1.Wait();
            var result = t1.Result;
            var exception = t1.Exception;

        }

        private static async Task<string> FirstRespondingUrlAsync(string urlA, string urlB)
        {
            var httpClient = new HttpClient();
            //并发地执行两个下载任务
            Task<string> downloadTaskA = httpClient.GetStringAsync(urlA);
            Task<string> downloadTaskB = httpClient.GetStringAsync(urlB);
            //等待一个任务完成
            Task<string> completedTask = await Task.WhenAny(downloadTaskA, downloadTaskB);

            //返回从URL得到的数据
            string data = await completedTask;
            return data;

        }
        #endregion

        #region TaskWhenAll

        public static void ExecuteTaskWhenAll()
        {
            var t = Task.Run(ProcessTaskAsync);
            t.Wait();
        }

        static async Task<int> DelayAndReturnAsync(int val)
        {
            await Task.Delay(TimeSpan.FromSeconds(val));
            return val;
        }

        static async Task ProcessTaskAsync()
        {
            //创建任务队列
            Task<int> taskA = DelayAndReturnAsync(2);
            Task<int> taskB = DelayAndReturnAsync(3);
            Task<int> taskC = DelayAndReturnAsync(1);
            Task<int>[] tasks = new[] { taskA, taskB, taskC };


            var processingTasks = tasks.Select(async t =>
            {
                var result = await t;
                Trace.WriteLine($"{result}----------------------------------");
            }).ToArray();
            await Task.WhenAll(processingTasks);

            //顺序执行
            //foreach (var task in tasks)
            //{
            //    var result = await task;
            //    Trace.WriteLine(result);
            //}
        }



        #endregion

        #region ThrowExceptionAsync

        public static void ExecueteThrowException()
        {
            var t1=Task.Run(TestAsync);
            t1.Wait();
            var exception = t1.Exception;
        }

        static async Task ThrowExceptionAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            throw new InvalidOperationException("Test");
        }

        static async Task TestAsync()
        {
            //抛出异常并将其存储在Task中。
            Task task = ThrowExceptionAsync();
            try
            {
                //Task 对象被await调用，异常在这里再次被引发
                await task;
            }
            catch (InvalidOperationException e)
            {
                //这里异常被正确捕获
            }
        }

        #endregion

        #region Parallel

        public static void ExecuteParallelFor()
        {
            //var count = ParallelForFun(6000);
            //count.Item1.Sort();
            //count.Item1.ForEach(i => Console.Write(i + ","));

            //var n = ParallelSum(ParallelForFun(60).Item1);
            DoAction20Times(() =>
            {
            });
        }

        void RotateMatrices(IEnumerable<Matrix> matrices, float degrees)
        {
            Parallel.ForEach(matrices, matrix => matrix.Rotate(degrees));
        }

        static int ParallelSum(IEnumerable<int> values)
        {
            return values.AsParallel().Sum();
        }

        static (List<int>,int) ParallelForFun(int num)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long a = stopwatch.ElapsedMilliseconds;
            
            object mutex = new object();
            List<int> numList = new List<int>();
            ConcurrentBag<int> cList = new ConcurrentBag<int>();

            int count = 0;
            Parallel.For(1, num + 1, i =>
            {
                lock (mutex)
                {
                    numList.Add(i);
                    count++;
                }
            });
            long b = stopwatch.ElapsedMilliseconds;
            stopwatch.Stop();
            return (numList,count);
        }

        static void DoAction20Times(Action action)
        {
            Action[] actions = Enumerable.Repeat(action, 20).ToArray();
            Parallel.Invoke(actions);
        }

        #endregion

        #region UnitTest Demo

        public static async Task<bool> MyMethodAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return false;
        }

        public static async Task<int> DivideAsync(int a, int b)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            var result =  a / b;
            return result;
        }

        #endregion

        #region List

        public static void ConcurrentDictionaryMethod()
        {
            var dictionary = new ConcurrentDictionary<int, string>();
            dictionary[0] = "Zero";
            var newValue = dictionary.AddOrUpdate(0, key => "Zero", (key, oldValue) => "Zero");
        }

        #endregion

        #region 同步
        //同步三条件：多段代码、共享数据、修改数据

        public static void ExecuteSynchronizeCode()
        {
            //Console.WriteLine(BadParallelSum(new int[] { 1, 1, 1, 3, 4 }));
            var t= Task.Run(PlayWithStackAsync);
            t.Wait();
        }

        //坏代码
        static int BadParallelSum(IEnumerable<int> values)
        {
            int result = 0;
            Parallel.ForEach(source: values,
                localInit: () => 0,
                body: (item, state, localValue) => localValue + item,
                localFinally: localValue =>
                {
                    result += localValue;
                }
            );
            return result;
        }

        static async Task<bool> PlayWithStackAsync()
        {
            var stack = ImmutableStack<int>.Empty;
            var task1 = Task.Run(() => { stack.Push(3).Peek(); });//Peek() 返回堆栈顶部的对象而不删除它。
            var task2 = Task.Run(() => { stack = stack.Push(5); });
            var task3 = Task.Run(() => { stack = stack.Push(7); });
            await Task.WhenAll(task1, task2, task3);
            return stack.IsEmpty;
        }

        #endregion

        #region 阻塞锁

        public void ExecuteBlockMethod()
        {
            var t1 = Task.Run(() => BlockingLockClass.Increment());
            
            t1.Wait();
        }

        static class BlockingLockClass
        {
            //这个锁会保护 _value
            private static readonly object Mutex = new object();
            private static int _value;
            private static int _noLockValue;

            public static void Increment()
            {
                lock (Mutex)
                {
                    _value = _value + 1;
                }
            }

            public static void NoLockMethod()
            {
                _noLockValue = _noLockValue + 1;
            }
        }

        #endregion

        #region 异步锁

        static class AsyncLockClass
        {
            //这个锁保护_value
            private static readonly SemaphoreSlim Mutex=new SemaphoreSlim(1);
            private static int _value;

            public static async Task DelayAndIncrementAsync()
            {
                await Mutex.WaitAsync();
                try
                {
                    var oldValue = _value;
                    await Task.Delay(TimeSpan.FromSeconds(oldValue));
                    _value = oldValue + 1;
                }
                finally
                {
                    Mutex.Release();
                }
            }
        }

        #endregion
    }
}
