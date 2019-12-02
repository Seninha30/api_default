using Default.Domain.Entity.Base;
using Default.Domain.Enuns;
using Default.Domain.ObjectValues;
using Default.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace Default.Domain.Entity
{
    public class User : BaseEntity
    {
        //todo criar classe base para conter Id e datas de criação, alterção e o status
        public User(Nome nome, Email email, string passWord, EnumAtivo status)
        {
            Nome = nome;
            Email = email;
            PassWord = passWord;
            SetAtivo(status);
            new AddNotifications<User>(this)
                .IfNullOrInvalidLength(x => x.PassWord, 3, 25, Msg.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("passWord", 2, 25));


            AddNotifications(nome, email);
        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string PassWord { get; private set; }
    }
}
