using Default.Domain.Entity;
using Default.Domain.Interfaces.Repository;

namespace Default.Infra.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public int Add(User user)
        {
            throw new System.NotImplementedException();
        }

        public bool Exist(string email)
        {
            throw new System.NotImplementedException();
        }

        public User Obter(string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public User ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
