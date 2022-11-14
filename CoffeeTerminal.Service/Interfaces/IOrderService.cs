using CoffeeTerminal.Domain.Entity;

namespace CoffeeTerminal.Service.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(Order order);
    }
}