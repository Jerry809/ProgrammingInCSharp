using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 泛型指定為Dog
            GenericsSimpleSample<Dog> g = new GenericsSimpleSample<Dog>(new Dog());

            Console.WriteLine(g.GetValue().ToString()); // output : Generics.Dog

            // 泛型指定為Poodle
            GenericsSimpleSample<Poodle> g2 = new GenericsSimpleSample<Poodle>(new Poodle());

            Console.WriteLine(g2.GetValue().ToString()); // output : Generics.Poodle

        }


        private static void BoxingAndUnboxing()
        {
            object o = new object();

            int i = 1;

            // 裝箱
            o = i;

            // 拆箱
            int j = (int)o;
            
        }
    }
}
