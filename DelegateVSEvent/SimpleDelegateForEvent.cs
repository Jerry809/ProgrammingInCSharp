using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVSEvent
{
    public class SimpleDelegateForEvent
    {
        public event EventHandler MyEvent;

        public void DomSomething() 
        {
            if (MyEvent != null)
            {
                MyEvent(this, EventArgs.Empty);
            }
        }

    }
}
