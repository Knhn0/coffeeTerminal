using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces
{
    public interface ICoffeeRepository : IBaseRepository<Coffee>
    {
        Task<Coffee> GetByName(string name);
    }
}