using CoffeeTerminal.Domain.Entity;


namespace CoffeeTerminal.Service.Interfaces;

public interface IMenuService
{
    Task<IEnumerable<Coffee>> GetMenu();
}