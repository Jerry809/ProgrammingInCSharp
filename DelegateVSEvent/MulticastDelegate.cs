using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVSEvent
{
    class MulticastDelegate
    {
        /// <summary>
        /// 定義一個委派
        /// </summary>
        /// <remarks>
        /// Delegate 定義要傳入的方法 ，無回傳值
        /// </remarks>        
        private delegate void MyDelegate();

        public void Main() 
        {
            // 鏈式委派 寫法一
            MyDelegate d = new MyDelegate(PrintMessage1);
            d += new MyDelegate(PrintMessage2);
            d += new MyDelegate(PrintMessage3);

            d();
            // output:
            // 執行方法一
            // 執行方法二
            // 執行方法三

            /*-----------------------------------------------------*/

            // 鏈式委派 寫法二
            MyDelegate handler1 = new MyDelegate(PrintMessage1);
            MyDelegate handler2 = new MyDelegate(PrintMessage2);
            MyDelegate handler3 = new MyDelegate(PrintMessage3);
            MyDelegate handlerHead = handler1 + handler2 + handler3;
            handlerHead();

            // output:
            // 執行方法一
            // 執行方法二
            // 執行方法三
        }

        private void PrintMessage1()
        {
            Console.WriteLine("執行方法一");
        }

        private void PrintMessage2()
        {
            Console.WriteLine("執行方法二");
        }

        private void PrintMessage3()
        {
            Console.WriteLine("執行方法三");
        }
    }
}
