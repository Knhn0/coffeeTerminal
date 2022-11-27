using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using CoffeeTerminal.DAL;
using CoffeeTerminal.DAL.Interfaces;
using CoffeeTerminal.DAL.Repositories;
using CoffeeTerminal.Domain.Models;
using CoffeeTerminal.Service.Implementations;
using CoffeeTerminal.Service.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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

// Add autorization
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => 
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // Set up setting of Token Validation
            ValidateIssuer = true,
            // Set up Issuer
            ValidIssuer = AuthOptions.ISSUER,
            // Validation Audience
            ValidateAudience = true,
            //  Set up Token Audience
            ValidAudience = AuthOptions.AUDIENCE,
            // Token validation
            ValidateLifetime = true,
            // Set up security key
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            // Security key validation
            ValidateIssuerSigningKey = true,
        };
    });


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

app.UseAuthentication();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

// Generate JWT token
app.Map("/login/{username}", (string username) => 
{
    var claims = new List<Claim> {new Claim(ClaimTypes.Name, username) };
    // Creating JWT token
    var jwt = new JwtSecurityToken(
        issuer: AuthOptions.ISSUER,
        audience: AuthOptions.AUDIENCE,
        claims: claims,
        expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
        signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            
    return new JwtSecurityTokenHandler().WriteToken(jwt);
});
 
app.Map("/data", [Authorize] () => new { message= "Hello World!" });

app.Run();
