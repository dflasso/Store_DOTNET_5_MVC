using System;
using System.Text;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class HttpSessionDataServices
    {
        public static string encodeData(string value)
        {
            byte[] bytesValue = Encoding.ASCII.GetBytes(value);
            return Convert.ToBase64String(bytesValue);
        }

        public static string decodeData(string valueEncode)
        {
            byte[] bytesValue = Convert.FromBase64String(valueEncode);
            return Encoding.ASCII.GetString(bytesValue);
        }
    }
}