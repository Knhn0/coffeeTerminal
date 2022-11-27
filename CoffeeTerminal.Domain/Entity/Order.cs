using System.Diagnostics.Contracts;

namespace CoffeeTerminal.Domain.Entity
{
    public class Order
    {
        public int OrderId { get; set; }

        public int TripId;

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        // public List<> OrderItem { get; set; }
    }
}