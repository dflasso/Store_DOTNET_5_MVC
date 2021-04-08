using G10COMERCIALIZADORA_DOTNET.Repositories;
using G10COMERCIALIZADORA_DOTNET.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using G10COMERCIALIZADORA_DOTNET.Models;
using System;

namespace G10COMERCIALIZADORA_DOTNET.Controllers
{
    public class ConfigController : Controller
    {
        private CoreContext _context;
        private PageDataServices _pageDataServices;
        private readonly ILogger<ConfigController> _logger;
        private CookiesServices _cookiesServices;
        private PermissionsModelServices _permissionsModelServices;
        private ProfileModelServices _profileModelServices;
        private UserModelServices _userModelServices;
        private PermissonsOfProfileModelServices _permissonsOfProfileModelServices;
        private UserProfileModelServices _userProfileModelServices;
        public ConfigController(CoreContext context, ILogger<ConfigController> logger)
        {
            _context = context;
            _pageDataServices = new PageDataServices(context, logger);
            _logger = logger;
            _permissionsModelServices = new PermissionsModelServices(context, logger);
            _profileModelServices = new ProfileModelServices(context, logger);
            _permissonsOfProfileModelServices = new PermissonsOfProfileModelServices(context, logger);
            _userModelServices = new UserModelServices(context, logger);
            _userProfileModelServices = new UserProfileModelServices(context, logger);
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
            ViewBag.LtsPermissons = _permissionsModelServices.findAll();
            ViewBag.updatePermisson = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Permissions permissions)
        {
            Boolean updateSuccess = _permissionsModelServices.savePermisson(permissions);

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
            ViewBag.LtsPermissons = _permissionsModelServices.findAll();
            ViewBag.updatePermisson = updateSuccess;
            return View();
        }

        [HttpGet]
        public IActionResult Profile()
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
            ViewBag.LtsProfiles = _profileModelServices.findAll();
            ViewBag.LtsPermissons = _permissionsModelServices.findAll();
            
            ViewBag.updateProfile = false;
            return View();
        }

        [HttpPost]
        public IActionResult Profile(NewProfileRequest request)
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
            ViewBag.updateProfile = _permissonsOfProfileModelServices.trySaveProfileAndPermissons(request);
            ViewBag.LtsProfiles = _profileModelServices.findAll();
            ViewBag.LtsPermissons = _permissionsModelServices.findAll();
            
            return View();
        }

        [HttpPost]
        public IActionResult EditProfile(NewProfileRequest request)
        {
            ViewBag.updateProfile = _permissonsOfProfileModelServices.trySaveProfileAndPermissons(request);
            return LocalRedirect("/Config/Profile");
        }

        [HttpGet]
        public JsonResult SearchPermissons(int idProfile)
        {
            
            Profile profile = new Profile();
            profile.ProfileId = idProfile;
            return Json(_permissonsOfProfileModelServices.findAllPermissonsAndSelectedOfPermisson(profile));
        }

        [HttpGet]
        public JsonResult SearchProfilOfUser(int UserAppId)
        {
            UserApp user = new UserApp();
            user.UserAppId = UserAppId;
             return Json(_permissonsOfProfileModelServices.findAllProfileAndFilterByUser(user));
        }



        [HttpGet]
        public IActionResult PermissonsOfProfile()
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
            ViewBag.LtsProfiles = _profileModelServices.findAll();
            ViewBag.updateProfile = false;
            return View();
        }

        [HttpPost]
        public IActionResult PermissonsOfProfile(NewProfileRequest request)
        {
            ViewBag.updateProfile = _permissonsOfProfileModelServices.trySaveProfileAndPermissons(request);
            return LocalRedirect("/Config/PermissonsOfProfile");
        }


        [HttpGet]
        public IActionResult UserProfile()
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
            ViewBag.LtsUsers = _userModelServices.findAll();
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProfileOfUser(int keyUser, int newProfileSelected)
        {   
            _userProfileModelServices.update(keyUser, newProfileSelected);
            return LocalRedirect("/Config/UserProfile");
        }
    }
}