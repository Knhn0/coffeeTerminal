using System.Diagnostics.Contracts;

namespace CoffeeTerminal.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}