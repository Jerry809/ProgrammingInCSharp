using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            WeakReference w;

            using (var hugeClass = new HugeClass())
            {
                w = new WeakReference(hugeClass);
            }
            
            // 直接從記憶體取回HugeClass
            HugeClass originalHugeClass = w.Target as HugeClass;

            originalHugeClass.Main(); // output : I'm Huge


        }
    }

    class HugeClass : IDisposable
    {
        public void Main() { Console.WriteLine("I'm Huge"); }

        public void Dispose()
        {
            
        }
    }
}
