using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTechniques
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            var fileName = Path.GetFileName("test.txt");

            // 加密
            File.Encrypt(fileName);
            
            // 解密
            //File.Decrypt(fileName);
                       
        }
    }
}
