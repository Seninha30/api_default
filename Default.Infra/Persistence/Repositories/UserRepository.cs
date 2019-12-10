using Default.Domain.Entity;
using Default.Domain.Interfaces.Repository;
using Default.Infra.Persistence.EF;
using System.Linq;

namespace Default.Infra.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DefaultContext _userContext;

        public UserRepository(DefaultContext userContext)
        {
            _userContext = userContext;
        }

        public void Add(User user)
        {
            _userContext.Add(user);
        }

        public bool Exist(string email)
        {
            return _userContext.Users.Any(x => x.Email.Endereco == email);
        }

        public User Obter(string email, string password)
        {
            return _userContext.Users.FirstOrDefault(x => x.Email.Endereco == email && x.PassWord == password);
        }

        public User ObterPorId(int id)
        {
            return _userContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
