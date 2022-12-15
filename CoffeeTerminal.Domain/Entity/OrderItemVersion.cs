using CoffeeTerminal.Domain.Enums;

namespace CoffeeTerminal.Domain.Entity;

public class OrderItemVersion
{ 
    public List<OrderItemVersionGoods> Goods { get; set; }
    public DateTimeOffset CreationDate { get; set; }
    public DateTimeOffset ExpirationData { get; set; }
    public int Id { get; set; }
    public VersionType Type { get; set; }
}