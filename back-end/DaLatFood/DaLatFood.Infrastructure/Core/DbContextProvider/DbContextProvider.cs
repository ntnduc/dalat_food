using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DaLatFood.Infrastructure.Core.DbContextProvider;

public class DbContextProvider<TDbContext> : IDbContextProvider<
#nullable disable 
    TDbContext> where TDbContext : DbContext
{
    private readonly IServiceProvider _serviceProvider;

    public DbContextProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task<TDbContext> GetDbContextAsync()
    {
        return Task.FromResult<TDbContext>(_serviceProvider.GetRequiredService<TDbContext>());
    }
}