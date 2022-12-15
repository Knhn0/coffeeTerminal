using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces
{
    public interface ICoffeeRepository : IBaseRepository<Goods>
    {
        Task<Goods> GetByName(string name);
    }
}