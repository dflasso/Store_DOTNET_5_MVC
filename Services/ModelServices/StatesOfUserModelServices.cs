using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class StatesOfUserModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;

        public StatesOfUserModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public StatesOfUser findByUserAppId(int UserAppId)
        {
            var context = this._context;

            var query = from st in context.Set<StatesOfUser>()
                        where st.UserAppId == UserAppId
                        select st;
            if(query.Count() > 0)
            {
                return query.Single();
            }
            _logger.LogError("[STATE OF USER NOT FOUND] user-id:  " + UserAppId);
            return null;
        }

        public StatesOfUser save(StatesOfUser statesOfUser)
        {
            try
            {
                _context.statesOfUsers.Add(statesOfUser);
                _context.SaveChanges();
                _logger.LogInformation("[SAVE STATE OF USER]");
                return _context.statesOfUsers.Last();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE STATE OF USER] email-user: " + statesOfUser.userApp.userEmail + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }

        public StatesOfUser update(StatesOfUser statesOfUser)
        {
            try
            {
                _context.statesOfUsers.Update(statesOfUser);
                _context.SaveChanges();
                _logger.LogInformation("[UPDATE STATE OF USER]");
                return _context.statesOfUsers.Last();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT UPDATE STATE OF USER] email-user: " + statesOfUser.userApp.userEmail + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }
    }
}