using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // 使用where 指定泛型型別
    public class GenericsSimpleSample<T> where T: Dog
    {
        public T Value { private get; set; }
        
        public GenericsSimpleSample(T t)
        {
            this.Value = t;
        }

        public T GetValue() 
        {
            return this.Value;
        }
    }

    // 父類別 Dog
    public class Dog
    {
        public string Name { get; set; }

        public void Speak() 
        {
            Console.WriteLine("Woo!!");
        }
    }

    // 衍生類別繼承自 Dog
    public class Poodle : Dog
    {
        public string Color { get; set; }
    }
}
