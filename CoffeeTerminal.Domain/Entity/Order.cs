namespace CoffeeTerminal.Domain.Entity
{
    public class Order
    {
        public int OrderId { get; set; }

        public string Name { get; set; }

        public decimal FinalPrice { get; set; }

        public string Description { get; set; }
    }
}