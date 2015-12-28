using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    public class StringBuilderSample
    {
        public void Main()
        {
            string item = "加字串";
            StringBuilder sb = new StringBuilder();
            long startTime = DateTime.Now.Ticks; //Nanosecond            
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(item);
            }
            string str = sb.ToString();
            long endTime = DateTime.Now.Ticks; //Nanosecond

            Console.WriteLine(string.Format("花費時間 {0} nanosceond", endTime - startTime)); //nanosceond = 10的-9次方秒
            // output : 花費時間 19990 nanosceond

            //string item = "加字串";
            //long startTime = DateTime.Now.Ticks; //Nanosecond
            //string str1 = "";
            //for (int i = 0; i < 10000; i++)
            //{
            //    str1 += item;
            //}
            //long endTime = DateTime.Now.Ticks; //Nanosecond

            //Console.WriteLine(string.Format("花費時間 {0} nanosceond", endTime - startTime)); //nanosceond = 10的-9次方秒
            //// output : 花費時間 490020 nanosceond
        }
    }
}
