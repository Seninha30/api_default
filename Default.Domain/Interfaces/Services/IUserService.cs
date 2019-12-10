using Default.Domain.Arguments;
using Default.Domain.Interfaces.Services.Base;

namespace Default.Domain.Interfaces
{
    public interface IUserService: IServiceBase
    {
        UserResponse AddUser(UserRequest request);
        UserAutenticResponse UsersAutentic(UserAutenticRequest request);
    }
}
