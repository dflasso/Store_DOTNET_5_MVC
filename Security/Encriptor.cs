using System;
using System.Security.Cryptography;
using System.Text;
using G10COMERCIALIZADORA_DOTNET.Models;

namespace G10COMERCIALIZADORA_DOTNET.Security
{
    public class Encryptor
    {
        public static byte[] Encrypt(string message, KeysApp keys)
        {
            using var rsaAlg = RSA.Create();
            ReadOnlySpan<byte> source = Convert.FromBase64String(keys.X509CertBase64);
            int keysizeX509;
            rsaAlg.ImportSubjectPublicKeyInfo(source, out keysizeX509);
            return rsaAlg.Encrypt(Encoding.UTF8.GetBytes(message), RSAEncryptionPadding.Pkcs1);
        }

        public static string Decrypt(byte[] cipherText, KeysApp keys, string passwordEncryptedPkcs8PrivateKey)
        {
            string msg = null;
            try
            {
                using var rsaAlg = RSA.Create();
                ReadOnlySpan<char> password = passwordEncryptedPkcs8PrivateKey;
                ReadOnlySpan<byte> source = Convert.FromBase64String(keys.Pkcs8PrivateKeyBase64);
                int keysizePKCS;
                rsaAlg.ImportEncryptedPkcs8PrivateKey(password, source, out keysizePKCS);

                byte[] decryptedMessage = rsaAlg.Decrypt(cipherText, RSAEncryptionPadding.Pkcs1);
                msg = Encoding.UTF8.GetString(decryptedMessage);
            }
            catch (ArgumentNullException e)
            {
                Console.Write("ArgumentNullException:  \n" + e.Message);
            }
            catch (NotImplementedException e)
            {
                Console.Write("NotImplementedException\n" + e.Message);
            }
            catch (CryptographicException e)
            {
                Console.Write("CryptographicException1\n" + e.Message);
                Console.Write("\nCryptographicException3\n" + e.TargetSite);
                Console.Write("\nCryptographicException4\n" + e.StackTrace);
            }
            return msg;
        }

       
    }
}