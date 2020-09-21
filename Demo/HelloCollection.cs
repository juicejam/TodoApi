using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class HelloCollection
    {
        public void CallFunction()
        {
            CallUniqueV2();

        }

        void CallUniqueV2()
        {
            var s = UniqueV2(new[] { 1, 3, 1, 2, 5, 7, 8, 1, 2, 7, 4 });

            foreach (var num in s)
            {
                Console.WriteLine(num);
            }
        }

        IEnumerable<int> UniqueV2(IEnumerable<int> nums)
        {
            var uniqueVals = new HashSet<int>();
            Console.WriteLine("\t进入");
            foreach (var num in nums)
            {
                Console.WriteLine($"循环{num}");
                if (!uniqueVals.Contains(num))
                {
                    Console.WriteLine($"添加{num}");
                    uniqueVals.Add(num);
                    yield return num;
                    Console.WriteLine($"循环结束");
                }
            }

            Console.WriteLine("方法结束");
        }




        /// <inheritdoc />
        // ReSharper disable once FunctionRecursiveOnAllPaths
        public HelloCollection()
        {
            HelloCollection h = new HelloCollection();
            var enumerator = h.GetEnumerator();
            foreach (var item in enumerator)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerable<int> GetEnumerator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
