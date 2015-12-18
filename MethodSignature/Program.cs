using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSignature
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            
            // 用具名的方式，可直接傳入第三個參數
            customer.Pay(100, method : "Credit");

            // 一定要傳參數，且會自動對應到該方法
            customer.AddPoints(10);

            // 一定要傳參數，且會自動對應到該方法
            customer.AddPoints(10, 20);

        }
    }
}
