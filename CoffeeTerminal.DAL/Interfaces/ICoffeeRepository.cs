using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces
{
    public interface ICoffeeRepository : IBaseRepository<Coffee>
    {
        Coffee GetByName(string name);
    }
}