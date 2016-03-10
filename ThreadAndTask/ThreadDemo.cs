using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTask
{
    public class ThreadDemo
    {
        public void Run()
        {
            Thread t = new Thread(Work);
            Console.WriteLine("執行緒狀態:{0}", t.ThreadState);
            t.Start();
            Console.WriteLine("執行緒狀態:{0}", t.ThreadState);
            Thread.Sleep(100);
            t.Suspend();
            Console.WriteLine("執行緒狀態:{0}", t.ThreadState);
            Thread.Sleep(1000);
            Console.WriteLine("執行緒狀態:{0}", t.ThreadState);
            t.Resume();
            Console.WriteLine("執行緒狀態:{0}", t.ThreadState);
            t.Abort();
            Console.WriteLine("執行緒狀態:{0}", t.ThreadState);
            Thread.Sleep(1000);
            Console.WriteLine("執行緒狀態:{0}", t.ThreadState);


            Thread t2 = new Thread(Work2);
            Console.WriteLine("執行緒狀態:{0}", t2.ThreadState);
            t2.Start();
            Thread.Sleep(1000);
            Console.WriteLine("執行緒狀態:{0}", t2.ThreadState);
            Thread.Sleep(3000); //讓休眠結束
            Console.WriteLine("執行緒狀態:{0}", t2.ThreadState);
        }


        private void Work() 
        {
            for (int i = 0; i < 100000000; i++)
            {

            }
            Console.WriteLine("執行緒:{0}, 開始執行", Thread.CurrentThread.ManagedThreadId);
            while (true) 
            {
                for (int i = 0; i < 100000000; i++)
                {

                }
            };
        }

        private void Work2() 
        {
            Console.WriteLine("執行緒:{0}, 開始休眠", Thread.CurrentThread.ManagedThreadId);
            
            Thread.Sleep(3000);
            
            Console.WriteLine("執行緒:{0}, 休眠結束", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
