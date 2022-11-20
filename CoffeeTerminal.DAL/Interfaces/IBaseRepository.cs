using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces;

public interface IBaseRepository<T>
{
    Task<bool> Create(T entity);

    Task<T> Get(int id);

    Task<List<T>> Select();

    //void Delete(T entity);
    Task<bool> Delete(T entity);
}