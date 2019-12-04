using Default.Domain.Arguments;
using Default.Domain.Entity;
using Default.Domain.Interfaces;
using Default.Domain.Interfaces.Repository;
using Default.Domain.ObjectValues;
using Default.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace Default.Domain.Service
{
    public class UserService : Notifiable, IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserResponse AddUser(UserRequest request)
        {
            if (request == null)
            {
                AddNotification("UserRequest", Msg.OBJETO_X0_E_OBRIGATORIO.ToFormat("UserRequest"));
                return null;
            }

            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);

            Email email = new Email(request.Email);

            User user = new User(nome, email, request.PassWord, Enuns.EnumAtivo.Ativo);


            if (user.PassWord.Length < 3)
            {
                throw new Exception("A senha deve conter mais que 3 caracteres");
            }

            AddNotifications(user);

            if (IsInvalid())
                return null;

            _userRepository.Add(user);

            return (UserResponse)user;
        }


        public UserAutenticResponse UsersAutentic(UserAutenticRequest request)
        {
            if (request == null)
            {
                AddNotification("UserAutenticRequest", Msg.OBJETO_X0_E_OBRIGATORIO.ToFormat("UserAutenticRequest"));
                return null;
            }

            var email = new Email(request.Email);
            var user = new User(email, request.Password);

            user = _userRepository.Obter(user.Email.Endereco, user.Nome.PrimeiroNome);

            if(user == null)
            {
                AddNotification("usuário", Msg.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            return (UserAutenticResponse)user;
        }
    }
}
