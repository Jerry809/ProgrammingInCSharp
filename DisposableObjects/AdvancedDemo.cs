using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    public class AdvancedDemo : IDisposable
    {        
        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool isDisposing) 
        {
            if (isDisposing)
            {
                /*---------------重點---------------*/
                /*告訴.NET此物件被回收時不需要呼叫Finalize方法*/ 
                GC.SuppressFinalize(this);
            }
            // release unmanaged resource code
            Console.WriteLine("release unmanaged resource");
        }
        ~AdvancedDemo() 
        {
            this.Dispose(false);
        }
    }
}
