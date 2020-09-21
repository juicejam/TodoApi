using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Demo
{
    class ThreadLearning
    {
        public void CallFunction()
        {
            ThreadJoin();

        }

        void ThreadJoin()
        {
            Thread t=new Thread(Go);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended");
        }

        static void Go() { for(int i=0; i<1000; i++) {
                Console.Write("y");
            }
    }
    }
}
