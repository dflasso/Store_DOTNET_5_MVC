using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using G10COMERCIALIZADORA_DOTNET.Services;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;

namespace G10COMERCIALIZADORA_DOTNET.Controllers
{
    public class AppController : Controller
    {
        private CoreContext _context;

        private PageDataServices _pageDataServices;
        private readonly ILogger<AppController> _logger;
        
        private CookiesServices _cookiesServices;

        public AppController(CoreContext context, ILogger<AppController> logger)
        {
            _logger = logger;
            _context = context;
            _pageDataServices = new PageDataServices(context, logger);
        }

        [HttpGet]
        public IActionResult Index()
        {
            _cookiesServices = new CookiesServices(HttpContext.Response.Cookies, HttpContext.Request.Cookies);
            if (string.IsNullOrEmpty(_cookiesServices.Get(CookiesServices.nicknameCookie))
                || string.IsNullOrEmpty(_cookiesServices.Get(CookiesServices.nameCookie)) )
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