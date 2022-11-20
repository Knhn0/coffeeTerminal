using System.Xml;
using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.DAL.Repositories;
using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Service.Interfaces;

namespace CoffeeTerminal.Service.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<bool> CreateOrder(Order order)
        {
            var result = await _orderRepository.Create(order);

            return result;
        }
        
        public async Task<Order> Get(int id)
        {
            var entity = await _orderRepository.Get(id);
            return entity;
        }

        public async Task<bool> DeleteOrder(Order order)
        {
            var result = await _orderRepository.Delete(order);
            return result;
        }

        public async Task<Order> GetOrderByName(string name)
        {
            var result = await _orderRepository.GetOrderByName(name);
            return result;
        }
    }
}