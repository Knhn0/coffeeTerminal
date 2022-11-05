using CoffeeTerminal.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTerminal.DAL
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Coffee> Coffee { get; set; }
    }
}