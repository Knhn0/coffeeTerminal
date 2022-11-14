using System.Xml;
using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Service.Interfaces;

namespace CoffeeTerminal.Service.Implementations
{
    public class OrderService : IOrderService
    {
        public Order? CreateOrder(Order order)
        {
            if (order.OrderId == 0)
            {
                return null;
            }

            if (string.IsNullOrEmpty(order.Name))
            {
                return null;
            }

            if (order.FinalPrice <= 0)
            {
                return null;
            }

            return order;
        }
    }
}