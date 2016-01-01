using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.DoSomething();// output : working
            GC.Collect();  // output :release unmanaged resource by Finalize
            Console.Read();
            //using (Demo d = new Demo())
            //{
            //    d.DoSomething(); // output : working
            //} 
            //// output : release unmanaged resource

            //Demo d = new Demo();
            
            //try
            //{
            //    d.DoSomething(); // output : working
            //}
            //finally
            //{
            //    d.Dispose(); // output : release unmanaged resource
            //}
        }
    }
}
