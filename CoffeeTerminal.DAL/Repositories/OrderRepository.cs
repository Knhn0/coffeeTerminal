using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTerminal.DAL.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext _db;

    public OrderRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<bool> Create(Order entity)
    {
        await _db.orders.AddAsync(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<Order> Get(int id)
    {
        var responce = await _db.orders.FirstOrDefaultAsync(x => x.OrderId == id);
        return responce;
    }
    

    public async Task<List<Order>> Select()
    {
        return await _db.orders.ToListAsync();
    }

    public async Task<bool> Delete(Order entity)
    {
        _db.orders.Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<Order> GetOrderByName(string name)
    {
        return await _db.orders.FirstOrDefaultAsync(x => x.Name == name);
    }
}