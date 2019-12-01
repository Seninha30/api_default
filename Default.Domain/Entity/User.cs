using Default.Domain.Entity.Base;
using Default.Domain.Enuns;
using Default.Domain.ObjectValues;

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
            Ativo = status;
        }

        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string PassWord { get; set; }
    }
}
