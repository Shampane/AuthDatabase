using AuthDatabase.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthDatabase.Api.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<ItemEntity> Items { get; set; }
    private readonly IConfiguration _configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("Database"));
    }
}
