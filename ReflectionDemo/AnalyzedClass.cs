using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    [ShowAttribute("hi")]
    public class AnalyzedClass
    {
        public string _stringField;

        public int _intField;

        public string MyProperty1 { get; set; }

        public string MyProperty2 { get; set; }

        public void Method() 
        {
            Console.WriteLine("I'm Method");
        }

        public string ReturnValueMethod(string message) 
        {
            return message;
        }
    }
}
