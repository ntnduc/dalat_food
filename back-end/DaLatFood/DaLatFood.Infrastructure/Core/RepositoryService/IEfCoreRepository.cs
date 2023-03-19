namespace DaLatFood.Infrastructure.Core.RepositoryService;

public interface IEfCoreRepository<TEntity, TKey>
{
    Task<TEntity> FindAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TEntity> GetAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<IQueryable<TEntity>> GetQueryableAsync();
}