using System;
using System.Linq;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using G10COMERCIALIZADORA_DOTNET.Security;
using Microsoft.Extensions.Logging;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class UpdateCredentialsServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        private UserModelServices _userModelServices;
        private StatesModelServices _statesModelServices;
        private StatesOfUserModelServices _statesOfUserModelServices;
        public UpdateCredentialsServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _userModelServices = new UserModelServices(context, logger);
            _statesModelServices = new StatesModelServices(context, logger);
            _statesOfUserModelServices = new StatesOfUserModelServices(context, logger);
        }

        public string TryUpdate(UpdateCredentialsRequest request)
        {
            string msgValidation = null;
            var context = _context;

            var query = from user in context.Set<UserApp>()
                        .Where(u => u.userNicname == request.nickname)
                        select user;
            if(query.Count() > 0)
            {
                UserApp userFound = query.Single();
                Boolean isValidPassword = PasswordServices.PasswordMatch(request.currentPass, userFound.userPassword);
                if (!isValidPassword)
                {
                     _logger.LogError("[USER NOT MATCH CREDENCIALS] nickname: " + request.nickname);
                    msgValidation = "Nombre de Usuario o Contraseña incorrecta.";
                }
                else if(!request.newPass.Equals(request.confirmNewPass))
                {
                    _logger.LogError("[NOT MATCH NEW PASSWORD WITH CONFIRMATION] nickname: " + request.nickname);
                    msgValidation = "La contraseña nueva no coincide con la ingresada posteriormente.";
                }
                else
                {
                    userFound.userPassword = PasswordServices.PasswordEncoder(request.newPass);
                    userFound = _userModelServices.update(userFound);
                    /*Actualización del Usuario a estado Activo*/
                    States stateActive = _statesModelServices.findByKeyword("S001");
                    StatesOfUser statesOfUser = _statesOfUserModelServices.findByUserAppId(userFound.UserAppId);
                    if(statesOfUser != null)
                    {
                        statesOfUser.ModifiedAt = DateTime.Now;
                        statesOfUser.StatesId = stateActive.StatesId;
                        statesOfUser = _statesOfUserModelServices.update(statesOfUser);
                    }
                    else{
                        msgValidation = "El usuario no tiene asignado un Estado. Contáctese con soporte";
                    }
                    
                }
            }else{
                _logger.LogError("[USER NOT FOUND] nickname: " + request.nickname);
                msgValidation = "Nombre de Usuario o Contraseña incorrecta.";
            }
            return msgValidation;
        }
    }
}