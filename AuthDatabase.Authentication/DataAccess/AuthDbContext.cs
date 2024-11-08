using AuthDatabase.Authentication.Configuration;
using AuthDatabase.Authentication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthDatabase.Authentication.DataAccess;

public class AuthDbContext : IdentityDbContext<UserEntity>
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new RoleConfiguration());
    }
}
