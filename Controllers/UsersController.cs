using G10COMERCIALIZADORA_DOTNET.Repositories;
using G10COMERCIALIZADORA_DOTNET.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using G10COMERCIALIZADORA_DOTNET.Models;
using System;
using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private CoreContext _context;
        private PageDataServices _pageDataServices;
        private CookiesServices _cookiesServices;
        private StatesModelServices _statesModelServices;
        private UserModelServices _userModelServices;
        private ProfileModelServices _profileModelServices;
        private RegisterUserServices _registerUserServices;
        private UpdateUserServices _updateUserServices;

        public UsersController(CoreContext context, ILogger<UsersController> logger)
        {
             _context = context;
            _pageDataServices = new PageDataServices(context, logger);
            _logger = logger;
            _statesModelServices = new StatesModelServices(context, logger);
            _userModelServices = new UserModelServices(context, logger);
            _profileModelServices = new ProfileModelServices(context,logger);
            _registerUserServices = new RegisterUserServices(context,logger);
            _updateUserServices = new UpdateUserServices(context, logger);
        }

         [HttpGet]
        public IActionResult Index()
        {
            _cookiesServices = new CookiesServices(HttpContext.Response.Cookies, HttpContext.Request.Cookies);
            if (string.IsNullOrEmpty(HttpContext.Request.Cookies[CookiesServices.nicknameCookie])
                || string.IsNullOrEmpty(HttpContext.Request.Cookies[CookiesServices.nameCookie]))
            {
                return LocalRedirect("/");
            }

            string nickname = _cookiesServices.Get(CookiesServices.nicknameCookie);
            string path = HttpContext.Request.Path;
            DataPagePrivate dataPage = _pageDataServices.GetDataPagePrivate(nickname, path);

            if (!dataPage.hasPermisson)
            {
                return LocalRedirect("/");
            }
            
            ViewBag.menu = dataPage.menu;
            ViewBag.titleHeader = dataPage.TittleHeader;
            ViewBag.userName = _cookiesServices.Get(CookiesServices.nameCookie);
            ViewData["Title"] = dataPage.TittlePage;
            ViewBag.LtsUsers =  _userModelServices.findAll();
            ViewBag.LtsProfiles = _profileModelServices.findAll();
            return View();
        }

        [HttpPost]
        public IActionResult Index(AddUserRequest request)
        {
            _registerUserServices.tryRegister(request);
            return LocalRedirect("/Users");
        }


        [HttpPost]
        public IActionResult Update(UpdateUserRequest request)
        {
            _updateUserServices.tryUpdateUser(request);
            return LocalRedirect("/Users");
        }

        
    }
}