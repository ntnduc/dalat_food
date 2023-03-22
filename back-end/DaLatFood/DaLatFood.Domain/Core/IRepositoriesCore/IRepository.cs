namespace DaLatFood.Domain.Core.IRepositoriesCore;

public interface IRepository<TEntity, TKey> 
{
    Task<TEntity> FindAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TEntity> GetAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<IQueryable<TEntity>> GetQueryableAsync();

    Task<TEntity> AddAsync(TEntity entity, bool autoSave = false);
    Task<TEntity> UpdateAsync(TEntity entity, bool autoSave = false);
    Task<TEntity> DeleteAsync(TKey id, bool autoSave = false);
}