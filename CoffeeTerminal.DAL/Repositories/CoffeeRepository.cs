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

    public bool Create(Coffee entity)
    {
        throw new NotImplementedException();
    }

    public Coffee Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Coffee>> Select()
    {
        return _db.Coffee.ToListAsync();
    }

    public bool Delete(Coffee entity)
    {
        throw new NotImplementedException();
    }

    public Coffee GetByName(string name)
    {
        throw new NotImplementedException();
    }
}