namespace PackIT.Infrastructure.SeedWork;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PackIT.Infrastructure.Data;

public static class WebApplicationExtension
{
    public static async Task InitializeDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var initializer =
            scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();

        await initializer.InitalizeDatabaseAsync();
    }
}
