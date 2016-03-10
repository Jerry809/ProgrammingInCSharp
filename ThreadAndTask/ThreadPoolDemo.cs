using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTask
{
    public class ThreadPoolDemo
    {
        public void Run() 
        { 
            string message = "Some Message";
            bool result = System.Threading.ThreadPool.QueueUserWorkItem(Work, message);

            // 如果執行緒分配成功 result = true
            if (result)
            {
                Console.WriteLine("執行緒分配成功，按Enter可結束主執行緒，接著背景執行緒會被關閉");
            }
            else
            {
                // 分配執行緒失敗
            }

            Console.Read();
        }

        private void Work(object data)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("背景執行緒工作執行中: {0}", data.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}
