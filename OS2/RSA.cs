using System;
using System.Security.Cryptography;

namespace OS2
{
    public class RSA
    {
        private readonly RSACryptoServiceProvider _csp;
        private readonly RSAParameters _privateKey;
        private readonly RSAParameters _publicKey;
        private readonly string _publicKeyString;
        private readonly string _privateKeyString;

        public RSA() : this(new RSACryptoServiceProvider(2048))
        {

        }
        public RSA(RSACryptoServiceProvider csp)
        {
            _csp = csp;
            _privateKey = _csp.ExportParameters(true);
            _publicKey = _csp.ExportParameters(false);
            _publicKeyString = PublicKeyToString();
            _privateKeyString = PrivateKeyToString();
        }

        public string PublicKeyToString()
        {
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publicKey);
            return sw.ToString();
        }

        public string PrivateKeyToString()
        {
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _privateKey);
            return sw.ToString();
        }

        public string Encrypt(string plainText)
        {
            var bytesPlainText = System.Text.Encoding.Unicode.GetBytes(plainText);
            var bytesCypherText = _csp.Encrypt(bytesPlainText, false);
            return Convert.ToBase64String(bytesCypherText);
        }

        public string Decrypt(string cypherText)
        {
            var bytesCypherText = Convert.FromBase64String(cypherText);
            byte[] bytesPlainText;
            try
            {
                bytesPlainText = _csp.Decrypt(bytesCypherText, false);
            }
            catch (Exception)
            {
                throw new CryptographicException("Pogreška.");
            }

            return System.Text.Encoding.Unicode.GetString(bytesPlainText);
        }

        public string SignHash(string message, string hashFunctionName)
        {
            byte[] output;

            RSAPKCS1SignatureFormatter signatureFormatter = new RSAPKCS1SignatureFormatter();
            signatureFormatter.SetKey(_csp);
            signatureFormatter.SetHashAlgorithm(hashFunctionName);
            byte[] originalData = Convert.FromBase64String(message);

            output = signatureFormatter.CreateSignature(originalData);

            return Convert.ToBase64String(output);
        }
        public bool VerifyHash(string signedHash, string hashFunctionName, string hash)
        {
            RSAPKCS1SignatureDeformatter signatureDeformatter = new RSAPKCS1SignatureDeformatter(_csp);
            signatureDeformatter.SetHashAlgorithm(hashFunctionName);
            byte[] originalSignedHash = Convert.FromBase64String(signedHash);
            byte[] originalHash = Convert.FromBase64String(hash);

            bool output = _csp.VerifyHash(originalHash, CryptoConfig.MapNameToOID(hashFunctionName), originalSignedHash);
            return output;
        }
    }
}
