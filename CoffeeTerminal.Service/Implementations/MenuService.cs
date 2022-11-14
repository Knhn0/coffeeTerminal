using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Domain.Enum;
using CoffeeTerminal.Domain.Interfaces;
using CoffeeTerminal.Domain.Responce;
using CoffeeTerminal.Service.Interfaces;

namespace CoffeeTerminal.Service.Implementations;

public class MenuService : IMenuService
{
    private readonly ICoffeeRepository _coffeeRepository;

    public MenuService(ICoffeeRepository coffeeRepository)
    {
        _coffeeRepository = coffeeRepository;
    }


    public async Task<IEnumerable<Coffee>> GetMenu()
    {
        var responce = new List<Coffee>();
        try
        {
            var menu = await _coffeeRepository.Select();
            if (menu.Count == 0)
            {
                return Task
            
        }
        catch ()
        {
        }
    }

}