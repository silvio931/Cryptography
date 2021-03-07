using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OS2
{
    public class SHA256
    {
        private byte[] _hashedText;

        public void GetData(string data)
        {
            var crypt = new SHA256Managed();
            _hashedText = crypt.ComputeHash(Encoding.UTF8.GetBytes(data));
        }

        public string ReturnHash()
        {
            return Convert.ToBase64String(_hashedText);
        }
    }
}
