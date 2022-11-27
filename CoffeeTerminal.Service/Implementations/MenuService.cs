using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;

using CoffeeTerminal.Service.Interfaces;

namespace CoffeeTerminal.Service.Implementations;

public class MenuService : IMenuService
{
    private readonly ICoffeeRepository _coffeeRepository;

    public MenuService(ICoffeeRepository coffeeRepository)
    {
        _coffeeRepository = coffeeRepository;
    }

    public async Task<List<Goods>> GetMenu()
    {
        var collection = _coffeeRepository.Select();
        return await collection;
    }
    
}