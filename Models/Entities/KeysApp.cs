using System;


namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class KeysApp
    {
        public int KeysAppId {get; set;}
        public DateTime CreateAt {get; set;}
        public string Pkcs8PrivateKeyBase64 {get; set;}
        public string X509CertBase64 {get; set;}
        public Boolean IsEnable {get; set;}
    }
}