using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces;

public interface IOrderRepository : IBaseRepository<Order>
{
    Task<Order> Get(int id);
    
}