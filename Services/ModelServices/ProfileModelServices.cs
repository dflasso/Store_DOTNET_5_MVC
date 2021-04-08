using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class ProfileModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;

        public ProfileModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public Profile findByProfileId(int ProfileId)
        {
            Profile profile = new Profile();
            var context = this._context;

            var query = from pr in context.Set<Profile>()
                        .Where(p => p.ProfileId == ProfileId)
                        select pr;
            if (query.Count() == 0)
            {
                _logger.LogError("El ProfileId: " + ProfileId + " no posee registros.");
                profile = null;
            }
            else if (query.Count() > 1)
            {
                _logger.LogWarning("El ProfileId: " + ProfileId + " posee más de dos registros.");
                profile = query.Single();
            }
            else
            {
                profile = query.Single();
            }

            return profile;
        }

        public List<Profile> findAll()
        {
            var context = this._context;

            var query = from pr in context.Set<Profile>()
                        select pr;

            return query.ToList();
        }

        public Boolean saveProfile(Profile profile)
        {
            Boolean saveSuccess = false;
            try
            {
                _context.profiles.Update(profile);
                _context.SaveChanges();
                saveSuccess = true;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE PERMISSON] name: " + profile.ProfileName + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return saveSuccess;
        }


        public Boolean addProfile(Profile profile)
        {
            Boolean saveSuccess = false;
            try
            {
                _context.profiles.Add(profile);
                _context.SaveChanges();
                saveSuccess = true;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE PERMISSON] name: " + profile.ProfileName + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return saveSuccess;
        }
        public Boolean saveProfile(NewProfileRequest request)
        {
            Profile newProfile = new Profile();
            newProfile.IsEnable = true;
            newProfile.ProfileId = request.Key;
            newProfile.ProfileName = request.ProfileName;
            if (request.Key > 0)
            {
                return this.saveProfile(newProfile);
            }
            else
            {
                return this.addProfile(newProfile);
            }


        }

        public int getNumberOfRegister()
        {
            return this.findAll().Count;
        }

        public Profile TrySaveProfile(NewProfileRequest request)
        {
            Boolean saveSuccess = this.saveProfile(request);
            if(saveSuccess){
                 return _context.profiles.Last();
            }   
            return null;
        }
    }
}