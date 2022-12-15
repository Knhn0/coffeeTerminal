using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.Service.Interfaces
{
    public interface IOrderService
    {
        Task<bool> CreateOrder(Order order);
        Task<Order> Get(int id);
        Task<bool> DeleteOrder(Order order);
    }
}