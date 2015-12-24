using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationTypes
{
    class Program
    {
        static void Main(string[] args)
        {            
            Animal animal = new Animal();
            Dog dog = new Dog();
            Poodle poodle = new Poodle();

            TakeAnimal(dog);
        }

        private static void TakeAnimal(Animal animal)
        {
            // 用戶端傳入animal為例
            // 為了防止轉型失敗，所以我會在轉型前做型別判斷
            
            // 判斷方法一
            // 會準確判斷型別是否為Dog，Dog以外類別都為false
            var type = animal.GetType();
            if (type == typeof(Dog))
            {
                var dog = animal as Dog;
            }

            // 判斷方法二-(建議)
            // 若型別為Dog或者Dog的衍生類別(例如Poodle)，則為true
            if (animal is Dog)
            {
                var dog = animal as Dog;
            }
        }



        // 可傳入Animal類別以及其衍生類別，且會自動轉型為Animal
        private static void TakeAnimal2(Animal animal)
        {
            // 雖然參數的型別是Animal，但是呼叫端的傳入型別是Dog
            // 又因為Dog繼承自Animal，所以可以在這裡將Animal轉型為Dog            

            // 轉型方法一
            // 若轉型失敗會丟出Exception
            Dog dog1 = (Dog)animal;

            // 轉型方法二-(建議)
            // 若轉型失敗dog2 會為 null，不會有Exception
            Dog dog2 = animal as Dog;

            /*--------------------------------------------------*/

            // 傳入的型別為Dog，又因為型別只能往上轉，不能往下轉的特性，
            // 所以在這邊沒辦法轉型為poodle
            // 會丟出Exception
            Poodle poodle = (Poodle)animal;

        }

    }



    
}
