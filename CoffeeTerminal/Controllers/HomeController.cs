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

    [HttpPost]
    public async Task<ActionResult> Index()
    {
        var response = await _coffeeRepository.Select();
        return Ok(response);
    }
}