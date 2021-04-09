using G10COMERCIALIZADORA_DOTNET.Repositories;
using G10COMERCIALIZADORA_DOTNET.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using G10COMERCIALIZADORA_DOTNET.Models;
using System;

namespace G10COMERCIALIZADORA_DOTNET.Controllers
{
    public class EcommerceController : Controller
    {
        private CoreContext _context;
        private PageDataServices _pageDataServices;
        private readonly ILogger<EcommerceController> _logger;
        private CookiesServices _cookiesServices;
        private ProductsModelServices _productsModelServices;

        public EcommerceController(CoreContext context,  ILogger<EcommerceController> logger)
        {
            _context = context;
            _pageDataServices = new PageDataServices(context,logger);
            _logger = logger;
            _productsModelServices = new ProductsModelServices(context, logger);
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
            ViewBag.LtsProducts = _productsModelServices.findAll();
            return View();
        }

        [HttpGet]
        public IActionResult Invoice()
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
            return View();
        }
    }
}