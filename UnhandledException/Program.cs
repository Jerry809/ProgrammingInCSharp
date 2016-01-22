using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnhandledException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestThrowException();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("不管有沒有Exception都會跑到這段finally");
            }
        }

        private static void TestThrowException() 
        {
            decimal a = 5;
            decimal b = 0;
            decimal result = a / b;

            Console.WriteLine(result);
        }
    }
}
