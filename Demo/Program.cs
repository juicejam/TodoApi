using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = Operation.Fun1();
            var f2 = Operation.Fun1();
            var h1= f1.GetHashCode();
            var h2 = f2.GetHashCode();
            var update = string.Empty;
        }
    }
}
