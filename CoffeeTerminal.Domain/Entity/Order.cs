namespace CoffeeTerminal.Domain.Entity
{
    public class Order
    {
        public int OrderId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal FinalPrice { get; set; }

        public List<Coffee> Goods { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}