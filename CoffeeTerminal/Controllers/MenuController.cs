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
    public ActionResult<List<Coffee>> GetMenu()
    {
        var requset = _menuService.GetMenu();
        if (requset == null)
        {
            return BadRequest("Таблица не заполнена");
        }

        return Ok($"Добро пожаловать в терминал для заказа кофе! Наше меню: {requset}");
    }
}
