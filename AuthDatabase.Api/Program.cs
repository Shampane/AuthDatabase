using AuthDatabase.Api.ProgramDependencies;
using AuthDatabase.Authentication.ProgramDependencies;

namespace AuthDatabase.Api;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddServices();
        builder.Services.AddAuthServices();

        var app = builder.Build();
        app.AddExtensions();

        await app.RunAsync();
    }
}
