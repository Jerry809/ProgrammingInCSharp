using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class SetGetProperty
    {
        public void Main() 
        {
            AnalyzedClass ac = new AnalyzedClass();

            // 先取得Type
            Type type = ac.GetType();

            // 取得Properies
            PropertyInfo[] properties = type.GetProperties();

            // 遍歷到我要設定的property
            foreach (PropertyInfo property in properties)
            {
                switch (property.Name)
                {
                    case "MyProperty1":
                        property.SetValue(ac, "Set Hello");
                        break;
                    case "MyProperty2":
                        property.SetValue(ac, "I'm Fine");  
                        break;
                }
            }

            // 此時ac就可以取用
            Console.WriteLine("1 : " + ac.MyProperty1); // output : 1 : Set Hello
            Console.WriteLine("2 : " + ac.MyProperty2); // output : 2 : I'm Fine

            // 或者也可以用Reflection的方式取值
            // 取得內容同上
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Value : " + property.GetValue(ac));
            }

        }
    }
}
