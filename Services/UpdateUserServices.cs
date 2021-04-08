using Microsoft.Extensions.Logging;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class UpdateUserServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        private HomeAddressModelServices _homeAddressModelServices;
        private StatesModelServices _statesModelServices;
        private StatesOfUserModelServices _statesOfUserModelServices;
        private UserProfileModelServices _userProfileModelServices;
        private UserModelServices _userModelServices;
        public UpdateUserServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _homeAddressModelServices = new HomeAddressModelServices(context, logger);
            _statesModelServices = new StatesModelServices(context, logger);
            _statesOfUserModelServices = new StatesOfUserModelServices(context, logger);
            _userProfileModelServices = new UserProfileModelServices(context, logger);
            _userModelServices = new UserModelServices(context, logger);
        }

        public Boolean tryUpdateUser(UpdateUserRequest request)
        {
            this.GetAndUpdateHomeAddressFromRequest(request);
            this.GetAndUpdateUserAppFromRequest(request);
            return this.GetAndSaveProfileOfUser(request);
            
        }

        public UserApp GetAndUpdateUserAppFromRequest(UpdateUserRequest request)
        {
            UserApp user = _userModelServices.findByUserAppId(request.keyUser);
            user.userName = request.name;
            user.userEmail = request.emailUser;
            user.userLastname = request.lastname;
            user.userNicname = request.nickname;
            /*
            En caso de no tener un número de documento de identificación
            el sistema le asigna el número de consumidor final;
            */
            if(string.IsNullOrEmpty(request.numDocument))
            {
                user.userNumDocument = "9999999999";
            }
            else{
                user.userNumDocument = request.numDocument;
            }

            user.userPhone = request.phone;
            user.userType = request.type;
            user.CreateAt = DateTime.Now;
            user.ModifiedAt = DateTime.Now;
            return _userModelServices.update(user);
        }

        private HomeAddress GetAndUpdateHomeAddressFromRequest(UpdateUserRequest request)
        {
            HomeAddress homeAddress = _homeAddressModelServices.findById(request.keyHomeAddress);
            if(homeAddress != null)
            {
                homeAddress.City = request.city;
                homeAddress.NumHome = request.numHome;
                homeAddress.PrimaryStreet = request.mainStreet;
                homeAddress.SecondaryStreet = request.secondaryStreet;
                return _homeAddressModelServices.update(homeAddress);
            }
            return null;
            
        }

        public Boolean GetAndSaveProfileOfUser(UpdateUserRequest request)
        {
            UserProfile userProfile = _userProfileModelServices.findByUserAppId(request.keyUser);
            userProfile.ModifiedAt = DateTime.Now;
            userProfile.ProfileId = request.profileSelected;
            userProfile = _userProfileModelServices.update(userProfile);
            return userProfile != null;

        }


    }
};