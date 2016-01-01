using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    public class Demo :IDisposable
    {
        public void DoSomething() 
        {
            Console.WriteLine("working");
        }

        public void Dispose()
        {
            // release unmanaged resource code
            Console.WriteLine("release unmanaged resource");
        }

        // Finalize 解構方法
        ~Demo() 
        {
            // release unmanaged resource code
            Console.WriteLine("release unmanaged resource by Finalize");
        }
    }
}
