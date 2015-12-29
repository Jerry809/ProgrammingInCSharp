using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    //[AttributeUsage(AttributeTargets.Class)] 說明此Attribute是使用在class上面
    [AttributeUsage(AttributeTargets.Class)]
    public class ShowAttribute : Attribute
    {
        private string Message { get; set; }
        public ShowAttribute(string message)
        {
            this.Message = message;
        }

        public void PrintMessage() 
        {
            Console.WriteLine(Message);
        }
    }
}
