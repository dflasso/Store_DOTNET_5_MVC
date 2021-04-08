using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using G10COMERCIALIZADORA_DOTNET.Services;

namespace G10COMERCIALIZADORA_DOTNET.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private CoreContext _context;
        private SigninServices signinServices;
        private CookiesServices _cookiesServices;
        private UpdateCredentialsServices _updateCredentialsServices;

        public AuthController(CoreContext context, ILogger<AuthController> logger)
        {
            _logger = logger;
            _context = context;
            signinServices = new SigninServices(context, logger);
            _updateCredentialsServices = new UpdateCredentialsServices(context, logger);
            
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(SignInRequest request)
        {
            _cookiesServices = new CookiesServices(HttpContext.Response.Cookies, HttpContext.Request.Cookies);
            SignInResponse response = signinServices.TrySignIn(request);
            if (!response.IsAuth)
            {
                ViewBag.Error = response.Error;
                return View(response.ViewName);
            }
            else if (response.hasTempPassword)
            {   
                ViewBag.Error = response.Error;
                 _cookiesServices.Set("nku", response.UserNicname, 10 );
                _cookiesServices.Set("nkn", response.UserName + " " + response.UserLastname, 10 );
                return LocalRedirect(response.ViewName);
            }else {
                ViewData.Model = response;
                _cookiesServices.Set("nku", response.UserNicname, 10 );
                _cookiesServices.Set("nkn", response.UserName + " " + response.UserLastname, 10 );
                return LocalRedirect(response.ViewName);
            }
        }

        [HttpGet]
        public IActionResult UpdateCredentials()
        {
             _cookiesServices = new CookiesServices(HttpContext.Response.Cookies, HttpContext.Request.Cookies);
            if (string.IsNullOrEmpty(HttpContext.Request.Cookies[CookiesServices.nicknameCookie])
                || string.IsNullOrEmpty(HttpContext.Request.Cookies[CookiesServices.nameCookie]))
            {
                return LocalRedirect("/");
            }

            ViewBag.Nickname =  _cookiesServices.Get(CookiesServices.nicknameCookie);
            ViewBag.NameUser =  _cookiesServices.Get(CookiesServices.nameCookie);
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCredentials(UpdateCredentialsRequest request)
        {
            string msgValidation =  _updateCredentialsServices.TryUpdate(request);
            /*Si el mensaje de validación es diferente de null quiere decir que hubo problemas 
            al actualizar las credenciales del usuario*/
            if(msgValidation != null)
            {
                 _cookiesServices = new CookiesServices(HttpContext.Response.Cookies, HttpContext.Request.Cookies);
                if (string.IsNullOrEmpty(HttpContext.Request.Cookies[CookiesServices.nicknameCookie])
                    || string.IsNullOrEmpty(HttpContext.Request.Cookies[CookiesServices.nameCookie]))
                {
                    return LocalRedirect("/");
                }

                ViewBag.Nickname =  _cookiesServices.Get(CookiesServices.nicknameCookie);
                ViewBag.NameUser =  _cookiesServices.Get(CookiesServices.nameCookie);
                ViewBag.ErrorUpdate = msgValidation;
                return View();
            }
            return LocalRedirect("/App/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
