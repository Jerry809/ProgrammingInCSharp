using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Main main = new Main();
            Console.WriteLine("步驟 1 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            Task<int> sum = main.GetSumAsync(1, 10);
            Console.WriteLine("步驟 5 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("結果:" + sum.Result); // output : 22
            Console.WriteLine("步驟 6 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            
            Console.Read();
        }

    }
}
