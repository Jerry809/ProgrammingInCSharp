using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HowToGetTypedata
{
    public class DynamicInstance
    {
        public void Main() 
        {
            // 方法一
            var newAnimal = Activator.CreateInstance(typeof(Animal)) as Animal;
                
            // 方法二
            // 使用預設建構式
            var animalConstructor = typeof(Animal).GetConstructors()[0];
            var newAnimal2 = animalConstructor.Invoke(null) as Animal;

            // 存取屬性
            //var animal = new Animal();

            //Type type = animal.GetType();

            //PropertyInfo property = type.GetProperty("NumberOfLegs");

            //var value = property.GetValue(animal);

            //Console.WriteLine(value); // output : 4            

            // 呼叫方法
            var animal = new Animal();

            Type type = animal.GetType();

            MethodInfo method = type.GetMethod("SayWoo");

            var value = method.Invoke(animal, null).ToString();

            Console.WriteLine(value); // output : Woo            


        }
    }
}
