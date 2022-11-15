using System.ComponentModel.DataAnnotations;
using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTerminal.Controllers;

public class MenuController : BaseController
{
    private readonly IMenuService _menuService;

    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    [HttpGet]
    public async Task<IActionResult> GetMenu()
    {
        var requset = await _menuService.GetMenu();
        if (requset == null)
        {
            return BadRequest("Таблица не заполнена");
        }

        return Ok(requset);
    }
}
