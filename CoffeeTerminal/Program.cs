using AutoMapper;
using CoffeeTerminal.DAL;
using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.DAL.Repositories;
using CoffeeTerminal.Service.Implementations;
using CoffeeTerminal.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add services
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<ICoffeeRepository, CoffeeRepository>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add DbContext
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
builder.Services.BuildServiceProvider().GetService<ApplicationDbContext>()?.Database.Migrate();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

app.Run();
