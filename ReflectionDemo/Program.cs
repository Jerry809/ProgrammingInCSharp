using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SetGetProperty sgp = new SetGetProperty();
            sgp.Main();
            //AnalyzedClass ac = new AnalyzedClass();

            //Type type = ac.GetType();
            
            //// 分析Type
            //AnalyzeType(type);

            //// 分析成員
            //AnalyzeFieldInfo(type.GetFields());

            ////分析方法
            //AnalyzeMethodInfo(type.GetMethods());

            ////分析方法參數
            //foreach (var method in type.GetMethods())
            //{
            //    AnalyzeMethodParameterInfo(method.GetParameters());
            //}
            ////分析屬性
            //AnalyzeProperyInfo(type.GetProperties());

            ////分析特性
            //AnalyzeAttributeInfo(type);

        }

        // 分析Type
        private static void AnalyzeType(Type type)
        {
            // 型別名稱
            Console.WriteLine("型別名稱: " + type.Name);
            // output: AnalyzedClass

            // 型別種類
            Console.WriteLine("型別種類: " + type.Attributes);
            // output: AutoLayout, AnsiClass, Class, public, BeforeFieldInit

            // 型別的GUID
            Console.WriteLine("型別的GUID: " + type.GUID);
            // output:be2ebf30-5119..........
        }

        //分析成員
        private static void AnalyzeFieldInfo(FieldInfo[] fields) 
        {
            foreach (var field in fields)
            {
                // 成員名稱
                Console.WriteLine("成員名稱: " + field.Name);
                // output: _stringField 與 _intField

                // 成員種類
                Console.WriteLine("成員種類: " + field.Attributes);
                // output: public 與 public
                
                // 成員型別
                Console.WriteLine("成員型別: " + field.FieldType);
                // output: System.String 與 System.Int32
            }
        }

        //分析方法
        private static void AnalyzeMethodInfo(MethodInfo[] methods)
        {
            foreach (var method in methods)
            {
                // 方法名稱
                Console.WriteLine("方法名稱: " + method.Name);
                // output: Method 與 ReturnValueMethod

                // 方法類別
                Console.WriteLine("方法類別: " + method.Attributes);
                // output: PrivateScope, Public, HideBySig 
                //         與 PrivateScope, Public, HideBySig 

                // 實際上output : 還有很多沒列出來，例如get,set 的 property方法
                // 與物件的方法，例如GetType,ToString,Equals....等。
                // 這些方法都會被分析出來
            }
        }

        //分析方法參數
        private static void AnalyzeMethodParameterInfo(ParameterInfo[] parameters)
        {
            foreach (var parameter in parameters)
            {
                // 參數名稱
                Console.WriteLine("參數名稱: " + parameter.Name);
                // output: message

                // 參數種類
                Console.WriteLine("參數種類: " + parameter.Attributes);
                // output: None

                // 參數型別
                Console.WriteLine("參數型別: " + parameter.ParameterType);
                // output: System.String
            }
        }

        //分析屬性
        private static void AnalyzeProperyInfo(PropertyInfo[] properites)
        {
            foreach (var properiy in properites)
            {
                // 屬性名稱
                Console.WriteLine("屬性名稱: " + properiy.Name);
                // output : MyProperty1 與 MyProperty2

                // 屬性型別
                Console.WriteLine("屬性型別: " + properiy.PropertyType);
                // output : System.String 與 System.String

                // 屬性種類
                Console.WriteLine("屬性種類: " + properiy.Attributes);
                // output : None 與 None

                //是否可讀
                Console.WriteLine("是否可讀: " + properiy.CanRead);
                // output : true 與 true

                //是否可寫
                Console.WriteLine("是否可寫: " + properiy.CanWrite);
                // output : true 與 true

            }
        }

        //分析特性
        private static void AnalyzeAttributeInfo(Type type)
        {
            // 取得屬性類別
            ShowAttribute attr = Attribute.GetCustomAttribute(type, typeof(ShowAttribute)) as ShowAttribute;

            attr.PrintMessage(); // output : hi
            
        }

    }
}
