using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TestMath tm = new TestMath();
            int value = tm.SquareMath(50);

            Console.WriteLine(value);
        }

        private static int SquareMath(int value) 
        {
            // 事先驗證            
            Contract.Requires(value > 0);
            
            // 事後驗證
            Contract.Ensures(Contract.Result<int>() == value * value);

            return value * value;
        }
    }
}


            ////Main m = new Main();
            ////m.Run();

            //TestUseful tu = new TestUseful();
            //tu.Id = 1;
            //tu.Name = "Miles";
            ////tu.Run();
            //tu.Initialize(null, 1);