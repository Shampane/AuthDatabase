using AuthDatabase.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace AuthDatabase.Authentication.ProgramDependencies;

public static class BuilderServicesAuthExtensions
{
    public static IServiceCollection AddAuthServices(
        this IServiceCollection services
    )
    {
        services.AddAutoMapper(typeof(MappingProfile));

        return services;
    }
}
