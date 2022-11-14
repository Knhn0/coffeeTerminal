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

    public async Task<bool> Create(Coffee entity)
    {
        await _db.goods.AddAsync(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<Coffee> Get(int id)
    {
        var resp = await _db.goods.FirstOrDefaultAsync(x => x.Id == id);
        return resp;
    }

    public async Task<List<Coffee>> Select()
    {
        return await _db.goods.ToListAsync();
    }
    
    public async Task<bool> Delete(Coffee entity)
    {
        _db.goods.Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }
    
    
    public async Task<Coffee> GetByName(string name)
    {
        return await _db.goods.FirstOrDefaultAsync(x => x.Name == name);
    }
}