namespace DaLatFood.Infrastructure.Core.RepositoryService;

public interface IEfCoreRepository<TDbContext, TEntity, TKey>
{
    Task<TEntity> FindAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TEntity> GetAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<IQueryable<TEntity>> GetQueryableAsync();
}