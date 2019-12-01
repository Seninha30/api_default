using Default.Domain.Entity;

namespace Default.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        User ObterPorId(int id);
        User Obter(string email, string password);
        int Add(User user);
        bool Exist(string emisl);
    }
}
