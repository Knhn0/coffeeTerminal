using System.Text.Json.Serialization;

namespace CoffeeTerminal.Domain.Entity;

public class User
{
    public string FisrtName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public int UserId { get; set; }

    //[JsonIgnore]
    public string Password { get; set; }
}