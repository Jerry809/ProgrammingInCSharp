using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    public class RegularExpression
    {
        public void Main() 
        {
            var str = @"Regular expressions are a specialized syntax 
                        to find and replace patterns in strings";

            // "\b" 比對空白
            // "\w+" 比對多個數字或英文字母
            // 意思就是比對空白之間的字串就抓出來
            var pattern = @"\b\w+\b";
            var matches = Regex.Matches(str, pattern);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
            // output:Regular
            // output:expressions
            // output:are
            // output:a
            // .......以此類推

            /*---------------------------------------------*/

            // "(Regular )" 比對Regular 字串
            // (.+) 比對一個或多個任何字元，但換行符號不算
            // ( are) 比對 are字串
            // 意思就是 比對 "Regular 任何字串 are" 就成立
            pattern = @"(Regular )(.+)( are)";
            var groups = Regex.Match(str, pattern).Groups;
            foreach (var item in groups)
            {
                Console.WriteLine(item);
            }
            // output:Regular expressions are
            // output:Regular
            // output:expressions
            // output: are

        }
    }
}
