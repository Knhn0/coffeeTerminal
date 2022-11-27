using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.Service.Interfaces;

public interface IUserService
{
    Task<bool> Register(User user);
    Task<User> GetUser(int id);
    Task<User> GetUserByUsername(string username);
    Task<bool> Authentication(User user);
}