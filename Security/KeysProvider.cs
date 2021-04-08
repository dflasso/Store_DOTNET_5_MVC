using System;
using System.Security.Cryptography;
using G10COMERCIALIZADORA_DOTNET.Models;

namespace G10COMERCIALIZADORA_DOTNET.Security
{
    public class KeysProvider
    {
        public static KeysApp Create(string passwordEncryptedPkcs8PrivateKey)
        {
            KeysApp keys = new KeysApp();

            using (var rsaAlg = RSA.Create(2048))
            {
                PbeParameters pbeParameters = new PbeParameters(PbeEncryptionAlgorithm.Aes256Cbc, HashAlgorithmName.SHA256, 32);
                ReadOnlySpan<char> password = passwordEncryptedPkcs8PrivateKey;

                byte[] pks8PrivateKey = rsaAlg.ExportEncryptedPkcs8PrivateKey(password,pbeParameters);

                byte[] x509Cert =  rsaAlg.ExportSubjectPublicKeyInfo();
                
                keys.Pkcs8PrivateKeyBase64 = Convert.ToBase64String(pks8PrivateKey);
                keys.X509CertBase64 = Convert.ToBase64String(x509Cert);
            }
            return keys;
        }
    }
}