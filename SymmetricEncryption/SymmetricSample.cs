using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SymmetricEncryption
{
    public class SymmetricSample
    {
        public byte[] Encrypt(string plainText, SymmetricAlgorithm key)
        {            
            // 建立MemoryStream，要傳入CryptoStream使用
            using (MemoryStream ms = new MemoryStream())
            {
                // 建立 CryptoStream ，建構式需傳入 1.Stream 2.指定演算法的加密方法 3.指定密碼編譯資料流的模式
                using (CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    // 將字串寫入stream，交給CryptoStream 加密
                    StreamWriter sw = new StreamWriter(cs);
                    sw.WriteLine(plainText);
                    sw.Close();
                }
                // 輸出加密後資料
                return ms.ToArray();                
            }            
        }

        public string Decrypt(byte[] buffer, SymmetricAlgorithm key) 
        {
            // 建立MemoryStream，要傳入CryptoStream使用
            using (MemoryStream ms = new MemoryStream(buffer))
            {
                // 建立 CryptoStream ，建構式需傳入 1.Stream 2.指定演算法的解密方法 3.指定密碼編譯資料流的模式
                using (CryptoStream crypstream = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    // 使用StreamReader讀取CryptoStream資料
                    using (StreamReader sr = new StreamReader(crypstream))
                    {
                        // 解密後輸出
                        return sr.ReadLine();
                    }
                }    
            }            
        }
    }
}
