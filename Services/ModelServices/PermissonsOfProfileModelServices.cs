using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class PermissonsOfProfileModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        private ProfileModelServices _profileModelServices;
        private PermissionsModelServices _permissionsModelServices;
        public PermissonsOfProfileModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _profileModelServices = new ProfileModelServices(context, logger);
            _permissionsModelServices = new PermissionsModelServices(context, logger);
        }

        public List<Permissions> findPermissonsOfProfile(Profile profile)
        {

            var context = this._context;

            var query = from pePr in context.Set<PermissonsOfProfile>()
                        join pr in context.Set<Permissions>() on pePr.PermissionsId equals pr.PermissionsId
                        where pePr.ProfileId == profile.ProfileId
                        select pr;

            return query.ToList();
        }

        public List<AllPermissonByProfile> findAllPermissonsAndSelectedOfPermisson(Profile profile)
        {
            List<AllPermissonByProfile> allPermissons = new List<AllPermissonByProfile>();

            List<Permissions> permissionsOfProfile = this.findPermissonsOfProfile(profile);

            var context = this._context;

            var query = from pr in context.Set<Permissions>()
                        select pr;

            List<Permissions> allPermissonsRegister = query.ToList();

            foreach (Permissions prR in allPermissonsRegister)
            {
                if (prR.PatternPermissonId != 0)
                {
                    AllPermissonByProfile perByProfile = new AllPermissonByProfile();
                    perByProfile.Label = prR.TittleHeader;
                    perByProfile.Value = prR.PermissionsId;
                    perByProfile.IsSelected = false;
                    foreach (Permissions prP in permissionsOfProfile)
                    {
                        if (prR.PermissionsId == prP.PermissionsId)
                        {
                            perByProfile.IsSelected = true;
                        }
                    }
                    allPermissons.Add(perByProfile);
                }
            }
            return allPermissons;
        }

        public Boolean trySaveProfileAndPermissons(NewProfileRequest request)
        {
            Profile profile = new Profile();
            if (request.Key > 0)
            {
                profile.ProfileId = request.Key;
                this.deletePermissonsOfProfile(profile);
            }
            profile = _profileModelServices.TrySaveProfile(request);
            Boolean saveSuccess = false;
            if (profile != null)
            {
                if (request.PermissonsSelected != null)
                {
                    List<Permissions> permSelected = _permissionsModelServices.findByIds(request.PermissonsSelected);
                    if (request.Key > 0)
                    {
                        permSelected.Add(new Permissions(11));
                    }

                    if (permSelected.Count > 0 && profile.ProfileId > 0)
                    {
                        List<Permissions> pathernPermissons = new List<Permissions>();

                        foreach (Permissions perm in permSelected)
                        {
                            int pttPermissonId = perm.PatternPermissonId;
                            if (pathernPermissons.Count == 0)
                            {
                                Permissions patternPerm = new Permissions();
                                patternPerm.PermissionsId = pttPermissonId;
                                pathernPermissons.Add(patternPerm);
                            }
                            else
                            {
                                Boolean hadInclud = false;
                                foreach (Permissions patt in pathernPermissons)
                                {
                                    if (patt.PermissionsId == pttPermissonId)
                                    {
                                        hadInclud = true;
                                    }
                                }

                                if (!hadInclud)
                                {
                                    Permissions patternPerm = new Permissions();
                                    patternPerm.PermissionsId = pttPermissonId;
                                    pathernPermissons.Add(patternPerm);
                                }
                            }
                        }

                        saveSuccess = this.saveManyPermissonsToProfile(pathernPermissons, profile);
                        if (saveSuccess)
                        {
                            saveSuccess = this.saveManyPermissonsToProfile(permSelected, profile);
                        }

                    }
                    else
                    {
                        _logger.LogError("[Permissons not Found]");
                    }
                }else{
                    List<Permissions> permSelected = new List<Permissions>();
                    permSelected.Add(new Permissions(11));
                    saveSuccess = this.saveManyPermissonsToProfile(permSelected, profile);
                }

            }
            else
            {
                _logger.LogError("[Profile Not Save]");
            }


            return saveSuccess;
        }

        public Boolean saveManyPermissonsToProfile(List<Permissions> permissions, Profile profile)
        {
            Boolean saveSuccess = false;
            try
            {
                List<PermissonsOfProfile> prOfProfiles = new List<PermissonsOfProfile>();
                DateTime now = DateTime.Now;
                foreach (Permissions pr in permissions)
                {
                    PermissonsOfProfile prOfProf = new PermissonsOfProfile();

                    prOfProf.PermissionsId = pr.PermissionsId;
                    prOfProf.AssignmentAt = now;
                    prOfProf.ModifiedAt = now;
                    prOfProf.ProfileId = profile.ProfileId;
                    prOfProfiles.Add(prOfProf);
                }
                _context.permissonsOfProfiles.AddRange(prOfProfiles);
                _context.SaveChanges();
                saveSuccess = true;
                _logger.LogInformation("[SAVE PERMISSONS] number:" + permissions.Count);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE PERMISSON] permissons: " + permissions.Count + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return saveSuccess;
        }

        public void deletePermissonsOfProfile(Profile profile)
        {
            try
            {
                var query = _context.permissonsOfProfiles.Where(p => p.ProfileId == profile.ProfileId);
                _context.permissonsOfProfiles.RemoveRange(query.ToList());
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[Dont delete PERMISSON OF PROFILE] profile: " + profile.ProfileId + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }

        }

        public List<ProfilesByUserRequest> findAllProfileAndFilterByUser(UserApp user)
        {
            List<ProfilesByUserRequest> profiles = new List<ProfilesByUserRequest>();
            try
            {
                var context = this._context;

                var query = from usPr in context.Set<UserProfile>()
                            join pr in context.Set<Profile>() on usPr.ProfileId equals pr.ProfileId
                            where usPr.UserAppId == user.UserAppId
                            select pr;

                Profile profileOfUser = query.Single();

                query = from pr in context.Set<Profile>()
                        select pr;
                List<Profile> allProfiles = query.ToList();

                foreach (Profile prof in allProfiles)
                {
                    ProfilesByUserRequest profRequest = new ProfilesByUserRequest();
                    profRequest.Key = prof.ProfileId.ToString();
                    profRequest.Label = prof.ProfileName;
                    profRequest.SelectedProfile = (prof.ProfileId == profileOfUser.ProfileId);
                    profiles.Add(profRequest);
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[CONFLICTS SEARCH PROFILE OF USER] userId: " + user.UserAppId + "\nExceprtion:\n" + ex.Message
               + "\n" + ex.StackTrace);
            }
            return profiles;
        }
    }
}