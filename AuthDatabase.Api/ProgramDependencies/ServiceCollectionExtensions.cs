using AuthDatabase.Api.DataAccess;
using AuthDatabase.Authentication.Models;
using Microsoft.AspNetCore.Identity;

namespace AuthDatabase.Api.ProgramDependencies;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(
        this IServiceCollection services
    )
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddScoped<AppDbContext>();
        services
            .AddIdentity<UserEntity, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>();

        return services;
    }
}
