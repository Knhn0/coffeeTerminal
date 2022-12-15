using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTerminal.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<bool> Create(User user)
    {
        await _db.Users.AddAsync(user);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<User> Get(int id)
    {
        var responce = await _db.Users.FirstOrDefaultAsync(x => x.UserId == id);
        return responce;
    }

    public async Task<List<User>> Select()
    {
        return await _db.Users.ToListAsync();
    }

    public async Task<bool> Delete(User entity)
    {
        _db.Users.Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<User> GetUserByUsername(string name)
    {
        return await _db.Users.FirstOrDefaultAsync(x => x.Username == name);
    }
}