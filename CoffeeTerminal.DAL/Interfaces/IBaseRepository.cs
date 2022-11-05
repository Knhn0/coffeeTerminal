using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T entity);

        T Get(int id);

        Task<List<Coffee>> Select();

        bool Delete(T entity);
        
    }
}