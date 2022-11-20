using CoffeeTerminal.Domain.Entity;
using CoffeeTerminal.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTerminal.Controllers;

public class OrderController : BaseController
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("create")]
    public async Task<ActionResult<bool>> CreateOrder(Order order)
    {
        var result = await _orderService.CreateOrder(order);
        if (result == null)
        {
            return BadRequest("result is null");
        }

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<int>> GetOrderById (int id)
    {
        var order = await _orderService.Get(id);
        if (id == 0)
        {
            return BadRequest($"Id is null");
        }

        return Ok(order);
    }
}