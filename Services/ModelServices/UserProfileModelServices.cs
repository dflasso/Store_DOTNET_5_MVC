using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class UserProfileModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        public UserProfileModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public UserProfile findByUserAppId(int UserAppId){
            UserProfile userProfileFound = new UserProfile();
            var context = this._context;

            var query = from usPr in context.Set<UserProfile>()
                        .Where(sp => sp.UserAppId == UserAppId)
                        select usPr;
             if (query.Count() == 0)
            {
                _logger.LogError("El UserAppId: " + UserAppId + " no posee registros.");
                userProfileFound = null;
            }
            else if (query.Count() > 1)
            {
                _logger.LogWarning("El UserAppId: " + UserAppId + " posee más de dos registros.");
                userProfileFound = query.Single();
            }
            else
            {
                userProfileFound = query.Single();
            }
            
            return userProfileFound;
        }

        public UserProfile save(UserProfile userProfile)
        {
            try
            {
                _context.userProfiles.Add(userProfile);
                _context.SaveChanges();
                _logger.LogInformation("[SAVE PROFILE OF USER]");
                return _context.userProfiles.Last();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE PROFILE OF USER] user-id: " + userProfile.UserAppId + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }

        public UserProfile update(int UserAppId, int profileSelectedId)
        {
            UserProfile userProfile = this.findByUserAppId(UserAppId);
            userProfile.ProfileId = profileSelectedId;
            return this.update(userProfile);

        }

        public UserProfile update(UserProfile userProfile)
        {
            try
            {
                _context.userProfiles.Update(userProfile);
                _context.SaveChanges();
                _logger.LogInformation("[UPDATE PROFILE OF USER]");
                return userProfile;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT UPDATE PROFILE OF USER] user-id: " + userProfile.UserAppId + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }



    }
}