using Default.Domain.Arguments;

namespace Default.Domain.Interfaces
{
    public interface IUserService
    {
        UserResponse AddUser(UserRequest request);
        UserAutenticResponse UsersAutentic(UserAutenticRequest request);
    }
}
