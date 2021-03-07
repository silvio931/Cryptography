using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace OS2
{
    public class AES
    {

        public string keyRandom = "";
        public byte[] iv2;
        
        
        public AES()
        {

            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                keyRandom = Convert.ToBase64String(aes.Key);
                //int velicinaKljuca = aes.KeySize.ToString();
                byte[] iv = new byte[16];
                aes.IV = iv;
                iv2 = iv;
            }

        }

        public string EncryptString(string plainText)
        {
      
           
            byte[] array;

            using (Aes aes = Aes.Create())
            {

                ICryptoTransform encryptor = aes.CreateEncryptor(Convert.FromBase64String(keyRandom), iv2);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public string DecryptString(string cipherText, string key)
        {
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(Convert.FromBase64String(key), iv2);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }


        public string GetKey()
        {
            return keyRandom;
        }

        
    }
}
