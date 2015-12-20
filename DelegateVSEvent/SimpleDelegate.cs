using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVSEvent
{
    public class SimpleDelegate
    {
        /// <summary>
        /// 定義一個委派
        /// </summary>
        /// <remarks>
        /// Delegate 定義要傳入的方法 ，無回傳值、傳入一個int參數
        /// </remarks>
        /// <param name="i">委派要傳入的參數</param>
        private delegate void MyDelegate(int i);

        public void Main() 
        {
            // 呼叫委派，並傳入method
            MyDelegate d = new MyDelegate(PrintMessage);

            //執行委派，傳入參數
            // 寫法一:
            d.Invoke(100);
            // 寫法二:
            d(100);

            // 寫法一 與 寫法二 執行結果是一模一樣的
        }

        /// <summary>
        /// 符合Delegate定義的方法的method
        /// </summary>
        /// <param name="i"></param>
        private void PrintMessage(int i)
        {
            Console.WriteLine("i * i = " + i * i);
        }

    }
}
