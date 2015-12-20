using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVSEvent
{
    class HasReturnValueDelegate
    {
        /// <summary>
        /// 定義一個委派
        /// </summary>
        /// <remarks>
        /// Delegate 定義要傳入的方法 ，回傳string
        /// </remarks>  
        /// <returns>回傳字串</returns>
        private delegate string MyDelegate();

        public void Main()
        {
            MyDelegate d = new MyDelegate(PrintMessage1);

            // 也可以不用new MyDelegate ， 直接指定方法
            d += PrintMessage2;

            foreach (Delegate item in d.GetInvocationList())
            {
                string message = item.DynamicInvoke().ToString();
                Console.WriteLine(message);
                // output1: 訊息一
                // output2: 訊息二
            }              
        }


        private static string PrintMessage1()
        {
            return "訊息一";
        }

        private static string PrintMessage2()
        {
            return "訊息二";
        }
    }
}
