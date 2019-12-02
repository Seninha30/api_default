using Default.Domain.Arguments;
using Default.Domain.Entity;
using Default.Domain.Interfaces;
using Default.Domain.ObjectValues;
using Default.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace Default.Domain.Service
{
    public class UserService : Notifiable, IUserService
    {
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
       
           
            if(user.PassWord.Length < 3)
            {
                throw new Exception("A senha deve conter mais que 3 caracteres");
            }

            AddNotifications(nome, email, user);

            if (IsInvalid())
                return null;

            return new UserResponse();
        }

        public UserAutenticResponse UsersAutentic(UserAutenticRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
