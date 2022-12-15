namespace CoffeeTerminal.Domain.Entity;

public class OrderItem
{
    public int Id { get; set; }
    public List<OrderItemVersion> OrderItemVersions { get; set; }
}
