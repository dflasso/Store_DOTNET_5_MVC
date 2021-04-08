using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class CookiesServices
    {
        private IResponseCookies Cookies { get; }

        private IRequestCookieCollection CookiesRequest {get;}

        public static List<string> keys = new List<string>(){"nku", "nkn"};

        public static string nicknameCookie = "nku";
        public static string nameCookie = "nkn";

        public CookiesServices(IResponseCookies cookies, IRequestCookieCollection _cookiesRequest)
        {
            Cookies = cookies;
            CookiesRequest = _cookiesRequest;
        }

        /// <summary>  
        /// set the cookie  
        /// </summary>  
        /// <param name="key">key (unique indentifier)</param>  
        /// <param name="value">value to store in cookie object</param>  
        /// <param name="expireTime">expiration time</param>  
        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);    
            else
                option.Expires = DateTime.Now.AddMinutes(20);

            option.HttpOnly = true;
            value = HttpSessionDataServices.encodeData(value);
            Cookies.Append(key, value, option);
        }

        public string Get(string key)
        {
            return HttpSessionDataServices.decodeData(CookiesRequest[key]);
        }

        /// <summary>  
        /// Delete the key  
        /// </summary>  
        /// <param name="key">Key</param>  
        public void Remove(string key)
        {
            Cookies.Delete(key);
        }

        public void RemoveAll()
        {
            foreach(string ky in keys)
            {
                this.Remove(ky);
            }
        }
    }
}