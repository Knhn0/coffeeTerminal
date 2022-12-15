namespace CoffeeTerminal.Domain.Entity;

public class OrderItemVersionGoods
{
    public int Id { get; set; }
    public OrderItemVersion OrderItemVersion { get; set; }
    public Goods Goods { get; set; }
}