using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class HomeAddressModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;

        public HomeAddressModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public HomeAddress findById(int HomeAddressId)
        {
            var context = this._context;

            var query = from hm in context.Set<HomeAddress>()
                        .Where(hm => hm.HomeAddressId  == HomeAddressId)
                        select hm;
            if(query.Count() > 0)
            {
                _logger.LogError("[HOME ADDRESS FOUND] id: " + HomeAddressId);
                return query.Single();
            }
            _logger.LogError("[HOME ADDRESS NOT FOUND] id: " + HomeAddressId);
            return null;
            
        }
        

        public HomeAddress save(HomeAddress homeAddress)
        {
            try
            {
                _context.homeAddresses.Add(homeAddress);
                _context.SaveChanges();
                _logger.LogInformation("[SAVE HOME ADDRESS]");
                return _context.homeAddresses.Last();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE HOME ADDRESS] num-home: " + homeAddress.NumHome + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }

        public HomeAddress update(HomeAddress homeAddress)
        {
            try
            {
                _context.homeAddresses.Update(homeAddress);
                _context.SaveChanges();
                _logger.LogInformation("[UPDATE HOME ADDRESS]");
                return homeAddress;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT UPDATE HOME ADDRESS] num-home: " + homeAddress.NumHome + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return null;
        }
    }
}