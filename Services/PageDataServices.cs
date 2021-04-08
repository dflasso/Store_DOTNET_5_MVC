using System;
using System.Collections.Generic;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using Microsoft.Extensions.Logging;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class PageDataServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        private UserModelServices _userModelServices;
        private UserProfileModelServices _userProfileModelServices;
        private ProfileModelServices _profileModelServices;
        private PermissonsOfProfileModelServices _permissonsOfProfileModelServices;

        public PageDataServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _userModelServices = new UserModelServices(this._context, this._logger);
            _userProfileModelServices = new UserProfileModelServices(context, logger);
            _profileModelServices = new ProfileModelServices(context, logger);
            _permissonsOfProfileModelServices = new PermissonsOfProfileModelServices(context, logger);
        }

        public DataPagePrivate GetDataPagePrivate(string nicknameAuth, string path)
        {
            List<Permissions> permissons = this.GetPermissions(nicknameAuth);

            DataPagePrivate dataPage = this.hasPermissonOnPage(path, permissons);

            if (dataPage.hasPermisson)
            {
                dataPage.menu = this.buildMenu(permissons);
            }
            return dataPage;
        }

        private List<MenuItem> buildMenu(List<Permissions> permissions)
        {
            List<MenuItem> menu = new List<MenuItem>();

            _logger.LogInformation("numero de permisos  "+ permissions.Count.ToString());
            foreach (Permissions pr in permissions)
            {
                if (pr.PatternPermissonId == 0)
                {
                    
                    MenuItem item = new MenuItem();
                    item.IsPrincipalMenu = true;
                    item.NameMenu = pr.NameMenu;

                    List<MenuItem> subMenu = new List<MenuItem>();
                    foreach (Permissions prSub in permissions)
                    {
                        if (pr.PermissionsId == prSub.PatternPermissonId)
                        {
                            MenuItem subItem = new MenuItem();
                            subItem.IsPrincipalMenu = false;
                            subItem.NameMenu = prSub.NameMenu;
                            subItem.Page = prSub.Page;
                            subItem.Controller =  prSub.Controller;
                            subMenu.Add(subItem);
                        }
                    }
                    if (subMenu.Count > 0)
                    {
                        item.SubMenu = subMenu;
                    }
                    menu.Add(item);
                }
            }
            _logger.LogInformation("[BUILD MENU SUCCESSFULLY] items: " + menu.Count);
            return menu;
        }

        private DataPagePrivate hasPermissonOnPage(string path, List<Permissions> permissions)
        {
            DataPagePrivate dataPage = new DataPagePrivate();
            dataPage.hasPermisson = false;
            foreach (Permissions pr in permissions)
            {
                string pathPermisson = "/"+pr.Controller;
                string pathIndexPermisson = pathPermisson + "/" +pr.Page;

                if (pathPermisson == path || pathIndexPermisson == path)
                {
                    _logger.LogInformation("[USER HAS PERMISSON] url: " + path);
                    dataPage.hasPermisson = true;
                    dataPage.TittleHeader = pr.TittleHeader;
                    dataPage.TittlePage = pr.TittlePage;
                }
            }
            if(!dataPage.hasPermisson)
            {
                _logger.LogError("[USER NOT HAS PERMISSON] url: " + path);
            }
            return dataPage;
        }

        private List<Permissions> GetPermissions(string nicknameAuth)
        {
            UserApp user = _userModelServices.findUserByNickname(nicknameAuth);
            UserProfile userProfile = _userProfileModelServices.findByUserAppId(user.UserAppId);
            Profile profile = _profileModelServices.findByProfileId(userProfile.ProfileId);
            return _permissonsOfProfileModelServices.findPermissonsOfProfile(profile);

        }
    }
}