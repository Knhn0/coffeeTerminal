using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Domain.Interfaces;
using CoffeeTerminal.Service.Implementations;
using CoffeeTerminal.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTerminal.Controllers;
public abstract class MenuController : Controller
{

    private readonly IMenuService _menuService;

    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    [HttpGet]
    public async Task<IActionResult> GetMenu()
    {
        var responce = await _menuService.GetMenu();
        return responce.Data;
    }
}