namespace PackIT.Infrastructure.Data;

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class ApplicationDbContextInitializer
{
    private readonly ILogger<ApplicationDbContextInitializer> logger;
    private readonly ApplicationDbContext dbContext;

    public ApplicationDbContextInitializer(
        ILogger<ApplicationDbContextInitializer> logger,
        ApplicationDbContext dbContext
    )
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public async Task InitalizeDatabaseAsync()
    {
        try
        {
            await this.dbContext.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "An Error occured while initialising the database.");
            throw;
        }
    }
}
