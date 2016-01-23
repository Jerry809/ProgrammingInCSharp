using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "dnjuey";
            string hashValue = HashPassword(password);
            Console.WriteLine("加密後的hash value:{0}", hashValue);
            // output : 加密後的hash value:QZ+92ih3yGWMLniLsSIW3KNxSyXBta8CD3S51PxvejA=

            // 模仿輸入密碼，驗證密碼是否正確
            string inputPassowrd = "dnjuey";

            if (ValidatePassowd(inputPassowrd, hashValue))
            {
                Console.WriteLine("密碼正確");
            }
            else
            {
                Console.WriteLine("密碼錯誤");
            }
            // output: 密碼正確
        }

        private static string HashPassword(string password)
        {
            const string salt = "SecretSalt";
            
            // 密碼加鹽
            string passwordWithSalt = password + salt;

            // 將加鹽後的密碼轉成Byte
            byte[] passwordWithSaltBytes = Encoding.Default.GetBytes(passwordWithSalt);

            // 選擇SHA256加密演算法
            var hash = new SHA256CryptoServiceProvider();

            // hash 加密
            byte[] hashValue = hash.ComputeHash(passwordWithSaltBytes);

            return Convert.ToBase64String(hashValue);

        }

        private static bool ValidatePassowd(string password, string hashValue)
        {
            string validHashValue = HashPassword(password);

            return validHashValue.Equals(hashValue);
        }

    }
}
