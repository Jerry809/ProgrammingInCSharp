using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var url = new Uri("http://localhost:5109/Api/Products/1558");
                var client = new WebClient();

                // 讀取JSON字串 
                // {"ProductId":1558,"ProductName":"Miles","Price":200.0000,"Active":true,"Stock":2.000}
                var json = client.DownloadString(url);
                
                var serializer = new JavaScriptSerializer();
                // 將 JSON字串反序列化成Product物件
                var data = serializer.Deserialize<Product>(json);

                Console.WriteLine(data.ProductName);
            }
            //http://localhost:5109/Api/Products/1558
            
            {
                var url = new Uri("http://localhost:5109/Api/Products/1558");
                var client = new WebClient();
                var json = client.OpenRead(url);
                var serializer = new DataContractJsonSerializer(typeof(Product));
                var data = serializer.ReadObject(json) as Product;
                Console.WriteLine(data.ProductName);
            }

        }
    }
}
