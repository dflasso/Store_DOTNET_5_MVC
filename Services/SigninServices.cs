using System;
using System.Linq;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using G10COMERCIALIZADORA_DOTNET.Security;
using Microsoft.Extensions.Logging;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class SigninServices
    {
        private CoreContext _context;

        private readonly ILogger _logger;

        public SigninServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }


        public SignInResponse TrySignIn(SignInRequest request)
        {
            UserApp userFound = this.authenticationUser(request);
            string UserTypeDescription = "";
            States stateFound = null;
            /*
            Si no hubo errores en la autenticación se procede a Buscar 
            el estado y perfil del usuario
            */
            if (userFound != null)
            {
                UserTypeDescription = this.checkUserType(userFound);
                stateFound = this.checkStateOfUser(userFound);
            }
            return this.buildResponse(userFound, UserTypeDescription, stateFound);
        }

        private UserApp authenticationUser(SignInRequest request)
        {
            UserApp userFound = new UserApp();
            /**
            * Buscar al usuario por el correo o el nickname
            */
            var context = _context;

            var query = from user in context.Set<UserApp>()
                        .Where(u => u.userNicname == request.usernameOrEmail || u.userEmail == request.usernameOrEmail)
                        select new
                        {
                            user.UserAppId,
                            user.userNicname,
                            user.userLastname,
                            user.userName,
                            user.userEmail,
                            user.userNumDocument,
                            user.userPassword,
                            user.userType
                        };


            if (query.Count() == 0)
            {
                userFound = null;
            }
            else if (query.Count() > 1)
            {
                _logger.LogError("El nickname o email: " + request.usernameOrEmail + " posee más de dos registro.");
                userFound = null;
            }
            else
            {
                userFound.userEmail = query.Single().userEmail;
                userFound.userLastname = query.Single().userLastname;
                userFound.userName = query.Single().userName;
                userFound.userNicname = query.Single().userNicname;
                userFound.userNumDocument = query.Single().userNumDocument;
                userFound.userPassword = query.Single().userPassword;
                userFound.UserAppId = query.Single().UserAppId;
            }


            /// <summary>
            /// Si el usuario existe se procede a validar la contraseña
            /// </summary>
            if (userFound != null)
            {
                Boolean isValidPassword = PasswordServices.PasswordMatch(request.password, userFound.userPassword);
                if (!isValidPassword)
                {
                    userFound = null;
                }
            }

            return userFound;
        }

        private static ILogger initLogger()
        {
            ILoggerFactory loggerFactory = new LoggerFactory();

            return loggerFactory.CreateLogger<SigninServices>();
        }

        private string checkUserType(UserApp userFound)
        {
            string UserTypeDescription = null;
            try
            {
                TypesUsers type = (TypesUsers)userFound.userType;
                switch (type)
                {
                    case TypesUsers.ADMIN:
                        UserTypeDescription = "Administrador";
                        break;
                    case TypesUsers.CLIENTES:
                        UserTypeDescription = "Cliente";
                        break;
                    case TypesUsers.EMPLEADOS:
                        UserTypeDescription = "Empleado";
                        break;
                    case TypesUsers.PROVEEDORES:
                        UserTypeDescription = "Proveedor";
                        break;
                    default:
                        UserTypeDescription = "No Definido";
                        break;
                }
            }
            catch (System.Exception ex)
            {
                _logger.LogError("[ERROR CHECK USER TYPE]\n " + ex.Message);
                UserTypeDescription = "No Definido";
            }

            return UserTypeDescription;
        }

        private States checkStateOfUser(UserApp userFound)
        {
            States stateFound = new States();
            var context = _context;
            var query = from stOfUs in context.Set<StatesOfUser>().Where(s => s.UserAppId == userFound.UserAppId)
                        join st in context.Set<States>() on stOfUs.StatesId equals st.StatesId
                        select new { st };

            if (query.Count() == 0)
            {
                _logger.LogError("[USER NOT HAS STATE] nickname: " + userFound.userNicname);
                stateFound = null;
            }
            else if (query.Count() > 1)
            {
                _logger.LogError("[USER HAS MORE THAT ONE STATE] nickname: " + userFound.userNicname);
                stateFound = null;
            }
            else
            {
                stateFound.Keyword = query.Single().st.Keyword;
                stateFound.Description = query.Single().st.Description;
            }


            return stateFound;
        }

        private SignInResponse buildResponse(UserApp userFound, string UserTypeDescription, States stateFound)
        {
            SignInResponse response = new SignInResponse();
            if (userFound == null)
            {
                response.IsAuth = false;
                response.Error = "Usuario o Contraseña inválida";
                response.ViewName = "Login";
            }
            else if (stateFound != null)
            {
                switch (stateFound.Keyword)
                {
                    case "S001":
                        _logger.LogInformation("USER: " + userFound.userNicname + " Authentizated");
                        response.IsAuth = true;
                        response.hasTempPassword = false;
                        response.ViewName = "/App/Index";
                        response.UserEmail = userFound.userEmail;
                        response.UserLastname = userFound.userLastname;
                        response.UserName = userFound.userName;
                        response.UserNicname = userFound.userNicname;
                        response.UserNumDocument = userFound.userNumDocument;
                        response.UserTypeDescription = UserTypeDescription;
                        break;
                    case "S002":
                        _logger.LogInformation("USER: " + userFound.userNicname + " Blocked");
                        response.IsAuth = false;
                        response.Error = "Usuario bloqueado.";
                        response.ViewName = "Login";
                        break;
                    case "S003":
                        _logger.LogInformation("USER: " + userFound.userNicname + " had Temp Password");
                        response.IsAuth = true;
                        response.hasTempPassword = true;
                        response.Error = "Actualice su Contraseña.";
                        response.ViewName = "/Auth/UpdateCredentials";
                        response.UserLastname = userFound.userLastname;
                        response.UserName = userFound.userName;
                        response.UserNicname = userFound.userNicname;
                        break;
                    default:
                        response.IsAuth = false;
                        response.Error = "Usuario bloqueado.";
                        response.ViewName = "Login";
                        break;
                }
            }
            else
            {
                _logger.LogError("[USER UNAUTHORIZED]");
                response.IsAuth = false;
                response.Error = "Usuario o Contraseña inválida";
                response.ViewName = "Login";
            }


            return response;
        }

    }


}