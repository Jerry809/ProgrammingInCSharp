using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInterfacesAndInheriatance
{
    class Program
    {

        public interface IDateOperater
        {
            void Save();
        }

        public interface ISerialization
        {
            void Serialized();
        }

        public class Computer : IDateOperater, ISerialization
        {
            public void Save()
            {
                throw new NotImplementedException();
            }

            public void Serialized()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            var baseClass = new BaseClass();
            var derivedOverride = new DerivedOverrideClass();
            var derivedNew = new DerivedNewClass();
            var derivedOverWrite = new DerivedOverwrite();

            baseClass.Hello();          // output : BaseClass Say Hello
            derivedOverride.Hello();    // output : DerivedOverrideClass Say Hello
            derivedNew.Hello();         // output : DerivedNewClass Say Hello
            derivedOverWrite.Hello();   // output : DerivedOverwrite Say Hello

            // 將衍生類別轉型回BaseClass的結果
            ((BaseClass)derivedOverride).Hello();   // output : DerivedOverrideClass Say Hello
            ((BaseClass)derivedNew).Hello();        // output : BaseClass Say Hello
            ((BaseClass)derivedOverWrite).Hello();  // output : BaseClass Say Hello    
        }
    }

    class BaseClass
    {
        public virtual void Hello() 
        {
            Console.WriteLine("BaseClass Say Hello");
        }
    }

    class DerivedOverrideClass : BaseClass
    {
        // 使用 override 語句
        public override void Hello()
        {
            Console.WriteLine("DerivedOverrideClass Say Hello");
        }

    }

    class DerivedNewClass : BaseClass
    {
        // 使用 new 語句
        public new void Hello() 
        {
            Console.WriteLine("DerivedNewClass Say Hello");
        }
    }

    class DerivedOverwrite : BaseClass
    {
        // 與BaseClass 同名
        public void Hello()
        {
            Console.WriteLine("DerivedOverwrite Say Hello");
        }
    }

    class MyClass1 
    {
        // 建構式，最先呼叫
        public MyClass1(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }

    class MyClass2 : MyClass1
    {
        // 建構式，次先呼叫
        public MyClass2(string name, int age)
            : base(name)
        {
            this.Age = age;
        }
        public int Age { get; set; }
    }

    class MyClass3 : MyClass2
    {
        // 建構式，最後才執行此建構式
        public MyClass3(string name, int age, string address)
            : base(name, age)
        {
            this.Address = address;
        }
        public string Address { get; set; }
    }
}
