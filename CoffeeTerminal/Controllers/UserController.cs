using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTerminal.Controllers;

public class UserController : BaseController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("registration")]
    public async Task<ActionResult<bool>> Registration(User user)
    {
        var result = await _userService.Register(user);
       
        if (result == false)
        {
            return BadRequest("Failed to create user");
        }
        return Ok(result);
    }

}