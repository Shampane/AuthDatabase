namespace AuthDatabase.Api.ProgramDependencies;

public static class WebApplicationExtensions
{
    public static WebApplication AddExtensions(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();
        app.MapControllers();
        return app;
    }
}
