using System.Security.Cryptography;

namespace SymmetricEncryption
{
    public class AsymmetricSample
    {
        public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo)
        {
            byte[] encryptedData;
            // 建立RSACryptoServiceProvider
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                // 傳入公鑰加密
                RSA.ImportParameters(RSAKeyInfo);

                // 執行加密
                // 參數一:傳入要被加密的資料
                // 參數二:如果使用 OAEP 填補 (只適用於執行 Microsoft Windows XP 或更新版本的電腦) 執行直接 System.Security.Cryptography.RSA
                //        加密，則為 true，如果使用 PKCS#1 v1.5 填補，則為 false。
                encryptedData = RSA.Encrypt(DataToEncrypt, false);
            }
            // 回傳用 公鑰 加密後的資料
            return encryptedData;
        }

        public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo)
        {
            byte[] decryptedData;
            // 建立RSACryptoServiceProvider
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                // 傳入私鑰解密
                RSA.ImportParameters(RSAKeyInfo);

                // 執行解密
                // 參數一:傳入要被解密的資料
                // 參數二:如果使用 OAEP 填補 (只適用於執行 Microsoft Windows XP 或更新版本的電腦) 執行直接 System.Security.Cryptography.RSA
                //        加密，則為 true，如果使用 PKCS#1 v1.5 填補，則為 false。
                decryptedData = RSA.Decrypt(DataToDecrypt, false);
            }
            // 回傳解密後的資料
            return decryptedData;
        }
    }
}