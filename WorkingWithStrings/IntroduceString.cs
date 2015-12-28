using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    public class IntroduceString
    {
        public void Main() 
        {
            string a = "I'm String";

            // b指向a的參考
            string b = a;

            // 指向同一個參考
            Console.WriteLine(Object.ReferenceEquals(a, b)); //output : ture

            // b 指定新字串
            b = "New String";

            // 結果指向不同參考
            Console.WriteLine(Object.ReferenceEquals(a, b)); //output : false

            Console.WriteLine("a = " + a); // output : a = I'm String

            Console.WriteLine("b = " + b); // output : b = New String
        }
    }
}
