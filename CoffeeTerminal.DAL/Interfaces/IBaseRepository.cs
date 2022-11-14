using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);

        Task<Coffee> Get(int id);

        Task<List<Coffee>> Select();

        //void Delete(T entity);
        Task<bool> Delete(T entity);
    }
}