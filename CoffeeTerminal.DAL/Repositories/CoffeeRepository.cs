using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTerminal.DAL.Repositories;

public class CoffeeRepository : ICoffeeRepository
{
    private readonly ApplicationDbContext _db;

    public CoffeeRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<bool> Create(Goods entity)
    {
        await _db.Goods.AddAsync(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<Goods> Get(int id)
    {
        var resp = await _db.Goods.FirstOrDefaultAsync(x => x.Id == id);
        return resp;
    }

    public async Task<List<Goods>> Select()
    {
        return await _db.Goods.ToListAsync();
    }
    
    public async Task<bool> Delete(Goods entity)
    {
        _db.Goods.Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }
    
    
    public async Task<Goods> GetByName(string name)
    {
        return await _db.Goods.FirstOrDefaultAsync(x => x.Name == name);
    }
}