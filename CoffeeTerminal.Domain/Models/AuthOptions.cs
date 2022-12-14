using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace CoffeeTerminal.Domain.Models;

public class AuthOptions
{
    public const string ISSUER = "Knhn0"; // издатель токена
    public const string AUDIENCE = "MyAuthClient"; // потребитель токена
    const string KEY = "mysupersecret_secretkey!123";   // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
}