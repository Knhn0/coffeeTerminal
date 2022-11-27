﻿using CoffeeTerminal.Domain.Enums;

namespace CoffeeTerminal.Domain.Entity;

public class OrderItemVersion
{ 
    public List<OrderItemVersionGoods> Goods { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ExpirationData { get; set; }
    public int Id { get; set; }
    public VersionType Type { get; set; }
}