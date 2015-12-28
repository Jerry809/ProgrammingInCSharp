using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToGetTypedata
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicInstance a = new DynamicInstance();
            a.Main();
            //var dog = new Animal() { NumberOfLegs = 4 };

            //// 方法一 編譯時期取得
            //Type t1 = typeof(Animal);            

            //// 方法二 執行時期取得
            //Type t2 = dog.GetType();

            //Console.WriteLine(t2.Name);
            //// output: Animal

            //Console.WriteLine(t2.FullName);
            //// output: HowToGetTypedata.Animal

            //Console.WriteLine(t2.Assembly);
            //// output: HowToGetTypedata, Version = 1.0.0.0,
            ////         Culture=neutral, PublicKeyToken=null

        }
    }
}
