using AuthDatabase.Api.DataAccess;
using AuthDatabase.Authentication.Controllers;
using AuthDatabase.Authentication.Models;
using Microsoft.AspNetCore.Identity;

namespace AuthDatabase.Api.ProgramDependencies;

public static class BuilderServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddApplicationPart(typeof(AccountsController).Assembly);
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddScoped<AppDbContext>();
        services
            .AddIdentity<UserEntity, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<AppDbContext>();

        return services;
    }
}
