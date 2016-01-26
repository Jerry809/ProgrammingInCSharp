using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            //SymmetricSample ss = new SymmetricSample();

            //string text = "SensitiveData";
            
            //// 指定演算法
            //AesCryptoServiceProvider key = new AesCryptoServiceProvider();
            
            //// 加密
            //byte[] encryptedText = ss.Encrypt(text, key);            
            //Console.WriteLine(Convert.ToBase64String(encryptedText));

            //// 解密
            //string decryptedText = ss.Decrypt(encryptedText, key);
            //Console.WriteLine(decryptedText);

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            
            string text = "SensitiveData";

            AsymmetricSample ays = new AsymmetricSample();
            
            //指定演算法
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();            

            
            byte[] plaintext = ByteConverter.GetBytes(text);
            // 加密
            // 傳入 1.要被加密的資料 2.傳入公鑰
            byte[] encryptedtext = ays.RSAEncrypt(plaintext, RSA.ExportParameters(false));
            Console.WriteLine(ByteConverter.GetString(encryptedtext));                

            // 解密
            // 傳入 1.要被解密的資料 2.傳入私鑰
            byte[] decryptedtex = ays.RSADecrypt(encryptedtext, RSA.ExportParameters(true));
            Console.WriteLine(ByteConverter.GetString(decryptedtex));            

        }

    }
}
