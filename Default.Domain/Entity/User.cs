using Default.Domain.Enuns;
using Default.Domain.ObjectValues;
using prmToolkit.NotificationPattern;

namespace Default.Domain.Entity
{
    public class User : Notifiable
    {
        //todo criar classe base para conter Id e datas de criação, alterção e o status
        public User(Nome nome, Email email, string passWord, EnumStatus status)
        {
            Nome = nome;
            Email = email;
            PassWord = passWord;
            Status = status;


        }

        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string PassWord { get; set; }
        public EnumStatus Status { get; set; }
    }
}
