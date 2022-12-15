using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetUserByUsername(string name);
    Task<bool> Create(User user);
    Task<User> Get(int id);
    Task<bool> Delete(User entity);
}