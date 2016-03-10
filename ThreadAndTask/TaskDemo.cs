using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTask
{
    public class TaskDemo
    {
        public void Run() 
        {
            Task<int> task = Task.Run<int>
                            (
                                () => Enumerable.Range(0,10000).Sum(x => x)
                            );

            Console.WriteLine("程式執行中....");
            Console.WriteLine("取得結果:{0}",task.Result); // 如果Task還沒結束，則執行緒會停在這邊
        }

        public void Run2() 
        {
            Task<int> task = Task.Run<int>
                (
                    () => Enumerable.Range(0, 10000).Sum(x => x)
                );
            task.ContinueWith(x => 
            {
                // Task任務結束後，會直接跑這段程式碼
                var sum = x.Result;
                Console.WriteLine("接續作業取值:{0}",sum);
            });

            Console.WriteLine("程式執行中....");            
            Console.WriteLine("取得結果:{0}", task.Result); // 使用接續作業，不影響其他地方取得Result屬性
        }

        public void Run3()
        {
            Task<int> task = Task.Run<int>
                (
                    () => Enumerable.Range(0, 10000).Sum(x => x)
                );
            TaskAwaiter<int> awaiter = task.GetAwaiter();
            awaiter.OnCompleted(() => 
            {
                // Task任務結束後，會直接跑這段程式碼
                var sum = awaiter.GetResult();
                Console.WriteLine("接續作業取值:{0}", sum);
            });

            Console.WriteLine("程式執行中....");
            Console.WriteLine("取得結果:{0}", task.Result); // 使用接續作業，不影響其他地方取得Result屬性
        }

        public void Run4() 
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("執行中....");
                    Thread.Sleep(3000);
                }

                // 接受到取消的指令，拋出OperationCanceledException，停止Task的執行
                token.ThrowIfCancellationRequested();
            }, token);
            
            try
            {
                Console.WriteLine("Press enter to cancel the task");
                Console.ReadLine();

                // 取消Task執行
                cancellationTokenSource.Cancel();
                
                // 等待任務完成
                task.Wait();

            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
                Console.WriteLine("已取消完成");
            }
        }

        private void GetAvailable()
        {

        }
    }
}
