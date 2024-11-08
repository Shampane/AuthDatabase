using AuthDatabase.Api.ProgramDependencies;

namespace AuthDatabase.Api;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddServices();

        var app = builder.Build();
        app.AddExtensions();

        await app.RunAsync();
    }
}
