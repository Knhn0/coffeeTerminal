using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.DAL.Interfaces;

public interface IOrderRepository : IBaseRepository<Order>
{
    Task<Order> GetOrderByName(string name);

}