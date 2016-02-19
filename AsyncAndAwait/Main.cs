using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    public class Main
    {
        public async Task<int> GetSumAsync(int a, int b) 
        {            
            Console.WriteLine("步驟 2 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
            int result = await GetDoubleSumAsync(a, b);
            Console.WriteLine("步驟 4 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);            
            return result;
        }

        private async Task<int> GetDoubleSumAsync(int a, int b) 
        {            
            return await Task.Run(() => 
            {
                Thread.Sleep(500);
                Console.WriteLine("步驟 3 => ThreadID : " + Thread.CurrentThread.ManagedThreadId);
                return a + a + b + b; 
            });
        }
    }
}
