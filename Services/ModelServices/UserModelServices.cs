using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class UserModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;

        public UserModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public UserApp findUserByNickname(string nickname)
        {
            UserApp userFound = new UserApp();
            /**
            * Buscar al usuario por el correo o el nickname
            */
            var context = this._context;

            var query = from user in context.Set<UserApp>()
                        .Where(u => u.userNicname == nickname)
                        select new
                        {
                            user.UserAppId,
                            user.userNicname,
                            user.userLastname,
                            user.userName,
                            user.userEmail,
                            user.userNumDocument,
                            user.userType,
                        };


            if (query.Count() == 0)
            {
                _logger.LogError("El nickname: " + nickname + " no posee registros.");
                userFound = null;
            }
            else if (query.Count() > 1)
            {
                _logger.LogError("El nickname: " + nickname + " posee más de dos registros.");
                userFound = null;
            }
            else
            {
                userFound.userEmail = query.Single().userEmail;
                userFound.userLastname = query.Single().userLastname;
                userFound.userName = query.Single().userName;
                userFound.userNicname = query.Single().userNicname;
                userFound.userNumDocument = query.Single().userNumDocument;
                userFound.UserAppId = query.Single().UserAppId;
                userFound.userType = query.Single().userType;
            }

            return userFound;
        }

        public UserApp findByUserAppId(int UserAppId)
        {
            var context = this._context;

            var query = from user in context.Set<UserApp>()
                        .Where(u => u.UserAppId == UserAppId)
                        select user;
            return query.Single();
        }

        public List<UserApp> findByType(TypesUsers type)
        {
            var context = this._context;

            var query = from user in context.Set<UserApp>()
                        .Where(u => u.userType == (int)type)
                        select user;
            return query.ToList();
        }

        public List<UserApp> findAll()
        {
            var context = this._context;
            var query = from user in context.Set<UserApp>()
                         select user;

            return query.ToList();
        }

        public UserApp save(UserApp user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                _logger.LogInformation("[SAVE USER]");
                return _context.Users.Last();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE USER] user-email: " + user.userEmail + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }

        public UserApp update(UserApp user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                _logger.LogInformation("[UPDATE USER]");
                return _context.Users.Last();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT UPDATE USER] user-email: " + user.userEmail + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }
    }
}