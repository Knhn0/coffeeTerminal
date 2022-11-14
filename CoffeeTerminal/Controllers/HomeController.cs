using System.ComponentModel.DataAnnotations;
using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTerminal.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : Controller
{
    private readonly ICoffeeRepository _coffeeRepository;


    public HomeController(ICoffeeRepository coffeeRepository)
    {
        _coffeeRepository = coffeeRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetById()
    {
        try
        {
            return Ok("Добро пожаловать в терминал для заказа кофе!");
        }
        catch
        {
            return BadRequest("Error...");
        }
    }
}
