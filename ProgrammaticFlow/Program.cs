using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowThrow();
        }

        private static void ShowThrow() 
        {
            if (true)
            {
                // 整個應用程式會停掉，且拋出Exception訊息
                throw new Exception();
            }
        }

        private static void ShowReutrn() 
        {
            int i = 1;

            if (i == 1)
            {
                // 直接跳出整個method
                return;
            }
            
            //以下程式碼執行不到
            DoSomething();
        }

        private static void ShowGotoSwitch() 
        {
            // switch 用法
            int index = 1;

            int i = 1;

            switch (i)
            {
                case 0 :
                    // index ++ => index = 4;
                    index++;
                    // 結束
                    break;
                case 1:
                    // index += 2 => index = 3;
                    index += 2;
                    // 跳到case 0 程式碼執行
                    goto case 0;
                case 2:
                    index += 4;
                    break;                
            }
            Console.WriteLine(index); // output : 4
        }

        private static void ShowGotoLabel()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    goto GoHere;
                }
            }

            // DoSomething 不會執行到
            DoSomething();
            
            GoHere:
                Console.WriteLine("使用GoTo");
        }

        private static void ShowContinue()
        {
            List<string> list = new List<string>()
            {
                "Kevin",
                "Bob",
                "Miles"
            };

            foreach (var item in list)
            {
                if (item.Equals("Bob"))
                {
                    // 如果迴圈跑到Bob，則不會執行之後的程式碼，且直接進入下一個迴圈
                    continue;
                }
                Console.WriteLine(item);
            }
            // output : Kevin
            // output : Miles

        }

        private static void ShowBreak() 
        {
            List<string> list = new List<string>()
            {
                "Kevin",
                "Bob",
                "Miles"
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
                if (item.Equals("Bob"))
                {
                    // 如果迴圈跑到Bob，則會跳出整個foreach
                    break;
                }
            }
            // output : Kevin
            // output : Bob

        }

        private static void ShowFor()
        {
            var value = new[] {"Kevin", "Bob", "Smith"};

            // length = 3;
            int length = value.Length;

            // i 從 0 開始算，如果 i < 3 ，則跑一次迴圈後， i++
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(value[i]);
                // output: Kevin
                // output: Bob
                // output: Smith
            }
        }

        private static void ShowForeach()         
        {
            List<int> list = new List<int>() 
            { 
                1,2,3,4,5
            };

            // 取出所有元素，每個元素跑一次迴圈
            foreach (var item in list)
            {
                Console.WriteLine(item);
                // output : 1
                // output : 2
                // output : 3
                // output : 4
                // output : 5
            }
        }

        private void ShowIf() 
        {
            int i = 1;

            // 兩個等號，代表相等
            if (i == 1)
            {
                DoSomething();
            }

            // != 代表不相等
            if (i != 1)
            {
                DoSomething();
            }

            // 連再一起混用
            if (i == 1)
            {
                DoSomething();
            }
            else if (i == 2) 
            {
                DoSomething();
            }
            else
            {
                DoSomething();
            }

        }

        private void ShowSwitch() 
        {
            int i = 3;

            switch (i)
            {
                case 1:
                    // 如果 i == 1 則執行這段
                    DoSomething();
                    // 使用break 跳出switch
                    break;
                case 2:
                case 3:
                    // 如果 i == 2 或者 i ==3 執行這段
                    DoSomething();
                    // 使用break 跳出switch
                    break;
                default:
                    // 如果 i 不等於上敘條件，則執行這段
                    break;
            }
        }

        private static void ShowIfTernary() 
        {
            int i = 1;

            string message1;

            // 一般if 寫法
            if (i == 1)
            {
                message1 = "成立";
            }
            else
            {
                message1 = "不成立";
            }
            Console.WriteLine(message1); // output : 成立

            // 可以將上面if判斷，改寫成if 三元運算寫法，讓程式碼更容易閱讀
            string message2 = i == 1 ? "成立" : "不成立";
            Console.WriteLine(message2); // output : 成立


            // 判斷null 的用法
            string value1 = null;
            string message3;
            if (value1 == null)
            {
                message3 = "是null";
            }
            else
            {
                // 如果非null，則將value1的值傳給message3
                message3 = value1;
            }

            Console.WriteLine(message3);

            // 三元運算判斷null的用法
            string value2 = null;

            // 使用兩個??表示判斷是否為null
            // 如果是null 則 assign "是null" 字串給 message4
            // 如果不是null 則 message4 = value2
            var message4 = value2 ?? "是null"; // 結果與上敘述判斷null是一樣的
            Console.WriteLine(message4);
        }

        private static void ShowWhile() 
        {
            // do while
            int index = 1;
            // 會先跑一次迴圈，在判斷index 是否小於 10
            do
            {
                // 至少執行一次或多次
                Console.WriteLine(index);
                index++;
            } while (index < 10);

            // while
            int index2 = 1;

            // 會先判斷index 是否小於 10 ，再跑迴圈
            while (index2 < 10)
            {
                // 可能會沒有執行 或 執行多次
                Console.WriteLine(index2);
                index2++;
            }
        }

        private static void DoSomething()
        {
            throw new NotImplementedException();
        }

        
    }
}
