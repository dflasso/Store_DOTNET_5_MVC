using Microsoft.Extensions.Logging;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using G10COMERCIALIZADORA_DOTNET.Security;
using System;
using System.Linq;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class RegisterUserServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        private Random random;
        private HomeAddressModelServices _homeAddressModelServices;
        private StatesModelServices _statesModelServices;
        private StatesOfUserModelServices _statesOfUserModelServices;
        private UserProfileModelServices _userProfileModelServices;
        private UserModelServices _userModelServices;
        public RegisterUserServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            random = new Random();
            _homeAddressModelServices = new HomeAddressModelServices(context, logger);
            _statesModelServices = new StatesModelServices(context, logger);
            _statesOfUserModelServices = new StatesOfUserModelServices(context, logger);
            _userProfileModelServices = new UserProfileModelServices(context, logger);
            _userModelServices = new UserModelServices(context, logger);
        }

        public Boolean tryRegister(AddUserRequest request)
        {
            HomeAddress newHomeAddress = this.buildAndSaveHomeAddressFromRequest(request);
            UserApp user = this.buildUserFromRequest(request, newHomeAddress.HomeAddressId);
            /*El Usuario registrado tendra un estado: Contraseña Temporal para 
            su posterior cambio*/
            States stateTemPassword = _statesModelServices.findByKeyword("S003");
            return this.buildAndSaveStateOfUserFromReques(user, stateTemPassword) 
            && this.builAndSaveProfileOfUser(user, request.profileSelected);
        }

        public Boolean builAndSaveProfileOfUser(UserApp user, int profileSelectedId)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.AssignmentAt = DateTime.Now;
            userProfile.ModifiedAt = DateTime.Now;
            userProfile.ProfileId = profileSelectedId;
            userProfile.UserAppId = user.UserAppId;
            userProfile = _userProfileModelServices.save(userProfile);
            return userProfile != null;

        }

        private Boolean buildAndSaveStateOfUserFromReques(UserApp user, States states)
        {
            StatesOfUser statesOfUser = new StatesOfUser();
            statesOfUser.CreateAt = DateTime.Now;
            statesOfUser.ModifiedAt = DateTime.Now;
            statesOfUser.StatesId = states.StatesId;
            statesOfUser.UserAppId = user.UserAppId;
            statesOfUser = _statesOfUserModelServices.save(statesOfUser);
            return statesOfUser != null;
        }

        private HomeAddress buildAndSaveHomeAddressFromRequest(AddUserRequest request)
        {
            HomeAddress homeAddress = new HomeAddress();
            homeAddress.City = request.city;
            homeAddress.NumHome = request.numHome;
            homeAddress.PrimaryStreet = request.mainStreet;
            homeAddress.SecondaryStreet = request.secondaryStreet;
            return _homeAddressModelServices.save(homeAddress);
        }

        private UserApp buildUserFromRequest(AddUserRequest request, int HomeAddressId)
        {
            UserApp user = new UserApp();
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
            user.Disability = null;
            user.userPassword = this.createTempPass();
            user.CreateAt = DateTime.Now;
            user.ModifiedAt = DateTime.Now;
            user.HomeAddressId = HomeAddressId;
            return _userModelServices.save(user);
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[this.random.Next(s.Length)]).ToArray());
        }

        public string createTempPass()
        {
            /*
            TODO: la contraseña temporal debe ser creada de forma randomica
            con el metodo: RandomString
            */
            string tempPass = PasswordServices.PasswordEncoder("a*2Ks1#P9");
            return tempPass;
        }
    }
}