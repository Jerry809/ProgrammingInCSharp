using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThreadDemo t = new ThreadDemo();
            //t.Run();

            //Console.Read();
            //TaskDemo t = new TaskDemo();
            //t.Run();
            //t.Run2();
            //t.Run3();
            //t.Run4();

            //ThreadPoolDemo t = new ThreadPoolDemo();
            //t.Run();

            ConcurrentCollectionsDemo ccd = new ConcurrentCollectionsDemo();
            //ccd.Run();
            ccd.Run2();
            ccd.Run3();
            //ccd.Run4();
            //ccd.Run5();
            //ccd.Run6();

        }
    }
    
}
