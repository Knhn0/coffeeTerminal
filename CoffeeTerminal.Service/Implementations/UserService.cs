using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Service.Interfaces;

namespace CoffeeTerminal.Service.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<bool> Register(User user)
    {
        if ((user.Username == null) || (user.Password == null))
        {
            return false;
        }
        var result = await _userRepository.Create(user);

        return result;
    }

public Task<User> GetUser(int id)
{
    throw new NotImplementedException();
}

public Task<User> GetUserByUsername(string username)
{
    throw new NotImplementedException();
}

public Task<bool> Authentication(User user)
{
    throw new NotImplementedException();
}

}