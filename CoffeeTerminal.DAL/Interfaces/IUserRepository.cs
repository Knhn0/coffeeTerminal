using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetUserByName(string name);
}