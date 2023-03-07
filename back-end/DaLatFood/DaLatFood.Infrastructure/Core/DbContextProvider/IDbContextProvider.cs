namespace DaLatFood.Infrastructure.Core.DbContextProvider;

public interface IDbContextProvider<TDbContext>
{
    Task<TDbContext> GetDbContextAsync();
}