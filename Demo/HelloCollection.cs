using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class HelloCollection
    {
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
