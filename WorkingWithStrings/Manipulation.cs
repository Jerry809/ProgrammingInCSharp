using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    public class Manipulation
    {
        public void Main() 
        {
            string str = "Hello I'm Miles";

            // 從第十個字元開始，取五個長度的字元
            string value = str.Substring(10, 5); // Miles

            // 將兩個字串組在一起
            value = string.Concat(value, " is a boy"); // Miles is a boy

            //取代指定字串
            value = value.Replace("Miles", "Kevin"); // Kevin is a boy

            // 轉大寫
            value = value.ToUpper(); // KEVIN IS A BOY

            // 將每個字元切開
            var array = "Miles".ToArray();
            // array = {'M','i','l','e','s'}

            // ASCII編碼
            byte[] bytes = Encoding.ASCII.GetBytes("Miles");
            // bytes = {77,103,108,101,115}
        }
    }
}
